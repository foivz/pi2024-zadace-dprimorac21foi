namespace BusWay
{
    partial class FrmVoznaLinija
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
            this.dgvVozneLinije = new System.Windows.Forms.DataGridView();
            this.brnPromjeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikaziSveLinije = new System.Windows.Forms.Button();
            this.cboxPolaziste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozneLinije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozneLinije
            // 
            this.dgvVozneLinije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozneLinije.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvVozneLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozneLinije.Location = new System.Drawing.Point(30, 147);
            this.dgvVozneLinije.Name = "dgvVozneLinije";
            this.dgvVozneLinije.RowHeadersWidth = 51;
            this.dgvVozneLinije.RowTemplate.Height = 24;
            this.dgvVozneLinije.Size = new System.Drawing.Size(1048, 555);
            this.dgvVozneLinije.TabIndex = 0;
            this.dgvVozneLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // brnPromjeni
            // 
            this.brnPromjeni.BackColor = System.Drawing.Color.LightBlue;
            this.brnPromjeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brnPromjeni.Location = new System.Drawing.Point(762, 723);
            this.brnPromjeni.Name = "brnPromjeni";
            this.brnPromjeni.Size = new System.Drawing.Size(156, 53);
            this.brnPromjeni.TabIndex = 1;
            this.brnPromjeni.Text = "Promjeni liniju";
            this.brnPromjeni.UseVisualStyleBackColor = false;
            this.brnPromjeni.Click += new System.EventHandler(this.brnPromjeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(924, 723);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(161, 53);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj liniju";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.LightCoral;
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(595, 723);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(161, 53);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši liniju";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 108);
            this.label3.TabIndex = 5;
            this.label3.Text = "BusWay";
            // 
            // btnPrikaziSveLinije
            // 
            this.btnPrikaziSveLinije.BackColor = System.Drawing.Color.OldLace;
            this.btnPrikaziSveLinije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSveLinije.Location = new System.Drawing.Point(893, 92);
            this.btnPrikaziSveLinije.Name = "btnPrikaziSveLinije";
            this.btnPrikaziSveLinije.Size = new System.Drawing.Size(185, 40);
            this.btnPrikaziSveLinije.TabIndex = 7;
            this.btnPrikaziSveLinije.Text = "Prikaži sve linije";
            this.btnPrikaziSveLinije.UseVisualStyleBackColor = false;
            this.btnPrikaziSveLinije.Click += new System.EventHandler(this.btnPrikaziSveLinije_Click);
            // 
            // cboxPolaziste
            // 
            this.cboxPolaziste.FormattingEnabled = true;
            this.cboxPolaziste.Items.AddRange(new object[] {
            "Varaždin",
            "Donji Kneginec",
            "Gojanec",
            "Zbelava",
            ""});
            this.cboxPolaziste.Location = new System.Drawing.Point(211, 740);
            this.cboxPolaziste.Name = "cboxPolaziste";
            this.cboxPolaziste.Size = new System.Drawing.Size(194, 24);
            this.cboxPolaziste.TabIndex = 8;
            this.cboxPolaziste.SelectedIndexChanged += new System.EventHandler(this.cboxPolaziste_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 738);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtriraj po polazištu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BusWay.Properties.Resources.busek_slika;
            this.pictureBox1.Location = new System.Drawing.Point(364, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmVoznaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1108, 784);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPolaziste);
            this.Controls.Add(this.btnPrikaziSveLinije);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.brnPromjeni);
            this.Controls.Add(this.dgvVozneLinije);
            this.Name = "FrmVoznaLinija";
            this.Text = "FrmVoznaLinija";
            this.Load += new System.EventHandler(this.FrmVoznaLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozneLinije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozneLinije;
        private System.Windows.Forms.Button brnPromjeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikaziSveLinije;
        private System.Windows.Forms.ComboBox cboxPolaziste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}