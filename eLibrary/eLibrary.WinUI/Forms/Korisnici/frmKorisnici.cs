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
using eLibrary.Model;

namespace eLibrary.WinUI.Forms.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _korisnici=new APIService("Korisnik");
        private readonly APIService _uloge = new APIService("Uloga");
        private readonly APIService _kupovine = new APIService("KupovinaKnjige");
        private readonly APIService _prijedlozi = new APIService("PrijedlogKnjige");
        private readonly APIService _komentari = new APIService("KorisnikKnjigaKomentar");
        private readonly APIService _ocjene = new APIService("KorisnikKnjigaOcjena");
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

            


            if (e.ColumnIndex == 8)
            {
                
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika  >" + item.Ime +" "+item.Prezime+ "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var prijedlog = await _prijedlozi.Get<List<eLibrary.Model.PrijedlogKnjige>>(null);
                    var ocjena = await _ocjene.Get<List<eLibrary.Model.KorisnikKnjigaOcjena>>(null);
                    var kupovina = await _kupovine.Get<List<KupovinaKnjige>>(null);
                    var komentar = await _komentari.Get<List<eLibrary.Model.KorisnikKnjigaKomentar>>(null);
                    

                    if (kupovina != null)
                    {
                        foreach (var i in kupovina)
                        {
                            if (i.Korisnik_ID ==item.Korisnik_ID )
                            {
                                await _kupovine.Delete<Model.KupovinaKnjige>(i.KupovinaKnjige_ID);
                            }
                        }
                    }
                    if (komentar != null)
                    {
                        foreach (var i in komentar)
                        {
                            if (i.Korisnik_ID == item.Korisnik_ID)
                            {
                                await _komentari.Delete<Model.KorisnikKnjigaKomentar>(i.KorisnikKnjigaKomentar_ID);
                            }
                        }
                    }if (ocjena != null)
                    {
                        foreach (var i in ocjena)
                        {
                            if (i.Korisnik_ID == item.Korisnik_ID)
                            {
                                await _ocjene.Delete<Model.KorisnikKnjigaOcjena>(i.KorisnikKnjigaOcjena_ID);
                            }
                        }
                    }
                    if (prijedlog != null)
                    {
                        foreach (var i in prijedlog)
                        {
                            if (i.Korisnik_ID == item.Korisnik_ID)
                            {
                                await _prijedlozi.Delete<Model.PrijedlogKnjige>(i.PrijedlogKnjige_ID);
                            }
                        }
                    }
                    
                    await _korisnici.Delete<Model.Korisnik>(item.Korisnik_ID);
                    //dgvKorisnici.DataSource = await _korisnici.Get<List<Model.Korisnik>>(null);
                    await LoadKorisnici();

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
