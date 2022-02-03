
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
    public class KorisnickiProfilViewModel : BaseViewModel
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _spolovi = new APIService("Spol");
        private readonly APIService _korisnici = new APIService("Korisnik");
        public KorisnickiProfilViewModel()
        {
            InitCommand = new Command(async () => await Init());

            
        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var username = APIService.Username;

            var list = await _korisnici.Get<List<Korisnik>>(null);
            foreach (var item in list )
            {
                if(item.Username==username)
                {
                    Ime = item.Ime;
                    Prezime = item.Prezime;
                    DatumRodjenja= item.DatumRodjenja;
                    Email = item.Email;
                    SelectedGrad=item.Grad ;
                    SelectedSpol=item.Spol;
                    Username = item.Username;
                    Slika = item.Slika;
                }
            }
        }


        byte[] _slika = null;
        public byte[] Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }

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


        

        

       
    }

}

