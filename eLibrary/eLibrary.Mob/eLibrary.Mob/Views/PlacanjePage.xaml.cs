using eLibrary.Mob.Models;
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
    public partial class PlacanjePage : ContentPage
    {
        private INavigation navigation;
        private PlacanjeViewModel model = null;
        public PlacanjePage(Knjiga eknjiga)
        {
            InitializeComponent();
            var nav = new NavigationPage(new KnjigePage());
            navigation = nav.Navigation;


            BindingContext = model = new PlacanjeViewModel(navigation)
            {
                knjiga = eknjiga
            };

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            ErrorLabel_CardNumber.IsVisible = false;
            ErrorLabel_Cvv.IsVisible = false;
            ErrorLabel_Month.IsVisible = false;
            ErrorLabel_Year.IsVisible = false;

        }

        private void Number_changed(object sender, TextChangedEventArgs e)
        {
            if (Number.Text.Length > 16)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Broj kartice ne moze imati vise od 16 brojeva";
            }
            else if (Number.Text.Length < 1)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Polje za broj kartice ne moze biti prazno";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;

            }

        }

        private void Number_unfocused(object sender, TextChangedEventArgs e)
        {

            if (Number.Text == null)
            {
                ErrorLabel_CardNumber.IsVisible = true;
                ErrorLabel_CardNumber.Text = "Morate unijeti broj kreditne kartice!";

            }
            else
            {
                ErrorLabel_CardNumber.IsVisible = false;

            }

        }

        private void Month_changed(object sender, TextChangedEventArgs e)
        {
            if (Month.Text.Length > 2)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Mjesec mora imati  cifre (MM)!";
            }
            else if (Number.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Morate unijeti mjesec!";

            }
            else
            {
                ErrorLabel_Month.IsVisible = false;

            }

        }
        private void Month_unfocused(object sender, TextChangedEventArgs e)
        {

            if (Month.Text == null)
            {
                ErrorLabel_Month.IsVisible = true;
                ErrorLabel_Month.Text = "Morate unijeti mjesec!";

            }
            else
            {
                ErrorLabel_Month.IsVisible = false;

            }

        }
        private void Year_changed(object sender, TextChangedEventArgs e)
        {
            if (Year.Text.Length > 2)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Godina mora imati cifre (YY)!";
            }
            else if (Number.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Morate unijeti godinu!";

            }
            else
            {
                ErrorLabel_Year.IsVisible = false;

            }

        }
        private void Year_unfocused(object sender, TextChangedEventArgs e)
        {

            if (Year.Text == null)
            {
                ErrorLabel_Year.IsVisible = true;
                ErrorLabel_Year.Text = "Morate unijeti godinu!";

            }
            else
            {
                ErrorLabel_Year.IsVisible = false;

            }

        }

        private void Cvv_changed(object sender, TextChangedEventArgs e)
        {
            if (Cvv.Text.Length > 3)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Cvv mora sadržavati 3 cifre!";
            }
            else if (Number.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Morate unijeti CVV broj!";

            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;

            }

        }
        private void Cvv_unfocused(object sender, TextChangedEventArgs e)
        {

            if (Cvv.Text == null)
            {
                ErrorLabel_Cvv.IsVisible = true;
                ErrorLabel_Cvv.Text = "Morate unijeti CVV broj!";

            }
            else
            {
                ErrorLabel_Cvv.IsVisible = false;

            }

        }

    }
}
