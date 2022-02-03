using eLibrary.Mob.Services;
using eLibrary.ModelForMobile;
using eLibrary.ModelForMobile.Requests.PrijedlogKnjige;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class PrijedlogKnjigeViewModel : BaseViewModel
    {
        private readonly APIService _prijedlozi = new APIService("PrijedlogKnjige");

        public PrijedlogKnjigeViewModel()
        {

            DodajCommand = new Command(async () => await DodajPrijedlog());


        }
        string _pisac = null;

        public string Pisac
        {
            get { return _pisac; }
            set
            {
                SetProperty(ref _pisac, value);


            }
        }

        string _nazivPrijedlogaKnjige = null;

        public string NazivPrijedlogaKnjige
        {
            get { return _nazivPrijedlogaKnjige; }
            set
            {
                SetProperty(ref _nazivPrijedlogaKnjige, value);


            }
        }





        public ICommand DodajCommand { get; set; }




        public async Task DodajPrijedlog()
        {
            if (string.IsNullOrEmpty(Pisac) || string.IsNullOrEmpty(NazivPrijedlogaKnjige))
            {
                await Application.Current.MainPage.DisplayAlert("Obavijest", "Morate popuniti sva polja", "OK");
                return;

            }


            PrijedlogKnjigeInsertRequest model = new PrijedlogKnjigeInsertRequest()
            {

                DatumPrijedloga = DateTime.Now,
                Korisnik_ID = APIService.LogiraniKorisnik.Korisnik_ID,
                NazivPrijedlogaKnjige = Pisac + " " + NazivPrijedlogaKnjige,
                Odgovoren = false,
                Pregledan = false


            };
            await App.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste poslali vaš prijedlog", "OK");
            await _prijedlozi.Insert<PrijedlogKnjige>(model);
            Pisac = null;
            NazivPrijedlogaKnjige = null;
        }

    }
}

