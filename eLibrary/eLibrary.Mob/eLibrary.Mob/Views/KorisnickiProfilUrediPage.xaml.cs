using eLibrary.Mob.Services;
using eLibrary.Mob.ViewModels;
using eLibrary.ModelForMobile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.FilePicker;
using eLibrary.Mob.Converters;
using Plugin.FilePicker.Abstractions;

namespace eLibrary.Mob.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KorisnickiProfilUrediPage : ContentPage
    {
        KorisnickiProfilUrediViewModel model = null;
        public KorisnickiProfilUrediPage()
        {
            InitializeComponent();
            BindingContext = model = new KorisnickiProfilUrediViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void Spremi_Clicked(object sender, EventArgs e)
        {
            await model.Uredi();
            await Navigation.PushModalAsync(new LoginPage());
            
        }



        

        private async void slika_clicked(object sender, EventArgs e)
        {
            //var file = await CrossFilePicker.Current.PickFile();
            //string fileName;
            //if (file != null)
            //{
            //    fileName = file.FileName;
            //    var image = File.ReadAllBytes(fileName);
            //    model.Slika = image;
            //}
            FileData fileData = await CrossFilePicker.Current.PickFile();

            if(fileData!=null)
                model.Slika = fileData.DataArray;

        }
    }
}