using eLibrary.Mob.Services;
using eLibrary.ModelForMobile;
using eLibrary.ModelForMobile.Requests.KorisnikKnjigaKomentar;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class KnjigaDetaljiViewModel:BaseViewModel
    {
        private readonly APIService _komentari = new APIService("KorisnikKnjigaKomentar");
        private readonly APIService _korisnici = new APIService("Korisnik");

        public KnjigaDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ObrisiCommand = new Command<KorisnikKnjigaKomentar>(async (komentar) => await Izbrisi(komentar));
            DodajCommand = new Command(async () => await Dodaj());
            KupiCommand = new Command(async () => await Kupi());
        }

        public KnjigaDetaljiViewModel(INavigation nav)
        {
            InitCommand = new Command(async () => await Init());
            ObrisiCommand = new Command<KorisnikKnjigaKomentar>(async (komentar) => await Izbrisi(komentar));
            DodajCommand = new Command(async () => await Dodaj());
            KupiCommand = new Command(async () => await Kupi());
            this.Navigation = nav;

        }
        public Knjiga knjiga { get; set; }
        public ObservableCollection<KorisnikKnjigaKomentar> KomentariList { get; set; } = new ObservableCollection<KorisnikKnjigaKomentar>();

        private readonly INavigation Navigation;


        string _komentar = null;

        public string Komentar
        {
            get { return _komentar; }
            set
            {
                SetProperty(ref _komentar, value);


            }
        }


        public ICommand InitCommand { get; set; }
        public ICommand ObrisiCommand { get; set; }

        public ICommand DodajCommand { get; set; }

        public ICommand KupiCommand { get; set; }

        public async Task Kupi()
        {

            //await Navigation.PushAsync(new PaymentPage(EKnjiga));

        }

        public async Task Dodaj()
        {
            KorisnikKnjigaKomentarInsertRequest request = new KorisnikKnjigaKomentarInsertRequest()
            {
                DatumKomentara = DateTime.Now,
                Knjiga_ID = knjiga.Knjiga_ID,
                Korisnik_ID = APIService.LogiraniKorisnik.Korisnik_ID,
                SadrzajKomentara = Komentar
            };

            if (!string.IsNullOrEmpty(Komentar))
            {
                await _komentari.Insert<KorisnikKnjigaKomentar>(request);
            }
            KomentariList.Clear();
            //List<Komentar> komentari = await _servicekomentari.get<List<Komentar>>(null);
            Komentar = null;
            await Init();
        }

        public async Task Izbrisi(KorisnikKnjigaKomentar k)
        {

            var id = k.KorisnikKnjigaKomentar_ID;
            if (k.Korisnik_ID == APIService.LogiraniKorisnik.Korisnik_ID)
            {
                await _komentari.Delete<KorisnikKnjigaKomentar>(id);
                await Init();
            }


        }

        public async Task Init()

        {
            KomentariList.Clear();
            List<KorisnikKnjigaKomentar> komentari = await _komentari.Get<List<KorisnikKnjigaKomentar>>(null);

            foreach (var k in komentari)
            {

                if (k.Knjiga_ID == knjiga.Knjiga_ID)
                {
                    k.Korisnik = await _korisnici.GetById<Korisnik>(k.Korisnik_ID);
                    KomentariList.Add(k);

                }
            }


        }

    }
}

