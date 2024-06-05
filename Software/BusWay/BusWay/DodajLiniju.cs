using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusWay
{
    public partial class FrmDodajLiniju : Form
    {
        public FrmDodajLiniju()
        {
            InitializeComponent();
        }

        private void DodajLiniju_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajLiniju_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" && txtOdrediste.Text == "" && txtPolaziste.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
