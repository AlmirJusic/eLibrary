
namespace eLibrary.WinUI.Forms.KorisnikKnjigaKomentar
{
    partial class frmKorisnikKnjigaKomentar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.KorisnikKnjigaKomentar_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SadrzajKomentara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKomentara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Knjiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Prikazi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPretraga);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sadržaj komentara:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(7, 46);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(236, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKomentari);
            this.groupBox1.Location = new System.Drawing.Point(9, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 327);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Komentari:";
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.AllowUserToAddRows = false;
            this.dgvKomentari.AllowUserToDeleteRows = false;
            this.dgvKomentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikKnjigaKomentar_ID,
            this.SadrzajKomentara,
            this.DatumKomentara,
            this.Knjiga,
            this.Korisnik,
            this.Izbrisi,
            this.Prikazi});
            this.dgvKomentari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKomentari.Location = new System.Drawing.Point(3, 19);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            this.dgvKomentari.RowTemplate.Height = 25;
            this.dgvKomentari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentari.Size = new System.Drawing.Size(743, 305);
            this.dgvKomentari.TabIndex = 0;
            this.dgvKomentari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentari_CellContentClick);
            // 
            // KorisnikKnjigaKomentar_ID
            // 
            this.KorisnikKnjigaKomentar_ID.DataPropertyName = "KorisnikKnjigaKomentar_ID";
            this.KorisnikKnjigaKomentar_ID.HeaderText = "KorisnikKnjigaKomentar_ID";
            this.KorisnikKnjigaKomentar_ID.Name = "KorisnikKnjigaKomentar_ID";
            this.KorisnikKnjigaKomentar_ID.ReadOnly = true;
            this.KorisnikKnjigaKomentar_ID.Visible = false;
            // 
            // SadrzajKomentara
            // 
            this.SadrzajKomentara.DataPropertyName = "SadrzajKomentara";
            this.SadrzajKomentara.FillWeight = 124.3736F;
            this.SadrzajKomentara.HeaderText = "Sadrzaj komentara";
            this.SadrzajKomentara.Name = "SadrzajKomentara";
            this.SadrzajKomentara.ReadOnly = true;
            // 
            // DatumKomentara
            // 
            this.DatumKomentara.DataPropertyName = "DatumKomentara";
            this.DatumKomentara.FillWeight = 52.46579F;
            this.DatumKomentara.HeaderText = "Datum";
            this.DatumKomentara.Name = "DatumKomentara";
            this.DatumKomentara.ReadOnly = true;
            // 
            // Knjiga
            // 
            this.Knjiga.DataPropertyName = "Knjiga";
            this.Knjiga.FillWeight = 124.3736F;
            this.Knjiga.HeaderText = "Knjiga";
            this.Knjiga.Name = "Knjiga";
            this.Knjiga.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.FillWeight = 89.64912F;
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Izbrisi
            // 
            this.Izbrisi.FillWeight = 49.96372F;
            this.Izbrisi.HeaderText = "Izbriši";
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.ReadOnly = true;
            this.Izbrisi.Text = "Izbriši";
            this.Izbrisi.UseColumnTextForButtonValue = true;
            // 
            // Prikazi
            // 
            this.Prikazi.FillWeight = 51.31678F;
            this.Prikazi.HeaderText = "Prikaži";
            this.Prikazi.Name = "Prikazi";
            this.Prikazi.ReadOnly = true;
            this.Prikazi.Text = "Prikaži";
            this.Prikazi.UseColumnTextForButtonValue = true;
            // 
            // frmKorisnikKnjigaKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKorisnikKnjigaKomentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisnikKnjigaKomentar";
            this.Load += new System.EventHandler(this.frmKorisnikKnjigaKomentar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikKnjigaKomentar_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SadrzajKomentara;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKomentara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Knjiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.DataGridViewButtonColumn Prikazi;
    }
}