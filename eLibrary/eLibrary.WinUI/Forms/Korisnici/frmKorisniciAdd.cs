using eLibrary.Model;
using eLibrary.Model.Requests.Korisnik;
using eLibrary.WinUI.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using eLibrary.WinUI.Helper;

namespace eLibrary.WinUI.Forms.Korisnici
{
    public partial class frmKorisniciAdd : Form
    {
        private readonly APIService _gradovi = new APIService("Grad");
        private readonly APIService _spolovi = new APIService("Spol");
        private readonly APIService _uloge = new APIService("Uloga");
        private readonly APIService _korisnici = new APIService("Korisnik");
        private int? _id = null;
        private DataGridView? _dgvKorisnici = null;

        public frmKorisniciAdd(DataGridView? dgvKorisnici = null, int? id = null)
        {
            InitializeComponent();
            _id = id;
            _dgvKorisnici = dgvKorisnici;
           
        }

        

        private async void frmKorisniciAdd_Load(object sender, EventArgs e)
        {
            await LoadData();
            if (_id.HasValue) //update
            {
                var korisnici = await _korisnici.GetById<Model.Korisnik>(_id);
                txtIme.Text = korisnici.Ime;
                txtPrezime.Text = korisnici.Prezime;
                txtUsername.Text = korisnici.Username;
                txtEmail.Text = korisnici.Email;
                dateTimePicker1.Value = korisnici.DatumRodjenja;

                if (korisnici.Slika.Length > 0)
                {
                    pbSlika.Image = ImageHelper.FromByteToImage(korisnici.Slika);
                }


                
                
                    

                txtPassword.Hide();
                txtConfirmPassword.Hide();
                lblPassword.Hide();
                lblConfirmPassword.Hide();
                

                foreach (Model.Grad item in cmbGrad.Items)
                {
                    if (item.Grad_ID == korisnici.Grad_ID)
                        cmbGrad.SelectedItem = item;
                }
                foreach(Model.Spol item in cmbSpol.Items)
                {
                    if (item.Spol_ID == korisnici.Spol_ID)
                        cmbSpol.SelectedItem = item;
                }
                foreach (Model.Uloga item in cmbUloga.Items)
                {
                    if (item.Uloga_ID == korisnici.Uloga_ID)
                        cmbUloga.SelectedItem = item;
                }

            }
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

            if (await Validacija())
            {
                
                KorisnikInsertRequest request = new KorisnikInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    PasswordConfirm = txtConfirmPassword.Text,
                    DatumRodjenja = DateTime.Parse(dateTimePicker1.Value.ToShortDateString()),
                    

                    Grad_ID = (cmbGrad.SelectedItem as Model.Grad).Grad_ID,
                    Spol_ID = (cmbSpol.SelectedItem as Model.Spol).Spol_ID,
                    Uloga_ID = (cmbUloga.SelectedItem as Model.Uloga).Uloga_ID

                };

                

                if (_id.HasValue)
                {

                    if (pbSlika.Image != null)
                        request.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    await _korisnici.Update<Model.Korisnik>(_id, request);

                }
                else
                {
                    if (pbSlika.Image != null)
                        request.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    else
                        request.Slika = ImageHelper.FromImageToByte(eLibrary.WinUI.Properties.Resources.user);
                    await _korisnici.Insert<Model.Korisnik>(request);
                }
                MessageBox.Show("Operacija uspješna!");
                this.Close();
                if (_dgvKorisnici != null)
                    _dgvKorisnici.DataSource = await _korisnici.Get<List<Model.Korisnik>>(null);

            }
        }

        private async Task <bool> Validacija()
        { 
            var result = await _korisnici.Get<List<Model.Korisnik>>(null);
            int id = _id ?? 0;

            

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
            if (string.IsNullOrEmpty(cmbSpol.Text))
            {
                errorProvider1.SetError(cmbSpol, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();
            if (string.IsNullOrEmpty(cmbUloga.Text))
            {
                errorProvider1.SetError(cmbUloga, "Obavezno polje!");
                return false;
            }
            else errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Obavezno polje!");
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                errorProvider1.SetError(txtEmail, "Pogrešan format email-a");
                return false;
            }
            else
            {
                foreach (var item in result)
                    if (item.Email == txtEmail.Text && item.Korisnik_ID != id)
                    {
                        errorProvider1.SetError(txtEmail, "Email je već registrovan u bazi, pokusajte drugi email!");
                        return false;
                    }
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Obavezno polje!");
                return false;
            }
            else
            {
                foreach (var item in result)
                    if (item.Username == txtUsername.Text && item.Korisnik_ID != id)
                    {
                        errorProvider1.SetError(txtUsername, "Username je zauzet!");
                        return false;
                    }
            }
            
            
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                if (_id.HasValue)
                {
                    errorProvider1.SetError(txtPassword, null);
                    errorProvider1.SetError(txtConfirmPassword, null);
                    return true;
                }
                else
                {
                    errorProvider1.SetError(txtPassword, "Obavezno polje!");
                    errorProvider1.SetError(txtConfirmPassword, "Obavezno polje!");
                    return false;
                }
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtPassword, "Passwordi se ne slažu");
                errorProvider1.SetError(txtConfirmPassword, "Passwordi se ne slažu");
                return false;
            }
            else errorProvider1.Clear();


            return true;
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            if(ofdSlika.ShowDialog()==DialogResult.OK)
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
    }
}
