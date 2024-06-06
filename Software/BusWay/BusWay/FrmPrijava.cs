using BusWay.Repositories;
using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusWay
{
    public partial class FrmPrijava : Form
    {
        public FrmPrijava()
        {
            InitializeComponent();
            DB.SetConfiguration("PI2324_dprimorac21_DB", "PI2324_dprimorac21_User", "N:=yp!NO");
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                var korisnik = KorisnikRepozitorij.GetKorisnik(txtKorisnickoIme.Text);
                if (korisnik != null)
                {
                    if (txtLozinka.Text == korisnik.Lozinka)
                    {
                        FrmVoznaLinija frmVoznaLinija = new FrmVoznaLinija();
                        Hide();
                        frmVoznaLinija.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Kriva lozinka!", "Problem", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Korisnik sa korisničkim imenom " + txtKorisnickoIme.Text + " nije pronađen!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
    


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
