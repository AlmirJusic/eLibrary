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
    public partial class MojeKnjigePage : ContentPage
    {
        private MojeKnjigeViewModel model = null;
        public MojeKnjigePage()
        {
            InitializeComponent();
            BindingContext = model = new MojeKnjigeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Knjiga;
            await Navigation.PushAsync(new MojeKnjigeDetaljiPage(item));
        }
        
    }
}