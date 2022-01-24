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
    public partial class frmZanroviAdd : Form
    {
        private readonly APIService _zanrovi = new APIService("Zanr");
        private int? _id = null;
        private DataGridView? _dgvZanrovi = null;
        public frmZanroviAdd(DataGridView? dgvZanrovi = null, int? id = null)
        {
            InitializeComponent();
            _id = id;
            _dgvZanrovi = dgvZanrovi;

        }

        private async void frmZanroviAdd_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var zanr = await _zanrovi.GetById<Model.Zanr>(_id);
                txtNazivZanra.Text = zanr.NazivZanra;

            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if ( Validacija())
            {
                ZanrInsertRequest request = new ZanrInsertRequest()
                {
                    NazivZanra = txtNazivZanra.Text,

                };
                var zanrovi = await _zanrovi.Get<List<Model.Zanr>>(null);
                foreach (var item in zanrovi)
                {
                    if (item.NazivZanra.ToLower() == txtNazivZanra.Text.ToLower())
                    {
                        errorProvider1.SetError(txtNazivZanra, "Žanr već postoji!");
                        return;
                    }
                }


                if (_id.HasValue)
                {
                    await _zanrovi.Update<Model.Zanr>(_id, request);

                }
                else
                {
                    await _zanrovi.Insert<Model.Zanr>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                if (_dgvZanrovi != null)
                    _dgvZanrovi.DataSource = await _zanrovi.Get<List<Model.Zanr>>(null);
            }
        }

        private  bool Validacija()
        {
            
            if (string.IsNullOrEmpty(txtNazivZanra.Text))
            {
                errorProvider1.SetError(txtNazivZanra, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            
            return true;
        }
    }
}
