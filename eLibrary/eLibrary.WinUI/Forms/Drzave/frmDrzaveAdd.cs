using eLibrary.Model.Requests.Drzava;
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

namespace eLibrary.WinUI.Forms.Drzave
{
    public partial class frmDrzaveAdd : Form
    {
        private readonly APIService _drzave = new APIService("Drzava");
        private int? _id = null;
        private DataGridView? _dgvDrzave=null;
        

        public frmDrzaveAdd(DataGridView? dgvDrzave=null,int? id = null)
        {
            InitializeComponent();
            _id = id;
            _dgvDrzave = dgvDrzave;
        }

        

        private async void frmDrzaveAdd_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var drzava = await _drzave.GetById<Model.Drzava>(_id);
                txtNazivDrzave.Text = drzava.NazivDrzave;

            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if ( Validacija())
            {
                DrzavaInsertRequest request = new DrzavaInsertRequest()
                {
                    NazivDrzave = txtNazivDrzave.Text,

                };
                var drzave= await _drzave.Get<List<Model.Drzava>>(null);
                foreach (var i in drzave)
                {
                    if(i.NazivDrzave.ToLower()==txtNazivDrzave.Text.ToLower())
                    {
                        errorProvider1.SetError(txtNazivDrzave, "Država već postoji!");
                        return;
                    }
                }


                if (_id.HasValue)
                {
                    await _drzave.Update<Model.Drzava>(_id, request);

                }
                else
                {
                    await _drzave.Insert<Model.Drzava>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                _dgvDrzave.DataSource = await _drzave.Get<List<Model.Drzava>>(null);
            }
        }
        
        private bool Validacija()
        {
            if (string.IsNullOrEmpty(txtNazivDrzave.Text))
            {
                errorProvider1.SetError(txtNazivDrzave, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            
           

            return true;
        }
    }
}
