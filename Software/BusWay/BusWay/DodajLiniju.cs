using BusWay.Models;
using BusWay.Repositories;
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
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtOdrediste.Text) || string.IsNullOrEmpty(txtPolaziste.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(txtId.Text);
                VoznaLinija novaVoznaLinija = new VoznaLinija()
                {
                    Id = id,
                    Odrediste = txtOdrediste.Text,
                    Polaziste = txtPolaziste.Text,
                    VrijemeDolaska = txtVrijemeDolaska.Text,
                    VrijemePolaska = txtVrijemePolaska.Text,
                };

                VoznaLinijaRepository voznaLinijaRepo = new VoznaLinijaRepository();
                VoznaLinijaRepository.KreirajVoznuLiniju(novaVoznaLinija);

                MessageBox.Show("Nova vozna linija kreirana!", "Kreirana linija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
