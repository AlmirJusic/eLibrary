
namespace eLibrary.WinUI.Forms.Drzava
{
    partial class frmDrzave
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDrzave = new System.Windows.Forms.DataGridView();
            this.NazivDrzave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDodajDrzavu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDrzave);
            this.groupBox1.Location = new System.Drawing.Point(17, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Države:";
            // 
            // dgvDrzave
            // 
            this.dgvDrzave.AllowUserToAddRows = false;
            this.dgvDrzave.AllowUserToDeleteRows = false;
            this.dgvDrzave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrzave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrzave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivDrzave,
            this.Izbrisi,
            this.Uredi});
            this.dgvDrzave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrzave.Location = new System.Drawing.Point(3, 19);
            this.dgvDrzave.Name = "dgvDrzave";
            this.dgvDrzave.ReadOnly = true;
            this.dgvDrzave.RowTemplate.Height = 25;
            this.dgvDrzave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrzave.Size = new System.Drawing.Size(369, 285);
            this.dgvDrzave.TabIndex = 0;
            this.dgvDrzave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrzave_CellContentClick);
            // 
            // NazivDrzave
            // 
            this.NazivDrzave.DataPropertyName = "NazivDrzave";
            this.NazivDrzave.FillWeight = 207.8574F;
            this.NazivDrzave.HeaderText = "Naziv države";
            this.NazivDrzave.Name = "NazivDrzave";
            this.NazivDrzave.ReadOnly = true;
            // 
            // Izbrisi
            // 
            this.Izbrisi.FillWeight = 45.68528F;
            this.Izbrisi.HeaderText = "Izbriši";
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.ReadOnly = true;
            this.Izbrisi.Text = "Izbriši";
            this.Izbrisi.UseColumnTextForButtonValue = true;
            // 
            // Uredi
            // 
            this.Uredi.FillWeight = 46.45734F;
            this.Uredi.HeaderText = "Uredi";
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(17, 22);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(162, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnDodajDrzavu
            // 
            this.btnDodajDrzavu.Location = new System.Drawing.Point(220, 21);
            this.btnDodajDrzavu.Name = "btnDodajDrzavu";
            this.btnDodajDrzavu.Size = new System.Drawing.Size(172, 23);
            this.btnDodajDrzavu.TabIndex = 2;
            this.btnDodajDrzavu.Text = "Dodaj državu";
            this.btnDodajDrzavu.UseVisualStyleBackColor = true;
            this.btnDodajDrzavu.Click += new System.EventHandler(this.btnDodajDrzavu_Click);
            // 
            // frmDrzave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 412);
            this.Controls.Add(this.btnDodajDrzavu);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDrzave";
            this.Text = "frmDrzave";
            this.Load += new System.EventHandler(this.frmDrzave_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrzave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDrzave;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnDodajDrzavu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDrzave;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
    }
}