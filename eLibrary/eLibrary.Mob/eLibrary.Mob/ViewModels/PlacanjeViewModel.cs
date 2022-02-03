using Acr.UserDialogs;
using eLibrary.Mob.Models;
using eLibrary.Mob.Services;
using eLibrary.Mob.Views;
using eLibrary.ModelForMobile;
using eLibrary.ModelForMobile.Requests.KupovinaKnjige;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    class PlacanjeViewModel : BaseViewModel
    {
        public PlacanjeViewModel()
        {
            SubmitCommand = new Command(async () => await KupiKnjigu());
        }
        public PlacanjeViewModel(INavigation nav)
        {
            SubmitCommand = new Command(async () => await KupiKnjigu());
            this.Navigation = nav;
        }
        private readonly APIService _kupovina = new APIService("KupovinaKnjige");

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string _number;
        private string _cvc;

        Korisnik korisnik = APIService.LogiraniKorisnik;
        private readonly INavigation Navigation;
        public Knjiga knjiga { get; set; }
        private string StripeTestApiKey = "pk_test_GV7CFLcgjHOmSZYvz5rmelS900NINc2cGI";

        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public string Cvc
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }
        public ICommand SubmitCommand { get; set; }

        private async Task<string> CreateTokenAsync()
        {

            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;

                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = korisnik.Ime + " " + korisnik.Prezime,
                        AddressLine1 = "Adresa 1",
                        AddressLine2 = "Adresa 2",
                        AddressCity = "Grad",
                        AddressZip = "88000",
                        AddressState = "Mostar",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "bam",

                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> MakePaymentAsync(string token)
        {

            try
            {
                StripeConfiguration.ApiKey = "sk_test_coMLyIb6JOSv9IlfMOx5Fj1g0023rONhFx";


                var options = new ChargeCreateOptions();

                options.Amount = System.Convert.ToInt64(knjiga.Cijena) * 100;
                options.Currency = "bam";
                options.Description = knjiga.NazivKnjige;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                options.ReceiptEmail = korisnik.Email.ToString();
                var service = new ChargeService();
                Charge charge = service.Create(options);
                UserDialogs.Instance.Alert("Uspješno ste platili knjigu.");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Knjige (CreateCharge)" + ex.Message);
                throw ex;
            }
        }


        public async Task KupiKnjigu()
        {

            var kupovina = await _kupovina.Get<List<KupovinaKnjige>>(null);
            bool ima = false;
            foreach (var k in kupovina)
            {
                if (k.Korisnik_ID == korisnik.Korisnik_ID && knjiga.Knjiga_ID == k.Knjiga_ID)
                    ima = true;



            }
            if (ima == true)
            {

                await App.Current.MainPage.DisplayAlert("Info", "Knjigu već imate u svojoj kolekciji!", "OK");
            }
            else
            {
                CreditCardModel = new CreditCardModel();
                CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
                CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
                CreditCardModel.Number = Number;
                CreditCardModel.Cvc = Cvc;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                try
                {
                    UserDialogs.Instance.ShowLoading("Plaćanje u toku..");
                    await Task.Run(async () =>
                    {

                        var Token = CreateTokenAsync();
                        Console.Write("Knjige" + "Token :" + Token);
                        if (Token.ToString() != null)
                        {
                            IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                        }
                        else
                        {
                            UserDialogs.Instance.Alert("Pogrešni podaci kartice", null, "OK");
                        }
                    });
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert(ex.Message, null, "OK");
                    Console.Write("Knjige" + ex.Message);
                }
                finally
                {
                    if (IsTransectionSuccess)
                    {

                        var request = new KupovinaKnjigeInsertRequest()
                        {
                            DatumKupovine = DateTime.Now,
                            Knjiga_ID = knjiga.Knjiga_ID,
                            Korisnik_ID = korisnik.Korisnik_ID,
                            Odobreno=true,
                            

                        };
                        await _kupovina.Insert<KupovinaKnjige>(request);
                        
                        Console.Write("Knjige" + "Payment Successful ");
                        UserDialogs.Instance.HideLoading();
                        await Navigation.PushAsync(new KnjigePage());
                    }
                    else
                    {

                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                        Console.Write("Knjige" + "Payment Failure ");
                    }
                }


            }



        }


    }
}
