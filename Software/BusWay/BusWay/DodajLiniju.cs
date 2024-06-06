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
            int minPolaska;
            int minDolaska;
            int hPolaska;
            int hDolaska;

            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtOdrediste.Text) || string.IsNullOrEmpty(txtPolaziste.Text) ||
                string.IsNullOrEmpty(cboxMinuteVrijemePolaska.Text) || string.IsNullOrEmpty(cboxMinuteVrijemeDolaska.Text) ||
                string.IsNullOrEmpty(cboxSatiVrijemeDolaska.Text) ||
                string.IsNullOrEmpty(cboxSatiVrijemePolaska.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    minPolaska = Int32.Parse(cboxMinuteVrijemePolaska.Text);
                    minDolaska = Int32.Parse(cboxMinuteVrijemeDolaska.Text);
                    hPolaska = Int32.Parse(cboxSatiVrijemePolaska.Text);
                    hDolaska = Int32.Parse(cboxSatiVrijemeDolaska.Text);

                    if (!(minPolaska >= 0 && minPolaska <= 59 &&
                          minDolaska >= 0 && minDolaska <= 59 &&
                          hPolaska >= 0 && hPolaska <= 23 &&
                          hDolaska >= 0 && hDolaska <= 23))
                    {
                        MessageBox.Show("Raspon vrijednosti je kriv (sati:0-24, minute:0-59)!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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
                catch (FormatException)
                {
                    MessageBox.Show("Kod vremenskih vrijednosti možete unijeti samo brojeve!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    if (ex is SqlException && ((SqlException)ex).Number == 2627)
                    {
                        MessageBox.Show("ID već postoji u bazi podataka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Linija nije stvorena!\n" + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
