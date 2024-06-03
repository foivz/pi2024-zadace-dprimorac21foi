using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusWay_Sustav
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string korIme = "Dino";
        string lozinka = "Foi";

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Unesite korisničko ime!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Unesite lozinku!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtKorisnickoIme.Text == korIme && txtLozinka.Text == lozinka)
                {
                    MessageBox.Show("Uspješna prijava!", "Dobrodošli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
