using eLibrary.Model.Requests.Zanr;
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

namespace eLibrary.WinUI.Forms.Zanrovi
{
    public partial class frmZanrovi : Form
    {
        private readonly APIService _zanrovi = new APIService("Zanr");
        public frmZanrovi()
        {
            InitializeComponent();
            dgvZanrovi.AutoGenerateColumns = false;
        }

        private async void frmZanrovi_Load(object sender, EventArgs e)
        {
            dgvZanrovi.DataSource = await _zanrovi.Get<List<Model.Zanr>>(null);
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new ZanrSearchRequest()
            {
                NazivZanra = txtPretraga.Text
            };

            var result = await _zanrovi.Get<List<Model.Zanr>>(search);
            dgvZanrovi.DataSource = result;
        }

        private async void dgvZanrovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvZanrovi.SelectedRows[0].DataBoundItem as Model.Zanr;
            


            if (e.ColumnIndex == 1)
            {
                
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati žanr  >" + item.NazivZanra + "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await _zanrovi.Delete<Model.Zanr>(item.Zanr_ID);
                    dgvZanrovi.DataSource = await _zanrovi.Get<List<Model.Zanr>>(null);

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (item != null)
                {

                    frmZanroviAdd frm = new frmZanroviAdd(dgvZanrovi, item.Zanr_ID);
                    frm.ShowDialog();

                }
            }
        }

        private void btnDodajZanr_Click(object sender, EventArgs e)
        {
            frmZanroviAdd frm = new frmZanroviAdd(dgvZanrovi);
            frm.Show();
        }
    }
}
