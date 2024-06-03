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
    public partial class FrmLogin : Form
    {
        string username = "kor1";
        string password = "test";
        public FrmLogin()
        {
            InitializeComponent();
            DB.SetConfiguration("PI2324_dprimorac21_DB", "PI2324_dprimorac21_User", "N:=yp!NO");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                var korisnik = KorisnikRepozitorij.GetKorisnik(txtUsername.Text);
                if (korisnik != null)
                {
                    if (txtPassword.Text == korisnik.Lozinka)
                    {
                        FrmVozniRed frmVozniRed = new FrmVozniRed();
                        Hide();
                        frmVozniRed.ShowDialog();
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
                    MessageBox.Show("Korisnik sa korisničkim imenom " + txtUsername.Text + " nije pronađen!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
