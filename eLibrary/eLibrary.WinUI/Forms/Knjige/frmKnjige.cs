using eLibrary.Model.Requests.Knjiga;
using eLibrary.WinUI.API;
using eLibrary.WinUI.Forms.KorisnikKnjigaKomentar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.WinUI.Forms.Knjige
{
    public partial class frmKnjige : Form
    {
        private readonly APIService _zanrovi = new APIService("Zanr");
        private readonly APIService _knjige = new APIService("Knjiga");
        
        public frmKnjige()
        {
            InitializeComponent();
            dgvKnjige.AutoGenerateColumns = false;
        }

        private async void frmKnjige_Load(object sender, EventArgs e)
        {
            await LoadKnjige();
            await LoadZanrovi();
            dgvKnjige.DataSource = await _knjige.Get<List<Model.Knjiga>>(null);

           
        }

        private async Task LoadZanrovi()
        {
            var result = await _zanrovi.Get<List<Model.Zanr>>(null);
            result.Insert(0, new Model.Zanr());
            cmbZanr.DataSource = result;
            cmbZanr.DisplayMember = "NazivZanra";
            cmbZanr.ValueMember = "Zanr_ID";
        }

        private async Task LoadKnjige(int zanrID=0)
        {
            KnjigaSearchRequest model = new KnjigaSearchRequest();
            if (zanrID != 0)
            {
                model.Zanr_ID = zanrID;

            }

            dgvKnjige.DataSource = await _knjige.Get<List<Model.Knjiga>>(model);
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KnjigaSearchRequest()
            {
                NazivKnjige = txtPretraga.Text
            };

            var result = await _knjige.Get<List<Model.Knjiga>>(search);
            dgvKnjige.DataSource = result;
        }

        private async void dgvKnjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKnjige.SelectedRows[0].DataBoundItem as Model.Knjiga;

            if (e.ColumnIndex == 6)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati knjigu  >" + item.NazivKnjige + "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await _knjige.Delete<Model.Knjiga>(item.Knjiga_ID);
                    dgvKnjige.DataSource = await _knjige.Get<List<Model.Knjiga>>(null);
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 7)
            {
                if (item != null)
                {
                    frmKnjigeAdd frm = new frmKnjigeAdd(dgvKnjige, item.Knjiga_ID);
                    frm.ShowDialog();
                }
            }
            if(e.ColumnIndex==8)
            {
                frmKorisnikKnjigaKomentar frm = new frmKorisnikKnjigaKomentar(item.Knjiga_ID);
                frm.Show();
            }
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            frmKnjigeAdd frm = new frmKnjigeAdd(dgvKnjige);
            frm.Show();
        }

        private async void txtPisacPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KnjigaSearchRequest()
            {
                Pisac = txtPisacPretraga.Text
            };

            var result = await _knjige.Get<List<Model.Knjiga>>(search);
            dgvKnjige.DataSource = result;
        }

        private async void cmbZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int zanrID = (cmbZanr.SelectedItem as Model.Zanr).Zanr_ID;

            await LoadKnjige(zanrID);
        }
    }
}
