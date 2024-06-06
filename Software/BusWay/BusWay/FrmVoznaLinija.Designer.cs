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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrikaziSveLinije = new System.Windows.Forms.Button();
            this.cboxPolaziste = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozneLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozneLinije
            // 
            this.dgvVozneLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozneLinije.Location = new System.Drawing.Point(30, 147);
            this.dgvVozneLinije.Name = "dgvVozneLinije";
            this.dgvVozneLinije.RowHeadersWidth = 51;
            this.dgvVozneLinije.RowTemplate.Height = 24;
            this.dgvVozneLinije.Size = new System.Drawing.Size(1048, 555);
            this.dgvVozneLinije.TabIndex = 0;
            this.dgvVozneLinije.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(980, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(732, 720);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 53);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj liniju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(859, 720);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(98, 53);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši liniju";
            this.btnObrisi.UseVisualStyleBackColor = true;
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
            this.btnPrikaziSveLinije.Location = new System.Drawing.Point(924, 92);
            this.btnPrikaziSveLinije.Name = "btnPrikaziSveLinije";
            this.btnPrikaziSveLinije.Size = new System.Drawing.Size(154, 40);
            this.btnPrikaziSveLinije.TabIndex = 7;
            this.btnPrikaziSveLinije.Text = "Prikaži sve linije";
            this.btnPrikaziSveLinije.UseVisualStyleBackColor = true;
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
            this.cboxPolaziste.Location = new System.Drawing.Point(164, 735);
            this.cboxPolaziste.Name = "cboxPolaziste";
            this.cboxPolaziste.Size = new System.Drawing.Size(194, 24);
            this.cboxPolaziste.TabIndex = 8;
            this.cboxPolaziste.SelectedIndexChanged += new System.EventHandler(this.cboxPolaziste_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 738);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filtriraj po polazištu";
            // 
            // FrmVoznaLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 915);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPolaziste);
            this.Controls.Add(this.btnPrikaziSveLinije);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVozneLinije);
            this.Name = "FrmVoznaLinija";
            this.Text = "FrmVoznaLinija";
            this.Load += new System.EventHandler(this.FrmVoznaLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozneLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozneLinije;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrikaziSveLinije;
        private System.Windows.Forms.ComboBox cboxPolaziste;
        private System.Windows.Forms.Label label1;
    }
}