using eLibrary.Model;
using eLibrary.Model.Requests.Korisnik;
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

namespace eLibrary.WinUI.Forms.Korisnici
{
    public partial class frmKorisniciAdd : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _spolovi = new APIService("Spol");
        private readonly APIService _uloge = new APIService("Uloga");
        private readonly APIService _korisnici = new APIService("Korisnik");
        private int? _id = null;

        public frmKorisniciAdd(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnGrad_Click(object sender, EventArgs e)
        {

        }

        private async void frmKorisniciAdd_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            await LoadGradovi();
            await LoadSpolovi();
            await LoadUloge();
        }

        private async Task LoadUloge()
        {
            var result = await _uloge.Get<List<Model.Uloga>>(null);
            result.Insert(0, new Model.Uloga());
            cmbUloga.DataSource = result;
            cmbUloga.DisplayMember = "NazivUloge";
            cmbUloga.ValueMember = "Uloga_ID";
        }

        private async Task LoadSpolovi()
        {
            var result = await _spolovi.Get<List<Model.Spol>>(null);
            result.Insert(0, new Model.Spol());
            cmbSpol.DataSource = result;
            cmbSpol.DisplayMember = "OznakaSpola";
            cmbSpol.ValueMember = "Spol_ID";
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
            var request = new KorisnikInsertRequest
            {
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                Email=txtEmail.Text,
                DatumRodjenja=dateTimePicker1.Value,
                Username=txtUsername.Text,
                Password=txtLozinka.Text,
                PasswordConfirm=txtLozinkaPotvrda.Text,
                //Grad=cmbGrad.SelectedItem as Grad
                
                
            };
            if(!_id.HasValue)
            {
                await _korisnici.Insert<Model.Korisnik>(request);
            }
            else
            {
                await _korisnici.Update<Model.Korisnik>(_id, request);
            }
        }
    }
}
