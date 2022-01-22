using eLibrary.Model.Requests.Grad;
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

namespace eLibrary.WinUI.Forms.Gradovi
{
    public partial class frmGradovi : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnik");
        private readonly APIService _pisci = new APIService("Pisac");
        private readonly APIService _gradovi = new APIService("Grad");

        public frmGradovi()
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
        }

        private async void frmGradovi_Load(object sender, EventArgs e)
        {

            dgvGradovi.DataSource = await _gradovi.Get<List<Model.Grad>>(null);
        }

       

        private async void txtNazivGrada_TextChanged(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                NazivGrada = txtNazivGrada.Text
            };

            var result = await _gradovi.Get<List<Model.Grad>>(search);
            dgvGradovi.DataSource = result;
        }

        private async void txtNazivDrzave_TextChanged(object sender, EventArgs e)
        {
            var search = new GradSearchRequest()
            {
                NazivDrzave = txtNazivDrzave.Text
            };

            var result = await _gradovi.Get<List<Model.Grad>>(search);
            dgvGradovi.DataSource = result;
        }

        private void BtnDodajGrad_Click(object sender, EventArgs e)
        {
            frmGradoviAdd frm = new frmGradoviAdd(dgvGradovi);
            frm.Show();
            
        }

        private async void dgvGradovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvGradovi.SelectedRows[0].DataBoundItem as Model.Grad;

            var korisnici = await _korisnici.Get<List<Model.Korisnik>>(null);
            var pisci = await _pisci.Get<List<Model.Pisac>>(null);


            if (e.ColumnIndex == 2)
            {
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
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati grad  >" + item.NazivGrada + "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await _gradovi.Delete<Model.Grad>(item.Grad_ID);
                    dgvGradovi.DataSource = await _gradovi.Get<List<Model.Grad>>(null);


                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 3)
            {
                if (item != null)
                {

                    frmGradoviAdd frm = new frmGradoviAdd(dgvGradovi, item.Grad_ID);
                    frm.ShowDialog();
                    
                }
            }
        }
    }
}

