
namespace eLibrary.WinUI
{
    partial class frmIndex
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drzaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajDrzavuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledGradovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.žanroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledŽanrovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajŽanrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajPisceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPiscaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.komentariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 568);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.drzaveToolStripMenuItem,
            this.gradoviToolStripMenuItem,
            this.žanroviToolStripMenuItem,
            this.pisciToolStripMenuItem,
            this.knjigeToolStripMenuItem,
            this.komentariToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(948, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKorisnikaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // pregledKorisnikaToolStripMenuItem
            // 
            this.pregledKorisnikaToolStripMenuItem.Name = "pregledKorisnikaToolStripMenuItem";
            this.pregledKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pregledKorisnikaToolStripMenuItem.Text = "Pregled korisnika";
            this.pregledKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.pregledKorisnikaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // drzaveToolStripMenuItem
            // 
            this.drzaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazToolStripMenuItem,
            this.dodajDrzavuToolStripMenuItem});
            this.drzaveToolStripMenuItem.Name = "drzaveToolStripMenuItem";
            this.drzaveToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.drzaveToolStripMenuItem.Text = "Drzave";
            // 
            // prikazToolStripMenuItem
            // 
            this.prikazToolStripMenuItem.Name = "prikazToolStripMenuItem";
            this.prikazToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.prikazToolStripMenuItem.Text = "Pregled drzava";
            this.prikazToolStripMenuItem.Click += new System.EventHandler(this.prikazToolStripMenuItem_Click);
            // 
            // dodajDrzavuToolStripMenuItem
            // 
            this.dodajDrzavuToolStripMenuItem.Name = "dodajDrzavuToolStripMenuItem";
            this.dodajDrzavuToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.dodajDrzavuToolStripMenuItem.Text = "Dodaj drzavu";
            this.dodajDrzavuToolStripMenuItem.Click += new System.EventHandler(this.dodajDrzavuToolStripMenuItem_Click);
            // 
            // gradoviToolStripMenuItem
            // 
            this.gradoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledGradovaToolStripMenuItem,
            this.dodajGradToolStripMenuItem});
            this.gradoviToolStripMenuItem.Name = "gradoviToolStripMenuItem";
            this.gradoviToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.gradoviToolStripMenuItem.Text = "Gradovi";
            // 
            // pregledGradovaToolStripMenuItem
            // 
            this.pregledGradovaToolStripMenuItem.Name = "pregledGradovaToolStripMenuItem";
            this.pregledGradovaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pregledGradovaToolStripMenuItem.Text = "Pregled gradova";
            this.pregledGradovaToolStripMenuItem.Click += new System.EventHandler(this.pregledGradovaToolStripMenuItem_Click);
            // 
            // dodajGradToolStripMenuItem
            // 
            this.dodajGradToolStripMenuItem.Name = "dodajGradToolStripMenuItem";
            this.dodajGradToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dodajGradToolStripMenuItem.Text = "Dodaj grad";
            this.dodajGradToolStripMenuItem.Click += new System.EventHandler(this.dodajGradToolStripMenuItem_Click);
            // 
            // žanroviToolStripMenuItem
            // 
            this.žanroviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledŽanrovaToolStripMenuItem,
            this.dodajŽanrToolStripMenuItem});
            this.žanroviToolStripMenuItem.Name = "žanroviToolStripMenuItem";
            this.žanroviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.žanroviToolStripMenuItem.Text = "Žanrovi";
            // 
            // pregledŽanrovaToolStripMenuItem
            // 
            this.pregledŽanrovaToolStripMenuItem.Name = "pregledŽanrovaToolStripMenuItem";
            this.pregledŽanrovaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledŽanrovaToolStripMenuItem.Text = "Pregled žanrova";
            this.pregledŽanrovaToolStripMenuItem.Click += new System.EventHandler(this.pregledŽanrovaToolStripMenuItem_Click);
            // 
            // dodajŽanrToolStripMenuItem
            // 
            this.dodajŽanrToolStripMenuItem.Name = "dodajŽanrToolStripMenuItem";
            this.dodajŽanrToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajŽanrToolStripMenuItem.Text = "Dodaj žanr";
            this.dodajŽanrToolStripMenuItem.Click += new System.EventHandler(this.dodajŽanrToolStripMenuItem_Click);
            // 
            // pisciToolStripMenuItem
            // 
            this.pisciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajPisceToolStripMenuItem,
            this.dodajPiscaToolStripMenuItem});
            this.pisciToolStripMenuItem.Name = "pisciToolStripMenuItem";
            this.pisciToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.pisciToolStripMenuItem.Text = "Pisci";
            // 
            // pregledajPisceToolStripMenuItem
            // 
            this.pregledajPisceToolStripMenuItem.Name = "pregledajPisceToolStripMenuItem";
            this.pregledajPisceToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.pregledajPisceToolStripMenuItem.Text = "Pregledaj pisce";
            this.pregledajPisceToolStripMenuItem.Click += new System.EventHandler(this.pregledajPisceToolStripMenuItem_Click);
            // 
            // dodajPiscaToolStripMenuItem
            // 
            this.dodajPiscaToolStripMenuItem.Name = "dodajPiscaToolStripMenuItem";
            this.dodajPiscaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dodajPiscaToolStripMenuItem.Text = "Dodaj pisca";
            this.dodajPiscaToolStripMenuItem.Click += new System.EventHandler(this.dodajPiscaToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledKnjigaToolStripMenuItem,
            this.dodajKnjiguToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // pregledKnjigaToolStripMenuItem
            // 
            this.pregledKnjigaToolStripMenuItem.Name = "pregledKnjigaToolStripMenuItem";
            this.pregledKnjigaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pregledKnjigaToolStripMenuItem.Text = "Pregled knjiga";
            this.pregledKnjigaToolStripMenuItem.Click += new System.EventHandler(this.pregledKnjigaToolStripMenuItem_Click);
            // 
            // dodajKnjiguToolStripMenuItem
            // 
            this.dodajKnjiguToolStripMenuItem.Name = "dodajKnjiguToolStripMenuItem";
            this.dodajKnjiguToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dodajKnjiguToolStripMenuItem.Text = "Dodaj knjigu";
            this.dodajKnjiguToolStripMenuItem.Click += new System.EventHandler(this.dodajKnjiguToolStripMenuItem_Click);
            // 
            // komentariToolStripMenuItem
            // 
            this.komentariToolStripMenuItem.Name = "komentariToolStripMenuItem";
            this.komentariToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.komentariToolStripMenuItem.Text = "Komentari";
            this.komentariToolStripMenuItem.Click += new System.EventHandler(this.komentariToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eLibrary.WinUI.Properties.Resources.old_book_flying_letters_magic_light_background_bookshelf_library_ancient_books_as_symbol_knowledge_history_218640948;
            this.ClientSize = new System.Drawing.Size(948, 590);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIndex_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drzaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledGradovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajDrzavuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem žanroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledŽanrovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajŽanrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajPisceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPiscaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem komentariToolStripMenuItem;
    }
}



