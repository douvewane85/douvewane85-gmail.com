using System;
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
                lbxCargaison.Items.Add(car);
            }

             lbxCargaison.SelectedIndex = 0;

            

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

                    lbxCargaison.Items.Add(cargaison);
                    txtDistance.Clear();
                }
            }
            else
            {
                MessageBox.Show("Veuillez Saisir la Distance","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       

        private void lbxCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargaisonSelect =(Cargaison) lbxCargaison.SelectedItem ;
            loadDataGridView();
        }

        private void btnAddMarchandise_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtPoids.Text) || string.IsNullOrEmpty(txtVolume.Text))
            {
                MessageBox.Show("Veuillez Remplir les Champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Marchandise mar = new Marchandise()
                {
                  Poid=double.Parse(txtPoids.Text),
                  Volume=double.Parse(txtVolume.Text),
                  Cargaison= cargaisonSelect
                };
                service.AddMarchandiseInGargaison(mar);
                MessageBox.Show("Marchandise Ajoutée avec Succes", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtPoids.Clear();
                txtVolume.Clear();

                cargaisonSelect.PoidsTotal = 0;
                cargaisonSelect.VolumeTotal = 0;
                loadDataGridView();


            }
           
           
        }

        private  void loadDataGridView()
        {
            dgvMarchandises.DataSource = service.ListerMarchandiseDUneGargaison(cargaisonSelect);
            txtPoidsTotal.Text = cargaisonSelect.PoidsTotal.ToString();
            txtVolumeTotal.Text = cargaisonSelect.VolumeTotal.ToString();
            txtCout.Text = cargaisonSelect.Cout().ToString();
        }


    }
}
