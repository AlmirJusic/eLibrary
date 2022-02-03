using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eLibrary.Mob.Views
{
    public interface IPDFService
    {
        void PdfFile(string fileName);

    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFPage : ContentPage
    {
        private string _file;
        public PDFPage(string file)
        {
            InitializeComponent();
            _file = file;
        }

       

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IPDFService>().PdfFile(_file);
          
        }
    }

}