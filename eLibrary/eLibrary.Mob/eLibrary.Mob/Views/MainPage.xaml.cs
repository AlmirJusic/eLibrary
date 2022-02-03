using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using eLibrary.Mob.Models;
using eLibrary.ModelForMobile;
using eLibrary.Mob.Services;
using eLibrary.ModelForMobile.Requests.PrijedlogKnjige;

namespace eLibrary.Mob.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [Obsolete]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }
        private readonly APIService _service = new APIService("PrijedlogKnjige");
        protected async override void OnAppearing()
        {
             

            base.OnAppearing();
            var prijedlozi = await _service.Get<List<PrijedlogKnjige>>(null);
            int korisnikID = APIService.LogiraniKorisnik.Korisnik_ID;

            foreach (var item in prijedlozi)
            {
                if (korisnikID == item.Korisnik_ID && item.Odgovoren == true && item.Pregledan == false)
                {
                    await App.Current.MainPage.DisplayAlert("Obavijest", item.Opis, "OK");
                    var model = new PrijedlogKnjigeInsertRequest()
                    {
                        DatumPrijedloga = item.DatumPrijedloga,
                        NazivPrijedlogaKnjige = item.NazivPrijedlogaKnjige,
                        Korisnik_ID = item.Korisnik_ID,
                        Odgovoren = item.Odgovoren,
                        Opis = item.Opis,
                        Pregledan = true,
                        

                    };
                    await _service.Update<PrijedlogKnjige>(item.PrijedlogKnjige_ID, model);
                }

            }
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
             
                    case (int)MenuItemType.Knjige:
                        MenuPages.Add(id, new NavigationPage(new KnjigePage()));
                        break;
                    case (int)MenuItemType.MojeKnjige:
                        MenuPages.Add(id, new NavigationPage(new MojeKnjigePage()));
                        break;
                    case (int)MenuItemType.PredloziKnjigu:
                        MenuPages.Add(id, new NavigationPage(new PrijedlogKnjigePage()));
                        break;
                    case (int)MenuItemType.KorisnickiProfil:
                        MenuPages.Add(id, new NavigationPage(new KorisnickiProfilPage()));
                        break;
                    
                    case (int)MenuItemType.Logout:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}