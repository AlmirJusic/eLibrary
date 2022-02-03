using eLibrary.Model.Requests.Korisnik;
using eLibrary.WinUI.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.WinUI.Forms
{
    public partial class frmLogin : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnik");
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.Text = "admin";
            txtUsername.Text = "admin";
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                try
                {
                    
                    List<Model.Korisnik> listKorisnici = await _korisnici.Get<List<Model.Korisnik>>(new KorisnikSearchRequest() { Username = APIService.Username});
                    APIService.LogiraniKorisnik = listKorisnici.Where(x => x.Username == APIService.Username).FirstOrDefault();

                    if (APIService.LogiraniKorisnik.Uloga.NazivUloge == "Administrator")
                    {
                        await _korisnici.Get<dynamic>(null);

                        frmIndex frm = new frmIndex();
                        DialogResult = DialogResult.OK;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Nemate Pravo Pristupa!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Niste autentificirani!", "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }

            }

        }

        

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            

            return true;
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
