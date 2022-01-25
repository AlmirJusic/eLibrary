using eLibrary.WinUI.Forms;
using eLibrary.WinUI.Forms.Drzava;
using eLibrary.WinUI.Forms.Drzave;
using eLibrary.WinUI.Forms.Gradovi;
using eLibrary.WinUI.Forms.Knjige;
using eLibrary.WinUI.Forms.Korisnici;
using eLibrary.WinUI.Forms.Pisci;
using eLibrary.WinUI.Forms.Zanrovi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciAdd frm = new frmKorisniciAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzave frm = new frmDrzave();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledGradovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradovi frm = new frmGradovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajGradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGradoviAdd frm = new frmGradoviAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajDrzavuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrzaveAdd frm = new frmDrzaveAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void pregledŽanrovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZanrovi frm = new frmZanrovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajŽanrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZanroviAdd frm = new frmZanroviAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledajPisceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPisci frm = new frmPisci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajPiscaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPisciAdd frm = new frmPisciAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pregledKnjigaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKnjige frm = new frmKnjige();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKnjigeAdd frm = new frmKnjigeAdd();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
