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
using eLibrary.Model.Requests.KorisnikKnjigaKomentar;
using eLibrary.Model;

namespace eLibrary.WinUI.Forms.KorisnikKnjigaKomentar
{
    public partial class frmKorisnikKnjigaKomentar : Form
    {
        
        private readonly APIService _komentari = new APIService("KorisnikKnjigaKomentar");
        private int? _id = null;
        public frmKorisnikKnjigaKomentar(int? id=null)
        {
            InitializeComponent();
            _id = id;
            dgvKomentari.AutoGenerateColumns = false;
        }

        private async void frmKorisnikKnjigaKomentar_Load(object sender, EventArgs e)
        {
            await LoadKomentari();
            
        }

        private async Task LoadKomentari()
        {
            KorisnikKnjigaKomentarSearchRequest model = new KorisnikKnjigaKomentarSearchRequest();
            if (_id != 0)
            {
                model.Knjiga_ID = _id;

            }

            dgvKomentari.DataSource = await _komentari.Get<List<Model.KorisnikKnjigaKomentar>>(model);


        }

        private async void dgvKomentari_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKomentari.SelectedRows[0].DataBoundItem as Model.KorisnikKnjigaKomentar;



            if (e.ColumnIndex == 5)
            {

                DialogResult result = MessageBox.Show("Da li ste sigurni da želite izbrisati komentar  ?", "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    await _komentari.Delete<Model.KorisnikKnjigaKomentar>(item.KorisnikKnjigaKomentar_ID);
                    await LoadKomentari();

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            if (e.ColumnIndex == 6)
            {
                eLibrary.Model.KorisnikKnjigaKomentar komentar = dgvKomentari.SelectedRows[0].DataBoundItem as eLibrary.Model.KorisnikKnjigaKomentar;
                frmPrikazKomentara frm = new frmPrikazKomentara(komentar);
                frm.ShowDialog();
            }
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KorisnikKnjigaKomentarSearchRequest()
            {
                SadrzajKomentara = txtPretraga.Text
            };

            var result = await _komentari.Get<List<Model.KorisnikKnjigaKomentar>>(search);
            dgvKomentari.DataSource = result;
        }
    }
}
