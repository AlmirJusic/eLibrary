using eLibrary.Mob.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eLibrary.Mob.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}