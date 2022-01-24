using eLibrary.Model.Requests.Pisac;
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

namespace eLibrary.WinUI.Forms.Pisci
{
    public partial class frmPisci : Form
    {
        private readonly APIService _pisci = new APIService("Pisac");
        public frmPisci()
        {
            InitializeComponent();
            dgvPisci.AutoGenerateColumns = false;
        }

        private async void frmPisci_Load(object sender, EventArgs e)
        {
            dgvPisci.DataSource = await _pisci.Get<List<Model.Pisac>>(null);
        }

        private async void txtIme_TextChanged(object sender, EventArgs e)
        {
            var search = new PisacSearchRequest()
            {
                Ime = txtIme.Text
            };

            var result = await _pisci.Get<List<Model.Pisac>>(search);
            dgvPisci.DataSource = result;
        }

        private async void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            var search = new PisacSearchRequest()
            {
                Prezime = txtPrezime.Text
            };

            var result = await _pisci.Get<List<Model.Pisac>>(search);
            dgvPisci.DataSource = result;
        }

        private async void dgvPisci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPisci.SelectedRows[0].DataBoundItem as Model.Pisac;

            if(e.ColumnIndex==4)
            {
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati korisnika  >" + item.Ime + " " + item.Prezime + "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    await _pisci.Delete<Model.Pisac>(item.Pisac_ID);
                    dgvPisci.DataSource = await _pisci.Get<List<Model.Pisac>>(null);
                }
                else if(result==DialogResult.No)
                {
                    return;
                }
            }
            if(e.ColumnIndex==5)
            {
                if(item!=null)
                {
                    frmPisciAdd frm = new frmPisciAdd(dgvPisci, item.Pisac_ID);
                    frm.ShowDialog();
                }
            }
        }

        private void BtnDodajPisca_Click(object sender, EventArgs e)
        {
            frmPisciAdd frm = new frmPisciAdd(dgvPisci);
            frm.Show();
        }
    }
}
