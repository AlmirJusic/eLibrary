using eLibrary.Mob.ViewModels;
using eLibrary.ModelForMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLibrary.Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojeKnjigeDetaljiPage : ContentPage
    {
        private MojeKnjigeDetaljiViewModel model=null;
        public MojeKnjigeDetaljiPage(Knjiga _knjiga)
        {
            InitializeComponent();
            BindingContext = model = new MojeKnjigeDetaljiViewModel()
            {
                knjiga = _knjiga
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (model.knjiga.PDF == null)
                pdf.IsVisible = false;
        }
       

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Knjiga;

            await Navigation.PushAsync(new KnjigaDetealjiPage(item));
        }

        private async void PDF_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PDFPage(model.knjiga.PDF));
        }
    }
}