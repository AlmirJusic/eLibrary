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
        private readonly APIService _korisnici=new APIService("Korisnik");
        private readonly APIService _uloge = new APIService("Uloga");
        public frmKorisnici()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
            await LoadUloge();
            
            
        }

        private async Task LoadKorisnici(int ulogaID=0)
        {
            KorisnikSearchRequest model = new KorisnikSearchRequest();
            if(ulogaID!=0)
            {
                model.Uloga_ID = ulogaID;
               
            }

            dgvKorisnici.DataSource = await _korisnici.Get<List<Model.Korisnik>>(model);
        }

        private async Task LoadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloga>>(null);
            result.Insert(0, new Model.Uloga());
            cmbSortUloga.DataSource = result;
            cmbSortUloga.DisplayMember = "NazivUloge";
            cmbSortUloga.ValueMember = "Uloga_ID";
        }
    

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KorisnikSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var result = await _korisnici.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.DataSource = result;
        }

        private async void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            var search = new KorisnikSearchRequest()
            {
                Prezime = txtPrezime.Text
            };

            var result = await _korisnici.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.DataSource = result;
        }

        private async void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var search = new KorisnikSearchRequest()
            {
                Username = txtUsername.Text
            };

            var result = await _korisnici.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.DataSource = result;
        }

        private async void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem as Model.Korisnik;

            //var korisnici = await _korisnici.Get<List<Model.Korisnik>>(null);
            //var pisci = await _pisci.Get<List<Model.Pisac>>(null);


            if (e.ColumnIndex == 8)
            {
                /*
                foreach (var i in korisnici)
                {
                    if (i.Grad_ID == item.Grad_ID)
                    {
                        MessageBox.Show("Nije moguće izbrisati grad zbog konzistentnosti podataka!!!");
                        return;
                    }
                }
                foreach (var i in pisci)
                {
                    if (i.Grad_ID == item.Grad_ID)
                    {
                        MessageBox.Show("Nije moguće izbrisati grad zbog konzistentnosti podataka!!!");
                        return;
                    }
                }
                */
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika  >" + item.Ime +" "+item.Prezime+ "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await _korisnici.Delete<Model.Korisnik>(item.Korisnik_ID);
                    dgvKorisnici.DataSource = await _korisnici.Get<List<Model.Korisnik>>(null);


                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 9)
            {
                if (item != null)
                {

                    frmKorisniciAdd frm = new frmKorisniciAdd(dgvKorisnici, item.Korisnik_ID);
                    frm.ShowDialog();

                }
            }
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            frmKorisniciAdd frm = new frmKorisniciAdd(dgvKorisnici);
            frm.Show();
        }

        private async void cmbSortUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var idObj = cmbSortUloga.SelectedValue;

            //if (int.TryParse(idObj?.ToString(), out int id))
            //{
            //    await LoadKorisnici(id);
            //}
            int ulogaID = (cmbSortUloga.SelectedItem as Model.Uloga).Uloga_ID;
            
            await LoadKorisnici(ulogaID);
            

                
        }

        
    }
}
