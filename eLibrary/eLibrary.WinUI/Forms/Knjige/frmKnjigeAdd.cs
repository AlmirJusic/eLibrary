using eLibrary.Model.Requests.Knjiga;

using eLibrary.WinUI.API;
using eLibrary.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.WinUI.Forms.Knjige
{
    public partial class frmKnjigeAdd : Form
    {
        
        private readonly APIService _zanrovi = new APIService("Zanr");
        private readonly APIService _pisci = new APIService("Pisac");
        private readonly APIService _knjige = new APIService("Knjiga");
        private int? _id = null;
        private DataGridView? _dgvKnjige = null;
        public frmKnjigeAdd(DataGridView? dgvKnjige=null, int? id=null)
        {
            InitializeComponent();
            _id = id;
            _dgvKnjige = dgvKnjige;
        }

        private async void frmKnjigeAdd_Load(object sender, EventArgs e)
        {
            await LoadPisci();
            await LoadZanrovi();
            if (_id.HasValue) //update
            {
                var knjiga = await _knjige.GetById<Model.Knjiga>(_id);
                txtNazivKnjige.Text = knjiga.NazivKnjige;
                txtCijena.Text = knjiga.Cijena.ToString();
                txtOcjena.Text = knjiga.Ocjena.ToString();
                txtOpis.Text = knjiga.Opis;
                dateTimePicker1.Value = knjiga.DatumIzdavanja;
                cbPDF.Checked = knjiga.PDFDodan;

                if (knjiga.Slika.Length > 0)
                {
                    pbSlika.Image = ImageHelper.FromByteToImage(knjiga.Slika);
                }

                foreach (Model.Pisac item in cmbPisac.Items)
                {
                    if (item.Pisac_ID == knjiga.Pisac_ID)
                        cmbPisac.SelectedItem = item;
                }
                foreach (Model.Zanr item in cmbZanr.Items)
                {
                    if (item.Zanr_ID == knjiga.Zanr_ID)
                        cmbZanr.SelectedItem = item;
                }
                

            }
        }

        private async Task LoadZanrovi()
        {
            var result = await _zanrovi.Get<List<Model.Zanr>>(null);
            result.Insert(0, new Model.Zanr());
            cmbZanr.DataSource = result;
            cmbZanr.DisplayMember = "NazivZanra";
            cmbZanr.ValueMember = "Zanr_ID";
        }

        private async Task LoadPisci()
        {
            var result = await _pisci.Get<List<Model.Pisac>>(null);
            result.Insert(0, new Model.Pisac());
            cmbPisac.DataSource = result;
            cmbPisac.DisplayMember = "ImePrezime";
            cmbPisac.ValueMember = "Pisac_ID";
        }



        private void btnSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                string putanjaDoSlike = ofdSlika.FileName;
                Image slika = Image.FromFile(putanjaDoSlike);
                pbSlika.Image = slika;

            }
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                string putanjaDoSlike = ofdSlika.FileName;
                Image slika = Image.FromFile(putanjaDoSlike);
                pbSlika.Image = slika;

            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (await Validacija())
            {
                KnjigaInsertRequest request = new KnjigaInsertRequest()
                {
                    NazivKnjige = txtNazivKnjige.Text,
                    Cijena = Double.Parse(txtCijena.Text),
                    Ocjena = Double.Parse(txtOcjena.Text),
                    Opis = txtOpis.Text,
                    DatumIzdavanja = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),
                    PDFDodan = cbPDF.Checked,
                 

                    Pisac_ID = (cmbPisac.SelectedItem as Model.Pisac).Pisac_ID,
                    Zanr_ID = (cmbZanr.SelectedItem as Model.Zanr).Zanr_ID,

                };



                if (_id.HasValue)
                {

                    if (pbSlika.Image != null)
                        request.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    await _knjige.Update<Model.Knjiga>(_id, request);

                }
                else
                {
                    if (cbPDF.Checked == true)
                        request.PDFDodan = true;

                    if (pbSlika.Image != null)
                        request.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    else
                        request.Slika = ImageHelper.FromImageToByte(eLibrary.WinUI.Properties.Resources.user);
                    await _knjige.Insert<Model.Knjiga>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                if (_dgvKnjige != null)
                    _dgvKnjige.DataSource = await _knjige.Get<List<Model.Knjiga>>(null);
            }
        }

        private async Task <bool> Validacija()
        {
            if (string.IsNullOrEmpty(txtNazivKnjige.Text))
            {
                errorProvider1.SetError(txtNazivKnjige, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            
            if (string.IsNullOrEmpty(cmbZanr.Text))
            {
                errorProvider1.SetError(cmbZanr, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (cmbPisac.SelectedIndex <= 0)
            {
                errorProvider1.SetError(cmbPisac, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtOpis.Text))
            {
                errorProvider1.SetError(txtOpis, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            
            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            double dbl ;
            if (double.TryParse(txtCijena.Text, out dbl))
            {
                double.Parse(txtCijena.Text);
            }
            else
            {
                errorProvider1.SetError(txtCijena, "Morate unijeti broj!");
                return false;
            }
            if (double.TryParse(txtOcjena.Text, out dbl))
            {
                double.Parse(txtOcjena.Text);
            }
            else
            {
                errorProvider1.SetError(txtOcjena, "Morate unijeti broj!");
                return false;
            }

            var result = await _knjige.Get<List<Model.Knjiga>>(null);
            int id = _id ?? 0;

            foreach (var item in result)
            {
                
                if(item.NazivKnjige==txtNazivKnjige.Text&&item.Pisac_ID== (cmbPisac.SelectedItem as Model.Pisac).Pisac_ID&&item.Knjiga_ID!=id)
                {
                    errorProvider1.SetError(txtNazivKnjige, "Knjiga sa ovim nazivom i piscem već postoji!");
                    
                    return false;
                }
                
            }

            return true;
        }
    }
}
