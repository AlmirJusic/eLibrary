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
    public partial class frmPisciAdd : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _pisci = new APIService("Pisac");
        private int? _id = null;
        private DataGridView? _dgvPisci = null;

        public frmPisciAdd(DataGridView? dgvPisci = null, int? id = null)
        {
            InitializeComponent();
            _id = id;
            _dgvPisci = dgvPisci;
        }

        private async void frmPisciAdd_Load(object sender, EventArgs e)
        {
            await LoadGradovi();
            if(_id.HasValue)
            {
                var pisci = await _pisci.GetById<Model.Pisac>(_id);
                txtIme.Text = pisci.Ime;
                txtPrezime.Text = pisci.Prezime;
                dateTimePicker1.Value = pisci.DatumRodjenja;

                foreach(Model.Grad item in cmbGrad.Items)
                {
                    if (item.Grad_ID == pisci.Grad_ID)
                        cmbGrad.SelectedItem = item;
                }
            }
        }

        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbGrad.DataSource = result;
            cmbGrad.DisplayMember = "NazivGrada";
            cmbGrad.ValueMember = "Grad_ID";
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                PisacInsertRequest request = new PisacInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),

                    Grad_ID = (cmbGrad.SelectedItem as Model.Grad).Grad_ID,

                };
                var pisci = await _pisci.Get<List<Model.Pisac>>(null);
                foreach (var item in pisci)
                {
                    if (item.Ime.ToLower() == txtIme.Text.ToLower()&&item.Prezime.ToLower()==txtPrezime.Text.ToLower())
                    {
                        errorProvider1.SetError(txtIme, "Pisac već postoji!");
                        errorProvider1.SetError(txtPrezime, "Pisac već postoji!");
                        return;
                    }
                }


                if (_id.HasValue)
                {
                    await _pisci.Update<Model.Pisac>(_id, request);
                }
                else
                {
                    await _pisci.Insert<Model.Pisac>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                if (_dgvPisci != null)
                    _dgvPisci.DataSource = await _pisci.Get<List<Model.Pisac>>(null);
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            if (string.IsNullOrEmpty(cmbGrad.Text))
            {
                errorProvider1.SetError(cmbGrad, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            return true;
        }
    }
}
