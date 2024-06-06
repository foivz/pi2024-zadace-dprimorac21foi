namespace BusWay
{
    partial class FrmDodajLiniju
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPolaziste = new System.Windows.Forms.TextBox();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.btnDodajLiniju = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cboxSatiVrijemePolaska = new System.Windows.Forms.ComboBox();
            this.cboxMinuteVrijemePolaska = new System.Windows.Forms.ComboBox();
            this.cboxSatiVrijemeDolaska = new System.Windows.Forms.ComboBox();
            this.cboxMinuteVrijemeDolaska = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(164, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(164, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polaziste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(164, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odrediste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(164, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrijeme Polaska";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(164, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrijeme Dolaska";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(340, 167);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(340, 219);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(202, 22);
            this.txtPolaziste.TabIndex = 6;
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(342, 276);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(200, 22);
            this.txtOdrediste.TabIndex = 10;
            // 
            // btnDodajLiniju
            // 
            this.btnDodajLiniju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDodajLiniju.Location = new System.Drawing.Point(463, 448);
            this.btnDodajLiniju.Name = "btnDodajLiniju";
            this.btnDodajLiniju.Size = new System.Drawing.Size(113, 35);
            this.btnDodajLiniju.TabIndex = 11;
            this.btnDodajLiniju.Text = "Stvori";
            this.btnDodajLiniju.UseVisualStyleBackColor = true;
            this.btnDodajLiniju.Click += new System.EventHandler(this.btnDodajLiniju_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnOdustani.Location = new System.Drawing.Point(316, 448);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 35);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cboxSatiVrijemePolaska
            // 
            this.cboxSatiVrijemePolaska.FormattingEnabled = true;
            this.cboxSatiVrijemePolaska.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboxSatiVrijemePolaska.Location = new System.Drawing.Point(342, 327);
            this.cboxSatiVrijemePolaska.Name = "cboxSatiVrijemePolaska";
            this.cboxSatiVrijemePolaska.Size = new System.Drawing.Size(80, 24);
            this.cboxSatiVrijemePolaska.TabIndex = 15;
            // 
            // cboxMinuteVrijemePolaska
            // 
            this.cboxMinuteVrijemePolaska.FormattingEnabled = true;
            this.cboxMinuteVrijemePolaska.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboxMinuteVrijemePolaska.Location = new System.Drawing.Point(463, 327);
            this.cboxMinuteVrijemePolaska.Name = "cboxMinuteVrijemePolaska";
            this.cboxMinuteVrijemePolaska.Size = new System.Drawing.Size(79, 24);
            this.cboxMinuteVrijemePolaska.TabIndex = 16;
            // 
            // cboxSatiVrijemeDolaska
            // 
            this.cboxSatiVrijemeDolaska.FormattingEnabled = true;
            this.cboxSatiVrijemeDolaska.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboxSatiVrijemeDolaska.Location = new System.Drawing.Point(342, 380);
            this.cboxSatiVrijemeDolaska.Name = "cboxSatiVrijemeDolaska";
            this.cboxSatiVrijemeDolaska.Size = new System.Drawing.Size(80, 24);
            this.cboxSatiVrijemeDolaska.TabIndex = 17;
            // 
            // cboxMinuteVrijemeDolaska
            // 
            this.cboxMinuteVrijemeDolaska.FormattingEnabled = true;
            this.cboxMinuteVrijemeDolaska.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboxMinuteVrijemeDolaska.Location = new System.Drawing.Point(463, 383);
            this.cboxMinuteVrijemeDolaska.Name = "cboxMinuteVrijemeDolaska";
            this.cboxMinuteVrijemeDolaska.Size = new System.Drawing.Size(79, 24);
            this.cboxMinuteVrijemeDolaska.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(116, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(502, 62);
            this.label6.TabIndex = 19;
            this.label6.Text = "Stvaranje nove linije";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FrmDodajLiniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxMinuteVrijemeDolaska);
            this.Controls.Add(this.cboxSatiVrijemeDolaska);
            this.Controls.Add(this.cboxMinuteVrijemePolaska);
            this.Controls.Add(this.cboxSatiVrijemePolaska);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajLiniju);
            this.Controls.Add(this.txtOdrediste);
            this.Controls.Add(this.txtPolaziste);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajLiniju";
            this.Text = "DodajLiniju";
            this.Load += new System.EventHandler(this.DodajLiniju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPolaziste;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Button btnDodajLiniju;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cboxSatiVrijemePolaska;
        private System.Windows.Forms.ComboBox cboxMinuteVrijemePolaska;
        private System.Windows.Forms.ComboBox cboxSatiVrijemeDolaska;
        private System.Windows.Forms.ComboBox cboxMinuteVrijemeDolaska;
        private System.Windows.Forms.Label label6;
    }
}