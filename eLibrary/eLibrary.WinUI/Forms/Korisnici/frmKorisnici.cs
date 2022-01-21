using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eLibrary.WinUI.API;
using eLibrary.Model.Requests.Korisnik;

namespace eLibrary.WinUI.Forms.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService=new APIService("Korisnik");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var searchrequest = new KorisnikSearchRequest()
            {
                Ime = txtPretraga.Text,
                Username=txtUsername.Text,
                Prezime=txtPrezime.Text
                
            };

            var result = await _apiService.Get<List<Model.Korisnik>>(searchrequest);
            dgvKorisnici.DataSource = result;
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            dgvKorisnici.DataSource = await _apiService.Get<List<Model.Korisnik>>(null);
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var searchrequest = new KorisnikSearchRequest()
            {
                Ime = txtPretraga.Text

            };

            var result = await _apiService.Get<List<Model.Korisnik>>(searchrequest);
            dgvKorisnici.DataSource = result;
        }

        private async void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            var searchrequest = new KorisnikSearchRequest()
            {
                Prezime = txtPrezime.Text

            };

            var result = await _apiService.Get<List<Model.Korisnik>>(searchrequest);
            dgvKorisnici.DataSource = result;
        }

        private async void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var searchrequest = new KorisnikSearchRequest()
            {
                Username = txtUsername.Text

            };

            var result = await _apiService.Get<List<Model.Korisnik>>(searchrequest);
            dgvKorisnici.DataSource = result;
        }
    }
}
