using eLibrary.Mob.Services;
using eLibrary.ModelForMobile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class MojeKnjigeViewModel:BaseViewModel
    {
        private readonly APIService _knjige = new APIService("Knjiga");
        private readonly APIService _kupovina = new APIService("KupovinaKnjige");
        private readonly APIService _korisnici = new APIService("Korisnik");
        

        public MojeKnjigeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Knjiga> KnjigeList { get; set; } = new ObservableCollection<Knjiga>();


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            var kupovina = await _kupovina.Get<List<KupovinaKnjige>>(null);
            
            KnjigeList.Clear();

            

            Korisnik korisnik = await _korisnici.GetById<Korisnik>(APIService.LogiraniKorisnik.Korisnik_ID);

            List<Knjiga> knjigaList = await _knjige.Get<List<Knjiga>>(null);
            foreach (var e in knjigaList)
            {

                foreach (var kk in kupovina)
                {

                    if (APIService.LogiraniKorisnik.Korisnik_ID == kk.Korisnik_ID && e.Knjiga_ID == kk.Knjiga_ID)
                    {
                        
                        KnjigeList.Add(e);

                    }
                }


            }




        }


    }
}

