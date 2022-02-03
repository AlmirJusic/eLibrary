using eLibrary.Mob.ViewModels;
using eLibrary.ModelForMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLibrary.Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KnjigaDetealjiPage : ContentPage
    {
        private KnjigaDetaljiViewModel model = null;
        public KnjigaDetealjiPage(Knjiga _knjiga)
        {
            InitializeComponent();
            BindingContext = model = new KnjigaDetaljiViewModel(this.Navigation)
            {
                knjiga = _knjiga
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var komentar = button?.BindingContext as KorisnikKnjigaKomentar;

            await model.Izbrisi(komentar);
        }
    }
}