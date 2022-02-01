using eLibrary.Mob.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace eLibrary.Mob.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string _username = string.Empty;
        public string Username{get { return _username; }set { SetProperty(ref _username, value); }}

        string _password = string.Empty;
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }


        //public Command LoginCommand { get; }

        //public LoginViewModel()
        //{
        //    LoginCommand = new Command(OnLoginClicked);
        //}

        //private async void OnLoginClicked(object obj)
        //{
        //    // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
        //    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        //}
    }
}
