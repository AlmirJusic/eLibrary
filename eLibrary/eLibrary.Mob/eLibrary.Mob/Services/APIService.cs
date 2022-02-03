
using eLibrary.Mob.Views;
using eLibrary.ModelForMobile;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eLibrary.Mob.Services
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static Korisnik LogiraniKorisnik { get; set; }
        private string _route = null;

#if DEBUG

        string _apiURL = "http://localhost:7276/api";
#endif
#if RELEASE

          string _apiURL = "https://website.com/api";
#endif

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object searchrequest)
        {
            var url = $"{_apiURL}/{_route}";

            try
            {
                if (searchrequest != null)
                {
                    url += "?";
                    url += await searchrequest.ToQueryString();
                
                }
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Neuspješna autentifikacija.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješna autentifikacija.", "OK");
                    Application.Current.MainPage = new LoginPage();
                    return default;
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    //MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate permisije za pristup ovom resursu.", "OK");
                    return default;
                }
                throw;
            }

        }
        public async Task<T> GetById<T>(object id)
        {
            try
            {

                var url = $"{_apiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Neuspješna autentifikacija.");
                    await Application.Current.MainPage.DisplayAlert("Greška","Neuspješna autentifikacija.","OK");
                    Application.Current.MainPage = new LoginPage();
                    return default;
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    //MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate permisije za pristup ovom resursu.", "OK");
                    return default;
                }
                throw;
            }
        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {

                var url = $"{_apiURL}/{_route}";
                var result = await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Neuspješna autentifikacija.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješna autentifikacija.", "OK");
                    Application.Current.MainPage = new LoginPage();
                    return default;
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    //MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate permisije za pristup ovom resursu.", "OK");
                    return default;
                }
                throw;
            }
        }
        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{_apiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
                return result;

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Neuspješna autentifikacija.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješna autentifikacija.", "OK");
                    Application.Current.MainPage = new LoginPage();
                    return default;
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    //MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate permisije za pristup ovom resursu.", "OK");
                    return default;
                }
                throw;
            }
        }
        public async Task<T> Delete<T>(object id)
        {
            try
            {
                var url = $"{_apiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
                return result;

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    //MessageBox.Show("Neuspješna autentifikacija.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Neuspješna autentifikacija.", "OK");
                    Application.Current.MainPage = new LoginPage();
                    return default;
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    //MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate permisije za pristup ovom resursu.", "OK");
                    return default;
                }
                throw;
            }
        }
    }
}
