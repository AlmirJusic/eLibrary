using eLibrary.Model.Requests.Grad;
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

namespace eLibrary.WinUI.Forms.Gradovi
{
    public partial class frmGradoviAdd : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _drzave = new APIService("Drzava");
        private int? _id = null;
        private DataGridView? _dgvGradovi = null;


        public frmGradoviAdd(DataGridView? dgvGradovi = null, int? id = null)
        {
            InitializeComponent();
            _id = id;
            _dgvGradovi = dgvGradovi;


        }

        private async void frmGradoviAdd_Load(object sender, EventArgs e)
        {
            await LoadDrzave();
            if (_id.HasValue) //update
            {
                var grad = await _gradovi.GetById<Model.Grad>(_id);
                txtNazivGrada.Text = grad.NazivGrada;

                foreach (Model.Drzava item in cmbDrzava.Items)
                {
                    if (item.Drzava_ID == grad.Drzava_ID)
                        cmbDrzava.SelectedItem = item;

                }

            }
        }

        private async Task LoadDrzave()
        {
            var result = await _drzave.Get<List<Model.Drzava>>(null);
            result.Insert(0, new Model.Drzava());
            cmbDrzava.DisplayMember = "NazivDrzave";
            cmbDrzava.ValueMember = "Drzava_ID";
            cmbDrzava.DataSource = result;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {

                //int drzavaID = int.Parse(cmbDrzava.SelectedValue.ToString());
                int drzavaID = (cmbDrzava.SelectedItem as Model.Drzava).Drzava_ID;
                GradInsertRequest request = new GradInsertRequest()
                {
                    NazivGrada = txtNazivGrada.Text,
                    Drzava_ID = (cmbDrzava.SelectedItem as Model.Drzava).Drzava_ID

                };
                var gradovi = await _gradovi.Get<List<Model.Grad>>(null);
                foreach (var i in gradovi)
                {
                    if (i.NazivGrada.ToLower() == txtNazivGrada.Text.ToLower() && i.Drzava_ID==drzavaID)
                    {
                        errorProvider1.SetError(txtNazivGrada, "Grad već postoji u državi > "+i.Drzava.NazivDrzave+" <!");
                        return;
                    }
                }


                if (_id.HasValue)
                {
                    await _gradovi.Update<Model.Grad>(_id, request);

                }
                else
                {
                    await _gradovi.Insert<Model.Grad>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                if(_dgvGradovi!=null)
                    _dgvGradovi.DataSource = await _gradovi.Get<List<Model.Grad>>(null);
            }
        }

        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtNazivGrada.Text))
            {
                errorProvider1.SetError(txtNazivGrada, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            if (string.IsNullOrEmpty(cmbDrzava.Text))
            {
                errorProvider1.SetError(cmbDrzava, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();


            return true;
        }

        
    }
}
