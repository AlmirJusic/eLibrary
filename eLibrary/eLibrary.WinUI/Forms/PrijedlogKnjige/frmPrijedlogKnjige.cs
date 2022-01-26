using eLibrary.Model.Requests.PrijedlogKnjige;
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

namespace eLibrary.WinUI.Forms.PrijedlogKnjige
{
    public partial class frmPrijedlogKnjige : Form
    {
        private readonly APIService _prijedlogKnjige = new APIService("PrijedlogKnjige");

        public frmPrijedlogKnjige()
        {
            InitializeComponent();
            dgvPrijedlogKnjige.AutoGenerateColumns = false;
        }

        private async void frmPrijedlogKnjige_Load(object sender, EventArgs e)
        {
            await LoadPrijedlog();
            
        }

        private async Task LoadPrijedlog()
        {
            dgvPrijedlogKnjige.DataSource = await _prijedlogKnjige.Get<List<Model.PrijedlogKnjige>>(null);
        }

        private async void dgvPrijedlogKnjige_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 4)
            {
                var item = dgvPrijedlogKnjige.SelectedRows[0].DataBoundItem as Model.PrijedlogKnjige;

                var prijedlog = await _prijedlogKnjige.GetById<Model.PrijedlogKnjige>(item.PrijedlogKnjige_ID);

                


                if (prijedlog.Odgovoren == false)
                {
                    prijedlog.Odgovoren = true;
                    prijedlog.Opis = "Vaš prijedlog nove knjige je usvojen!";
                    prijedlog.Pregledan = false;
                    await _prijedlogKnjige.Update<PrijedlogKnjigeInsertRequest>(item.PrijedlogKnjige_ID, prijedlog);

                    MessageBox.Show("Poslana je notifikacija korisniku > "+item.Korisnik.Username+" <!!");

                    await LoadPrijedlog();
                }
            }
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new PrijedlogKnjigeSearchRequest()
            {
                NazivPrijedlogaKnjige = txtPretraga.Text
            };

            var result = await _prijedlogKnjige.Get<List<Model.PrijedlogKnjige>>(search);
            dgvPrijedlogKnjige.DataSource = result;
        }

        private void dgvPrijedlogKnjige_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow item in dgvPrijedlogKnjige.Rows)
            {
                int status = Convert.ToInt32(item.Cells[4].Value);

                if (status == 0)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                    item.DefaultCellStyle.ForeColor = Color.White;

                    
                }
                else
                {
                    item.DefaultCellStyle.BackColor = Color.Green;
                    item.DefaultCellStyle.ForeColor = Color.White;
                    
                }
            }
        }
    }
}
