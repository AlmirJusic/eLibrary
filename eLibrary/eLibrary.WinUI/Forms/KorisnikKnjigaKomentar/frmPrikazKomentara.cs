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

namespace eLibrary.WinUI.Forms.KorisnikKnjigaKomentar
{
    public partial class frmPrikazKomentara : Form
    {
        
        private eLibrary.Model.KorisnikKnjigaKomentar? _k = null;
        public frmPrikazKomentara(eLibrary.Model.KorisnikKnjigaKomentar? k = null)
        {
            InitializeComponent();
            _k = k;
        }

        private async void frmPrikazKomentara_Load(object sender, EventArgs e)
        {
            
            txtKomentar.Text = _k.SadrzajKomentara;
            lblKnjiga.Text = _k.Knjiga.NazivKnjige;
            lblKorisnik.Text = _k.Korisnik.Username;
            lblDatum.Text = _k.DatumKomentara.ToString();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
