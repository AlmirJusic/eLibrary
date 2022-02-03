using eLibrary.Mob.UWP;
using eLibrary.Mob.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(PDFRender))]
namespace eLibrary.Mob.UWP
{
    public class PDFRender : IPDFService
    {


        public async void PdfFile(string fileName)

        {
            

            StorageFolder AssetsFolder = await Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            StorageFile file = await AssetsFolder.GetFileAsync(fileName);
            await Windows.System.Launcher.LaunchFileAsync(file);

        }


    }
}

