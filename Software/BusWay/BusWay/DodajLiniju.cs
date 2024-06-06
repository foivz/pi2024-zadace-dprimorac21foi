using BusWay.Models;
using BusWay.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            int minPolaska = Int32.Parse(cboxMinuteVrijemePolaska.Text);
            int minDolaska = Int32.Parse(cboxMinuteVrijemeDolaska.Text);
            int hPolaska = Int32.Parse(cboxSatiVrijemePolaska.Text);
            int hDolaska = Int32.Parse(cboxSatiVrijemeDolaska.Text);
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtOdrediste.Text) || string.IsNullOrEmpty(txtPolaziste.Text) ||
                string.IsNullOrEmpty(cboxMinuteVrijemePolaska.Text) || string.IsNullOrEmpty(cboxMinuteVrijemeDolaska.Text) || 
                string.IsNullOrEmpty(cboxSatiVrijemeDolaska.Text) ||
                string.IsNullOrEmpty(cboxSatiVrijemePolaska.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(minPolaska >= 0 && minPolaska <= 59 &&
                    minDolaska >= 0 && minDolaska <= 59 &&
                    hPolaska >= 0 && hPolaska <= 23 &&
                    hDolaska >= 0 && hDolaska <= 23))
            {
                MessageBox.Show("Niste unijeli ispravne vrijednosti za sate ili minute!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = int.Parse(txtId.Text);
                    VoznaLinija novaVoznaLinija = new VoznaLinija()
                    {
                        Id = id,
                        Odrediste = txtOdrediste.Text,
                        Polaziste = txtPolaziste.Text,
                        VrijemeDolaska = cboxSatiVrijemeDolaska.Text + ":" + cboxMinuteVrijemeDolaska.Text,
                        VrijemePolaska = cboxSatiVrijemePolaska.Text + ":" + cboxMinuteVrijemeDolaska.Text,
                    };

                    VoznaLinijaRepository voznaLinijaRepo = new VoznaLinijaRepository();
                    VoznaLinijaRepository.KreirajVoznuLiniju(novaVoznaLinija);

                    MessageBox.Show("Nova vozna linija kreirana!", "Kreirana linija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (ex is SqlException && ((SqlException)ex).Number == 2627) 
                    {
                        MessageBox.Show("ID već postoji u bazi podataka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Dogodila se greška prilikom dodavanja vozne linije:\n" + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
