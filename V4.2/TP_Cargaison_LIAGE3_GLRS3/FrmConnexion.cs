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
    public partial class FrmConnexion : Form
    {
        private CargaisonServiceBd service = new CargaisonServiceBd();
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtPwd.Clear();
        }
        FrmMenu frmMenu;
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //Validation
           User user= service.SeConnecter(txtLogin.Text.Trim(), txtPwd.Text.Trim());
            if (user == null)
            {
                labelError.Visible = true;
            }
            else
            {
                frmMenu = new FrmMenu(user);
                frmMenu.Show();
                this.Hide();

            }

        }

        private void FrmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
