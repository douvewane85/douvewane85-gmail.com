﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Cargaison_LIAGE3_GLRS3.models;
using TP_Cargaison_LIAGE3_GLRS3.services;

namespace TP_Cargaison_LIAGE3_GLRS3
{
    public partial class Form1 : Form
    {
        private CargaisonService service = new CargaisonService();
        private List<Cargaison> cargaisons;
        Cargaison cargaisonSelect;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            //Recuperation de la liste des Cargaisons
            cargaisons = service.ListerCargaison();
            //Chargement ListeView
            
            foreach (Cargaison car in cargaisons)
            {
                listViewCargaison.Items.Add(car);
            }

            listViewCargaison.SelectedIndex=0;

            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cargaison cargaison = null;
            if (!string.IsNullOrEmpty(txtDistance.Text))
            {
                if (cboType.Text.CompareTo("Aerienne") == 0)
                {
                    cargaison = new Aerienne();
                }
                cargaison.Distance = double.Parse(txtDistance.Text);
                if (service.AddCargaison(cargaison))
                {
                    MessageBox.Show("Une Cargaison Ajoutée ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listViewCargaison.Items.Add(cargaison.ToString());
                    txtDistance.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez Saisir la Distance","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void listViewCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            
       }

        private void listViewCargaison_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            cargaisonSelect = (Cargaison)listViewCargaison.SelectedItem;
            
            dgvMarchandises.DataSource = service.ListerMarchandiseDUneGargaison(cargaisonSelect);

            txtPoidsTotal.Text = cargaisonSelect.PoidsTotal.ToString();
            txtVolumeTotal.Text = cargaisonSelect.VolumeTotal.ToString();
            txtCout.Text = cargaisonSelect.Cout().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.AddMarchandiseInGargaison(
                new Marchandise()
                {
                    Poid = int.Parse(txtPoids.Text),
                    Volume = int.Parse(txtVolume.Text),
                    Cargaison = cargaisonSelect

                }
                );
            dgvMarchandises.DataSource = service.ListerMarchandiseDUneGargaison(cargaisonSelect);

            txtPoidsTotal.Text = cargaisonSelect.PoidsTotal.ToString();
            txtVolumeTotal.Text = cargaisonSelect.VolumeTotal.ToString();
            txtCout.Text = cargaisonSelect.Cout().ToString();
        }
    }
}
