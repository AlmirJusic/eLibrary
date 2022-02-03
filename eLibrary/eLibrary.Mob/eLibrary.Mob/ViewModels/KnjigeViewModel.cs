using eLibrary.Mob.Converters;
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
    public class KnjigeViewModel : BaseViewModel
    {
        private readonly APIService _knjige = new APIService("Knjiga");
        private readonly APIService _zanrovi = new APIService("Zanr");

        public KnjigeViewModel()
        {
            Title = "Knjige";
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Knjiga> KnjigeList { get; set; } = new ObservableCollection<Knjiga>();
        public ObservableCollection<Zanr> ZanroviList { get; set; } = new ObservableCollection<Zanr>();
        Zanr _selectedZanr = null;

        public Zanr SelectedZanr
        {
            get { return _selectedZanr; }
            set
            {
                SetProperty(ref _selectedZanr, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (ZanroviList.Count == 0)
            {
                var zanrList = await _zanrovi.Get<List<Zanr>>(null);

                foreach (var item in zanrList)
                {
                    ZanroviList.Add(item);
                }
            }

            if (SelectedZanr != null)
            {
                KnjigaSearchRequest search = new KnjigaSearchRequest();
                search.Zanr_ID = SelectedZanr.Zanr_ID;

                var list = await _knjige.Get<IEnumerable<Knjiga>>(search);

                KnjigeList.Clear();
                foreach (var item in list)
                {
                    KnjigeList.Add(item);
                }
            }
            else
            {
                List<Knjiga> knjigaList = await _knjige.Get<List<Knjiga>>(null);

                KnjigeList.Clear();
                foreach (var item in knjigaList)
                {

                    KnjigeList.Add(item);


                }
            }
            

        }
    }
}
