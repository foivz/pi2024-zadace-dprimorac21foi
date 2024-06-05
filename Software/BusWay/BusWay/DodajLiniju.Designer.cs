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
            this.txtVrijemePolaska = new System.Windows.Forms.TextBox();
            this.txtVrijemeDolaska = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polaziste";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odrediste";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vrijeme Polaska";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrijeme Dolaska";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(345, 139);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(202, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtPolaziste
            // 
            this.txtPolaziste.Location = new System.Drawing.Point(345, 191);
            this.txtPolaziste.Name = "txtPolaziste";
            this.txtPolaziste.Size = new System.Drawing.Size(202, 22);
            this.txtPolaziste.TabIndex = 6;
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(347, 248);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(200, 22);
            this.txtOdrediste.TabIndex = 10;
            // 
            // btnDodajLiniju
            // 
            this.btnDodajLiniju.Location = new System.Drawing.Point(453, 420);
            this.btnDodajLiniju.Name = "btnDodajLiniju";
            this.btnDodajLiniju.Size = new System.Drawing.Size(94, 23);
            this.btnDodajLiniju.TabIndex = 11;
            this.btnDodajLiniju.Text = "Dodaj";
            this.btnDodajLiniju.UseVisualStyleBackColor = true;
            this.btnDodajLiniju.Click += new System.EventHandler(this.btnDodajLiniju_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(345, 420);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 23);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtVrijemePolaska
            // 
            this.txtVrijemePolaska.Location = new System.Drawing.Point(345, 307);
            this.txtVrijemePolaska.Name = "txtVrijemePolaska";
            this.txtVrijemePolaska.Size = new System.Drawing.Size(200, 22);
            this.txtVrijemePolaska.TabIndex = 13;
            // 
            // txtVrijemeDolaska
            // 
            this.txtVrijemeDolaska.Location = new System.Drawing.Point(345, 360);
            this.txtVrijemeDolaska.Name = "txtVrijemeDolaska";
            this.txtVrijemeDolaska.Size = new System.Drawing.Size(200, 22);
            this.txtVrijemeDolaska.TabIndex = 14;
            // 
            // FrmDodajLiniju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 539);
            this.Controls.Add(this.txtVrijemeDolaska);
            this.Controls.Add(this.txtVrijemePolaska);
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
        private System.Windows.Forms.TextBox txtVrijemePolaska;
        private System.Windows.Forms.TextBox txtVrijemeDolaska;
    }
}