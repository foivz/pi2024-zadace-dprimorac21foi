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
        string korIme = "Dino";
        string lozinka = "Foi";

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
                if (txtKorisnickoIme.Text == korIme && txtLozinka.Text == lozinka)
                {
                    this.Hide();
                    FrmVoznaLinija FormVoznaLinija = new FrmVoznaLinija();
                    MessageBox.Show("Uspješna Prijava!", "Dobrodošli!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormVoznaLinija.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
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
    }
}
