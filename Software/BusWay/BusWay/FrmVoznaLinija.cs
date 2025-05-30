﻿using BusWay.Models;
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
    public partial class FrmVoznaLinija : Form
    {
        public FrmVoznaLinija()
        {
            InitializeComponent();

            this.dgvVozneLinije.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            FiltriranjePolazista();
        }

        public void FiltriranjePolazista()
        {
            cboxPolaziste.Items.Clear();
            List<string> polazista = VoznaLinijaRepository.GetUniquePolazista();
            for (int i = 0; i < polazista.Count; i++)
            {
                cboxPolaziste.Items.Add(polazista[i]);
            }
        }


        private void FrmVoznaLinija_Load(object sender, EventArgs e)
        {
            ShowVozneLinije();
            dgvVozneLinije.Columns[0].ReadOnly = true;
        }

        private void ShowVozneLinije()
        {
            List<VoznaLinija> voznelinije = VoznaLinijaRepository.GetVozneLinije();
            dgvVozneLinije.DataSource = voznelinije;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajLiniju FormDodajLiniju = new FrmDodajLiniju();
            FormDodajLiniju.ShowDialog();
            ShowVozneLinije();
            FiltriranjePolazista();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var voznaLinija = dgvVozneLinije.CurrentRow.DataBoundItem as VoznaLinija;
            VoznaLinijaRepository.ObrisiVoznuLiniju(voznaLinija);
            ShowVozneLinije();
            FiltriranjePolazista();

        }

        private void btnPrikaziSveLinije_Click(object sender, EventArgs e)
        {
            ShowVozneLinije();
        }

        private void cboxPolaziste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string polaziste = cboxPolaziste.Text;
            if (polaziste == "")
            {
                ShowVozneLinije();
            }
            else
            {
                VoznaLinijaRepository.GetVoznaLinijaPolaziste(polaziste);
                dgvVozneLinije.DataSource = VoznaLinijaRepository.GetVoznaLinijaPolaziste(polaziste);
            }
            
            
        }

        private void brnPromjeni_Click(object sender, EventArgs e)
        {
            var voznaLinija = dgvVozneLinije.CurrentRow.DataBoundItem as VoznaLinija;
            VoznaLinijaRepository.AzurirajVoznuLiniju(voznaLinija);
            ShowVozneLinije();
            FiltriranjePolazista();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava frmprijava = new FrmPrijava();
            Hide();
            frmprijava.ShowDialog();
            Close();
        }
    }
}
