using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_3.zadaca
{
    public partial class Prijava : Form
    {
        string username = "Dino";
        string password = "Foi";
        public Prijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sendere, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste unijeli koristničko ime!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli lozinku!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if(txtKorisnickoIme.Text == username && txtLozinka.Text == password)
                {
                    MessageBox.Show("Prijava uspješna", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
