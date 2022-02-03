using eLibrary.Mob.Models;
using eLibrary.Mob.Services;
using eLibrary.ModelForMobile;
using eLibrary.ModelForMobile.Requests.Knjiga;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class MojeKnjigeDetaljiViewModel:BaseViewModel
    {
        readonly APIService _ocjene = new APIService("KorisnikKnjigaOcjena");
        readonly APIService _knjige = new APIService("Knjiga");
        readonly APIService _recommended = new APIService("Recommendations");
        

        private OcjenaSlika _ocjenaslika1;
        public OcjenaSlika OcjenaSlika1
        {
            get { return _ocjenaslika1; ; }
            set { SetProperty(ref _ocjenaslika1, value); }
        }
        private OcjenaSlika _ocjenaslika2;
        public OcjenaSlika OcjenaSlika2
        {
            get { return _ocjenaslika2; }
            set { SetProperty(ref _ocjenaslika2, value); }
        }
        private OcjenaSlika _ocjenaslika3;
        public OcjenaSlika OcjenaSlika3
        {
            get { return _ocjenaslika3; }
            set { SetProperty(ref _ocjenaslika3, value); }
        }
        private OcjenaSlika _ocjenaslika4;
        public OcjenaSlika OcjenaSlika4
        {
            get { return _ocjenaslika4; }
            set { SetProperty(ref _ocjenaslika4, value); }
        }
        private OcjenaSlika _ocjenaslika5;
        public OcjenaSlika OcjenaSlika5
        {
            get { return _ocjenaslika5; }
            set { SetProperty(ref _ocjenaslika5, value); }
        }
        

        public ObservableCollection<Knjiga> PreporuceneKnjigeList { get; set; } = new ObservableCollection<Knjiga>();

        public MojeKnjigeDetaljiViewModel()
        {
            OcijeniSlikaCommand = new Command<string>(async (Ocjena) => await OcijeniSlika(Ocjena));

            OcjenaSlika1 = new OcjenaSlika();
            OcjenaSlika2 = new OcjenaSlika();
            OcjenaSlika3 = new OcjenaSlika();
            OcjenaSlika4 = new OcjenaSlika();
            OcjenaSlika5 = new OcjenaSlika();
        }
        public Knjiga knjiga { get; set; }
        public int Ocjena { get; set; }
        public ICommand OcijeniSlikaCommand { get; set; }
        public ICommand InitCommand { get; set; }
        


        private async Task OcijeniSlika(string _ocjena)
        {
            int OcjenaBroj = int.TryParse(_ocjena, out int value) ? value : 0;
            if (OcjenaBroj >= 1 && OcjenaBroj <= 5)
            {
                double sum = 0;
                int count = 0;
                var ocjena = await _ocjene.Get<List<KorisnikKnjigaOcjena>>(null);
                int ocjenaID = 0;
                foreach (var o in ocjena)
                {
                    if (o.Knjiga_ID == knjiga.Knjiga_ID && o.Korisnik_ID == APIService.LogiraniKorisnik.Korisnik_ID)
                    {
                        ocjenaID = o.KorisnikKnjigaOcjena_ID;

                    }


                }
                var ocjenarequest = new KorisnikKnjigaOcjena()
                {
                    Knjiga_ID = knjiga.Knjiga_ID,
                    Korisnik_ID = APIService.LogiraniKorisnik.Korisnik_ID,
                    DatumOcjene = DateTime.Now,
                    Ocjena = OcjenaBroj
                };
                if (ocjenaID != 0)
                {
                    ocjenarequest.KorisnikKnjigaOcjena_ID = ocjenaID;
                    await _ocjene.Update<KorisnikKnjigaOcjena>(ocjenaID, ocjenarequest);

                }
                else
                {
                    await _ocjene.Insert<KorisnikKnjigaOcjena>(ocjenarequest);

                }
                var ocjena2 = await _knjige.Get<List<KorisnikKnjigaOcjena>>(null);
                foreach (var o2 in ocjena2)
                {
                    if (o2.Knjiga_ID == knjiga.Knjiga_ID)
                    {
                        sum += o2.Ocjena;
                        count++;

                    }


                }
                double prosjek = sum / count;
                var request = new KnjigaInsertRequest()
                {
                    Slika = knjiga.Slika,
                    Cijena = knjiga.Cijena,
                    Ocjena = prosjek,
                    Opis = knjiga.Opis,
                    PDFDodan = knjiga.PDFDodan,
                    PDF = knjiga.PDF,
                    NazivKnjige = knjiga.NazivKnjige,
                    Pisac_ID = knjiga.Pisac_ID,
                    Zanr_ID = knjiga.Zanr_ID,
                };




                Ocjena = OcjenaBroj;
                await _knjige.Update<KnjigaInsertRequest>(knjiga.Knjiga_ID, request);

                await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste ocijenili Vašu knjigu", "OK");
                UpdateSlika();


            }
        }

        private void UpdateSlika()
        {
            var slika_prazna = new OcjenaSlika { ocjenaSlika = "ocjena_prazna.png" };
            var slika_puna = new OcjenaSlika { ocjenaSlika = "ocjena_full.png" };

            OcjenaSlika1 = slika_prazna;
            OcjenaSlika2 = slika_prazna;
            OcjenaSlika3 = slika_prazna;
            OcjenaSlika4 = slika_prazna;
            OcjenaSlika5 = slika_prazna;

            if (Ocjena >= 1)
                OcjenaSlika1 = slika_puna;
            if (Ocjena >= 2)
                OcjenaSlika2 = slika_puna;
            if (Ocjena >= 3)
                OcjenaSlika3 = slika_puna;
            if (Ocjena >= 4)
                OcjenaSlika4 = slika_puna;
            if (Ocjena == 5)
                OcjenaSlika5 = slika_puna;
        }
        public async Task Init()
        {


            UpdateSlika();
            List<Knjiga> listknjige = await _recommended.Get<List<Knjiga>>(knjiga.Knjiga_ID);

            PreporuceneKnjigeList.Clear();
            foreach (var item in listknjige)
            {
                PreporuceneKnjigeList.Add(item);
            }

        }

    }
}

