using eLibrary.Mob.Services;
using eLibrary.Mob.Views;
using eLibrary.ModelForMobile.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _korisnici = new APIService("Korisnik");

        string _username = string.Empty;
        //string _username = "korisnik";
        public string Username{get { return _username; }set { SetProperty(ref _username, value); }}

        string _password = string.Empty;
        //string _password = "test";
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }


        public Command LoginCommand { get; set; }
        public LoginViewModel() => LoginCommand = new Command(async () => await Login());
        public Command RegisterCommand { get; set; }

        [Obsolete]
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _korisnici.Get<dynamic>(null);
                List<ModelForMobile.Korisnik> listKorisnici = await _korisnici.Get<List<ModelForMobile.Korisnik>>(new KorisnikSearchRequest() { Username = APIService.Username });
                APIService.LogiraniKorisnik = listKorisnici.Where(x => x.Username == APIService.Username).FirstOrDefault();

                if (APIService.LogiraniKorisnik.Uloga.NazivUloge == "Korisnik")
                {
                    await Application.Current.MainPage.DisplayAlert("Obavijest", "Dobrodošli u eLibrary", "OK");
                    Application.Current.MainPage = new MainPage();

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani!", "OK");
                    
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Niste autentificirani!", "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Restart();
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani!", "OK");
                
            }
        }


    }
}
