using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using eLibrary.Model;
using System.Windows.Forms;

namespace eLibrary.WinUI.API
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object searchrequest)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            if(searchrequest!=null)
            {
                url += "?";
                url += await searchrequest.ToQueryString();
                
            }
            var result = await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            try
            {

                var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username,Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {

                var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
                var result = await url.WithBasicAuth(Username,Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Update<T>(object id,object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username,Password).PutJsonAsync(request).ReceiveJson<T>();
                return result;

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Delete<T>(object id)
        {
            try
            {
                var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
                var result = await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
                return result;

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
    }
}
