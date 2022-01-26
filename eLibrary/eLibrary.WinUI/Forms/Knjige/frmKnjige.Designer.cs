
namespace eLibrary.WinUI.Forms.Knjige
{
    partial class frmKnjige
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbZanr = new System.Windows.Forms.ComboBox();
            this.txtPisacPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajKnjigu = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKnjige = new System.Windows.Forms.DataGridView();
            this.NazivKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pisac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Komentari = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbZanr);
            this.groupBox2.Controls.Add(this.txtPisacPretraga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDodajKnjigu);
            this.groupBox2.Controls.Add(this.txtPretraga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 84);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(616, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Žanr:";
            // 
            // cmbZanr
            // 
            this.cmbZanr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanr.FormattingEnabled = true;
            this.cmbZanr.Location = new System.Drawing.Point(616, 48);
            this.cmbZanr.Name = "cmbZanr";
            this.cmbZanr.Size = new System.Drawing.Size(149, 23);
            this.cmbZanr.TabIndex = 6;
            this.cmbZanr.SelectedIndexChanged += new System.EventHandler(this.cmbZanr_SelectedIndexChanged);
            // 
            // txtPisacPretraga
            // 
            this.txtPisacPretraga.Location = new System.Drawing.Point(332, 48);
            this.txtPisacPretraga.Name = "txtPisacPretraga";
            this.txtPisacPretraga.Size = new System.Drawing.Size(206, 23);
            this.txtPisacPretraga.TabIndex = 4;
            this.txtPisacPretraga.TextChanged += new System.EventHandler(this.txtPisacPretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime ili prezime pisca:";
            // 
            // btnDodajKnjigu
            // 
            this.btnDodajKnjigu.Location = new System.Drawing.Point(810, 42);
            this.btnDodajKnjigu.Name = "btnDodajKnjigu";
            this.btnDodajKnjigu.Size = new System.Drawing.Size(135, 33);
            this.btnDodajKnjigu.TabIndex = 2;
            this.btnDodajKnjigu.Text = "Dodaj knjigu";
            this.btnDodajKnjigu.UseVisualStyleBackColor = true;
            this.btnDodajKnjigu.Click += new System.EventHandler(this.btnDodajKnjigu_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(11, 48);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(226, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv knjige:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKnjige);
            this.groupBox1.Location = new System.Drawing.Point(9, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 395);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Knjige";
            // 
            // dgvKnjige
            // 
            this.dgvKnjige.AllowUserToAddRows = false;
            this.dgvKnjige.AllowUserToDeleteRows = false;
            this.dgvKnjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivKnjige,
            this.Pisac,
            this.DatumIzdavanja,
            this.Zanr,
            this.Ocjena,
            this.Cijena,
            this.Izbrisi,
            this.Uredi,
            this.Komentari});
            this.dgvKnjige.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKnjige.Location = new System.Drawing.Point(3, 19);
            this.dgvKnjige.Name = "dgvKnjige";
            this.dgvKnjige.ReadOnly = true;
            this.dgvKnjige.RowTemplate.Height = 25;
            this.dgvKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKnjige.Size = new System.Drawing.Size(962, 373);
            this.dgvKnjige.TabIndex = 0;
            this.dgvKnjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKnjige_CellContentClick);
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.DataPropertyName = "NazivKnjige";
            this.NazivKnjige.FillWeight = 152.5937F;
            this.NazivKnjige.HeaderText = "NazivKnjige";
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.ReadOnly = true;
            // 
            // Pisac
            // 
            this.Pisac.DataPropertyName = "Pisac";
            this.Pisac.FillWeight = 152.5937F;
            this.Pisac.HeaderText = "Pisac";
            this.Pisac.Name = "Pisac";
            this.Pisac.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.FillWeight = 121.8275F;
            this.DatumIzdavanja.HeaderText = "DatumIzdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // Zanr
            // 
            this.Zanr.DataPropertyName = "Zanr";
            this.Zanr.FillWeight = 121.3407F;
            this.Zanr.HeaderText = "Zanr";
            this.Zanr.Name = "Zanr";
            this.Zanr.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.FillWeight = 55.75469F;
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.FillWeight = 66.82098F;
            this.Cijena.HeaderText = "Cijena ";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Izbrisi
            // 
            this.Izbrisi.FillWeight = 63.25634F;
            this.Izbrisi.HeaderText = "Izbriši";
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.ReadOnly = true;
            this.Izbrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbrisi.Text = "Izbriši";
            this.Izbrisi.UseColumnTextForButtonValue = true;
            // 
            // Uredi
            // 
            this.Uredi.FillWeight = 65.81277F;
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uredi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // Komentari
            // 
            this.Komentari.HeaderText = "Komentari";
            this.Komentari.Name = "Komentari";
            this.Komentari.ReadOnly = true;
            this.Komentari.Text = "Prikaži";
            this.Komentari.UseColumnTextForButtonValue = true;
            // 
            // frmKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKnjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKnjige";
            this.Load += new System.EventHandler(this.frmKnjige_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajKnjigu;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKnjige;
        private System.Windows.Forms.TextBox txtPisacPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbZanr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pisac;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
        private System.Windows.Forms.DataGridViewButtonColumn Komentari;
    }
}