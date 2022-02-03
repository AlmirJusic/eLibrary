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
    public class KorisnickiProfilUrediViewModel:BaseViewModel
    {

        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _spolovi = new APIService("Spol");
        private readonly APIService _korisnici = new APIService("Korisnik");
        public KorisnickiProfilUrediViewModel()
        {
            InitCommand = new Command(async () => await Init());

            UrediCommand = new Command(async () => await Uredi());
        }


        byte[] _slika = null;
        public byte[] Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

        string _ime = string.Empty;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }

        string _prezime = string.Empty;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }

        DateTime _datumRodjenja = DateTime.UtcNow;
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
            set
            {
                SetProperty(ref _selectedGrad, value);
            }
        }

        ObservableCollection<Spol> _Spolovi = new ObservableCollection<Spol>();
        public ObservableCollection<Spol> Spolovi
        {
            get { return _Spolovi; }
            set
            {
                SetProperty(ref _Spolovi, value);
            }
        }
        private Spol _selectedSpol;
        public Spol SelectedSpol
        {
            get { return _selectedSpol; }
            set
            {
                SetProperty(ref _selectedSpol, value);

            }
        }

        string _email = string.Empty;
        public string Email { get { return _email; } set { SetProperty(ref _email, value); } }

        string _username = string.Empty;
        public string Username { get { return _username; } set { SetProperty(ref _username, value); } }


        string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }

        string _passwordConfirm = string.Empty;
        public string PasswordConfirm { get { return _passwordConfirm; } set { SetProperty(ref _passwordConfirm, value); } }


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var username = APIService.Username;

            var list = await _korisnici.Get<List<Korisnik>>(null);
            foreach (var item in list)
            {
                if (item.Username == username)
                {
                    korisnik = item;
                    Ime = item.Ime;
                    Prezime = item.Prezime;
                    DatumRodjenja = item.DatumRodjenja;
                    Email = item.Email;
                    SelectedGrad = item.Grad;
                    SelectedSpol = item.Spol;
                    Username = item.Username;
                    Slika = item.Slika;
                }
            }


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

        public ICommand UrediCommand { get; set; }

        public async Task <bool> Validate()
        {
            var result =await _korisnici.Get<List<Korisnik>>(null);
            foreach (var item in result)
                if (item.Username == Username && item.Korisnik_ID != korisnik.Korisnik_ID)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Username je zauzet!", "OK");
                    return false;
                }
            else if(item.Email==Email&&item.Korisnik_ID!=korisnik.Korisnik_ID)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Email je zauzet!", "OK");
                    return false;
                }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(Email);

            

            if (string.IsNullOrWhiteSpace(Ime) || string.IsNullOrWhiteSpace(Prezime) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Username)
               )
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
            //else if (SelectedGrad == null)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite grad!", "OK");
            //    return false;
            //}
            //else if (SelectedSpol == null)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite spol!", "OK");
            //    return false;
            //}
            else if (DatumRodjenja == null)
            {
                await Application .Current.MainPage.DisplayAlert("Greška", "Odaberite datum!", "OK");
                return false;
            }
            
            else
            {
                return true;
            }


        }
        public Korisnik korisnik = null;
        public async Task Uredi()
        {

            if (!await Validate())
            {
                return;
            }
            


            try
            {
                

                await _korisnici.Update<Korisnik>(korisnik.Korisnik_ID, new KorisnikInsertRequest()
                {

                    Ime = _ime,
                    Prezime = _prezime,
                    Email = _email,
                    Username = _username,
                    DatumRodjenja = _datumRodjenja,
                    
                    Grad_ID = _selectedGrad.Grad_ID,
                    Spol_ID = _selectedSpol.Spol_ID,
                    
                    Uloga_ID = 2,
                    Slika = _slika,
                    


                }) ;

                
                await Application.Current.MainPage.DisplayAlert("OK", "Uspješno ste uredili profil. Logirajte se ponovo!!", "OK");
                
                    
                    
                
            }
            catch (Exception)
            {

            }
        }
    }
}
