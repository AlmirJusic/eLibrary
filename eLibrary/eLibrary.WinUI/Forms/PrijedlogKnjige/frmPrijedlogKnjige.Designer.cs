
namespace eLibrary.WinUI.Forms.PrijedlogKnjige
{
    partial class frmPrijedlogKnjige
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPrijedlogKnjige = new System.Windows.Forms.DataGridView();
            this.PrijdlogKnjige_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPrijedlogaKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrijedlogaKnjige = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijedlogKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPretraga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 81);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(6, 52);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(214, 23);
            this.txtPretraga.TabIndex = 1;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv prijedloga:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPrijedlogKnjige);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 335);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijedlozi:";
            // 
            // dgvPrijedlogKnjige
            // 
            this.dgvPrijedlogKnjige.AllowUserToAddRows = false;
            this.dgvPrijedlogKnjige.AllowUserToDeleteRows = false;
            this.dgvPrijedlogKnjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrijedlogKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrijedlogKnjige.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrijdlogKnjige_ID,
            this.NazivPrijedlogaKnjige,
            this.DatumPrijedlogaKnjige,
            this.Korisnik,
            this.Status});
            this.dgvPrijedlogKnjige.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrijedlogKnjige.Location = new System.Drawing.Point(3, 19);
            this.dgvPrijedlogKnjige.Name = "dgvPrijedlogKnjige";
            this.dgvPrijedlogKnjige.ReadOnly = true;
            this.dgvPrijedlogKnjige.RowTemplate.Height = 25;
            this.dgvPrijedlogKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrijedlogKnjige.Size = new System.Drawing.Size(621, 313);
            this.dgvPrijedlogKnjige.TabIndex = 0;
            this.dgvPrijedlogKnjige.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrijedlogKnjige_CellContentClick);
            this.dgvPrijedlogKnjige.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPrijedlogKnjige_CellFormatting);
            // 
            // PrijdlogKnjige_ID
            // 
            this.PrijdlogKnjige_ID.DataPropertyName = "PrijdlogKnjige_ID";
            this.PrijdlogKnjige_ID.HeaderText = "PrijdlogKnjige_ID";
            this.PrijdlogKnjige_ID.Name = "PrijdlogKnjige_ID";
            this.PrijdlogKnjige_ID.ReadOnly = true;
            this.PrijdlogKnjige_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrijdlogKnjige_ID.Visible = false;
            // 
            // NazivPrijedlogaKnjige
            // 
            this.NazivPrijedlogaKnjige.DataPropertyName = "NazivPrijedlogaKnjige";
            this.NazivPrijedlogaKnjige.FillWeight = 155.4069F;
            this.NazivPrijedlogaKnjige.HeaderText = "Naziv prijedloga";
            this.NazivPrijedlogaKnjige.Name = "NazivPrijedlogaKnjige";
            this.NazivPrijedlogaKnjige.ReadOnly = true;
            // 
            // DatumPrijedlogaKnjige
            // 
            this.DatumPrijedlogaKnjige.DataPropertyName = "DatumPrijedloga";
            this.DatumPrijedlogaKnjige.FillWeight = 50.76142F;
            this.DatumPrijedlogaKnjige.HeaderText = "Datum";
            this.DatumPrijedlogaKnjige.Name = "DatumPrijedlogaKnjige";
            this.DatumPrijedlogaKnjige.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.FillWeight = 155.4069F;
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Odgovoren";
            this.Status.FalseValue = "NE";
            this.Status.FillWeight = 38.42478F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.TrueValue = "DA";
            // 
            // frmPrijedlogKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrijedlogKnjige";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrijedlogKnjige";
            this.Load += new System.EventHandler(this.frmPrijedlogKnjige_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrijedlogKnjige)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPrijedlogKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrijdlogKnjige_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPrijedlogaKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrijedlogaKnjige;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}