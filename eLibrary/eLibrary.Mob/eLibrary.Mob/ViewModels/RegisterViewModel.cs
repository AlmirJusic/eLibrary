
using eLibrary.Mob.Services;
using eLibrary.Mob.Views;
using eLibrary.ModelForMobile;
using eLibrary.ModelForMobile.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _spolovi = new APIService("Spol");
        private readonly APIService _korisnici = new APIService("Korisnik");
        public RegisterViewModel()
        {
            LoadCommand = new Command(async () => await LoadGradSpol());

            RegisterCommand = new Command(async () => await Register());
        }
        
        
        string _ime = string.Empty;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }

        string _prezime = string.Empty;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        DateTime _datumRodjenja=DateTime.UtcNow;
        public DateTime DatumRodjenja { get { return _datumRodjenja; } set { SetProperty(ref _datumRodjenja, value); } }

        ObservableCollection<Grad> _Gradovi = new ObservableCollection<Grad>();
        public ObservableCollection<Grad> Gradovi 
        { 
            get { return _Gradovi; }
            set { SetProperty(ref _Gradovi, value); } 
        }
        private Grad _selectedGrad;
        public Grad SelectedGrad 
        {
            get { return _selectedGrad; }
            set { SetProperty(ref _selectedGrad, value); }
        }

        ObservableCollection<Spol> _Spolovi = new ObservableCollection<Spol>();
        public ObservableCollection<Spol> Spolovi
        {
            get { return _Spolovi; }
            set { SetProperty(ref _Spolovi, value); }
        }
        private Spol _selectedSpol;
        public Spol SelectedSpol
        {
            get { return _selectedSpol; }
            set { SetProperty(ref _selectedSpol, value); }
        }

        string _email = string.Empty;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }

        string _username = string.Empty;
        public string Username { get { return _username; } set { SetProperty(ref _username, value); } }


        string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        string _passwordConfirm = string.Empty;
        public string PasswordConfirm { get { return _passwordConfirm; } set { SetProperty(ref _passwordConfirm, value); } }


        public ICommand LoadCommand { get; set; }
        public async Task LoadGradSpol()
        {
            var gradovi = await _gradovi.Get<List<Grad>>(null); ;
            _Gradovi.Clear();
            foreach (var item in gradovi)
            {
                _Gradovi.Add(item);
            }

            var spolovi = await _spolovi.Get<List<Spol>>(null); ;
            _Spolovi.Clear();
            foreach (var item in spolovi)
            {
                _Spolovi.Add(item);
            }

            
        }

        public ICommand RegisterCommand { get; set; }

        public async Task<bool> Validate()
        {

            //var result = await _korisnici.Get<List<Korisnik>>(null);
            //foreach (var item in result)
            //    if (item.Username == Username )
            //    {
            //        await Application.Current.MainPage.DisplayAlert("Greška", "Username je zauzet!", "OK");
            //        return false;
            //    }
            //    else if (item.Email == Email )
            //    {
            //        await Application.Current.MainPage.DisplayAlert("Greška", "Email je zauzet!", "OK");
            //        return false;
            //    }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);

            if (string.IsNullOrWhiteSpace(Ime) || string.IsNullOrWhiteSpace(Prezime) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Username) ||
                string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(PasswordConfirm))
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Popunite sva polja!", "OK");
                return false;
            }
            else if (Ime.Length < 3)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Ime mora sadržavati minimalno 3 karaktera!", "OK");
                return false;
            }
            else if (Prezime.Length < 2)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Prezime mora sadržavati minimalno 2 karaktera!", "OK");
                return false;
            }
            else if (!match.Success)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Mail mora biti u formatu mail@mail.com!", "OK");
                return false;
            }
            else if (Username.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Username mora sadržavati minimalno 4 karaktera!", "OK");
                return false;
            }
            else if (SelectedGrad == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite grad!", "OK");
                return false;
            }
            else if (SelectedSpol == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite spol!", "OK");
                return false;
            }
            else if (DatumRodjenja == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite datum!", "OK");
                return false;
            }
            else if(Password!=PasswordConfirm)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Passwordi moraju biti isti!", "OK");
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task Register()
        {

            if (!await Validate())
            {
                return;
            }
            var request = new KorisnikInsertRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                Email = Email,
                Username = Username,
                Grad_ID = SelectedGrad.Grad_ID,
                Spol_ID = SelectedSpol.Spol_ID,
                Password = Password,
                PasswordConfirm = PasswordConfirm,
                DatumRodjenja = DatumRodjenja,
                Uloga_ID=2,
                Slika=null

            };

            
            try
            {
                var k = await _korisnici.Insert<Korisnik>(request);
                if (k != null)
                {
                    await Application.Current.MainPage.DisplayAlert("OK", "Uspješna registracija", "OK");
                    //await Application.Current.MainPage.Navigation.PopAsync(); 
                    APIService.LogiraniKorisnik = null;
                    APIService.Username = null;
                    APIService.Password = null;
                    Application.Current.MainPage = new LoginPage();
                }
            }
            catch (Exception)
            {

            }
        }
    }

}

