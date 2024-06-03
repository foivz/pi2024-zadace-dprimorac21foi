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
    public partial class FrmVozniRed : Form
    {
        public FrmVozniRed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            Hide();
            frmLogin.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = VoznaLinijaRepozitorij.GetVozneLinije(dateTimePicker1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoznaLinija voznaLinija = new VoznaLinija
            {
                ImeLinije = "Varaždin-Zagreb",
                Polaziste = "VŽ",
                Dolaziste = "ZG",
                Datum = DateTime.Now.Date
            };
            VoznaLinijaRepozitorij.AddVoznaLinija(voznaLinija);
            dataGridView1.DataSource = VoznaLinijaRepozitorij.GetVozneLinije(dateTimePicker1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var voznaLinija = dataGridView1.CurrentRow.DataBoundItem as VoznaLinija;
            VoznaLinijaRepozitorij.DeleteVoznaLinija(voznaLinija);
            dataGridView1.DataSource = VoznaLinijaRepozitorij.GetVozneLinije(dateTimePicker1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var voznaLinija = dataGridView1.CurrentRow.DataBoundItem as VoznaLinija;
            VoznaLinija novaVoznaLinija = new VoznaLinija
            {
                Id = voznaLinija.Id,
                ImeLinije = "Zagreb-Varaždin",
                Polaziste = "ZG",
                Dolaziste = "VŽ",
                Datum = DateTime.Now.Date
            };
            VoznaLinijaRepozitorij.UpdateVoznaLinija(novaVoznaLinija);
            dataGridView1.DataSource = VoznaLinijaRepozitorij.GetVozneLinije(dateTimePicker1.Value);
        }
    }
}
