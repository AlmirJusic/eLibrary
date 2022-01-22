using eLibrary.Model.Requests.Drzava;
using eLibrary.WinUI.API;
using eLibrary.WinUI.Forms.Drzave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.WinUI.Forms.Drzava
{
    public partial class frmDrzave : Form
    {
        private readonly APIService _drzave = new APIService("Drzava");
        private readonly APIService _gradovi = new APIService("Grad");
        
        public frmDrzave()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
        }

        private async void frmDrzave_Load(object sender, EventArgs e)
        {
            dgvDrzave.DataSource = await _drzave.Get<List<Model.Drzava>>(null);
        }


        private async void dgvDrzave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var item = dgvDrzave.SelectedRows[0].DataBoundItem as Model.Drzava;
            var gradovi= await _gradovi.Get<List<Model.Grad>>(null);


            if (e.ColumnIndex == 1)
            {
                foreach (var i in gradovi)
                {
                    if(i.Drzava_ID==item.Drzava_ID)
                    {
                        MessageBox.Show("Nije moguće izbrisati državu zbog konzistentnosti podataka!!!");
                        return;
                    }
                }
                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati državu  >" + item.NazivDrzave + "< ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    await _drzave.Delete<Model.Drzava>(item.Drzava_ID);
                    dgvDrzave.DataSource = await _drzave.Get<List<Model.Drzava>>(null);

                }
                else if(result==DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 2)
            {
                if (item != null)
                {

                    frmDrzaveAdd frm = new frmDrzaveAdd(dgvDrzave,item.Drzava_ID);
                    frm.ShowDialog();
                    
                }
            }


        }

        private void btnDodajDrzavu_Click(object sender, EventArgs e)
        {
            frmDrzaveAdd frm = new frmDrzaveAdd(dgvDrzave);
            frm.Show();
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new DrzavaSearchRequest()
            {
                NazivDrzave = txtPretraga.Text
            };

            var result = await _drzave.Get<List<Model.Drzava>>(search);
            dgvDrzave.DataSource = result;
        }
    }
}
