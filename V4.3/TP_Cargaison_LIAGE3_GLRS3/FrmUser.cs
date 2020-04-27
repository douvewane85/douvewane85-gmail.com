using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Cargaison_LIAGE3_GLRS3.entity;
using TP_Cargaison_LIAGE3_GLRS3.services;

namespace TP_Cargaison_LIAGE3_GLRS3
{

    //Utilisateur
     //nomComplet
     //login
     //Mot de passe
    public partial class FrmUser : Form
    {
        private CargaisonServiceBdEntity service = new CargaisonServiceBdEntity();
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            service.listerUser(dtgvUser);
            EnableControl();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void ClearControl()
        {
          foreach(var control in pnelNewUser.Controls)
            { 
                if(control is TextBox)
                {
                    ((TextBox)control).Clear();
                }

            }
           
        }

        private void EnableControl(string mode="Add")
        {
            foreach (var control in pnelNewUser.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled=false;
                }

            }
            btnDel.Enabled = false;
            btnRefrech.Enabled = true;
            if (mode.CompareTo("Add") == 0) {
                btnClear.Enabled = true;
                btnAdd.Enabled = true;
            }
            else
            {
                btnUp.Enabled = true;
                btnDel.Enabled = true;
            }

        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            EnableControl();
        }

        private Utilisateur userSelect =new Utilisateur();
        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableControl("UP");

            if (e.RowIndex <= dtgvUser.Rows.Count-1 && e.ColumnIndex >= 0 && dtgvUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = dtgvUser.Rows[e.RowIndex];
                row.Selected = true;
                userSelect.Id =int.Parse(row.Cells[0].Value.ToString());
                txtNom.Text = row.Cells[1].Value.ToString();
                txtLogin.Text = row.Cells[2].Value.ToString();
                txtPwd.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString().Trim().CompareTo("Admin")==0)
                {
                     radProfil2.Checked=true;
                }
                else
                {
                    radProfil1.Checked = true;
                }

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
         DialogResult dialog= MessageBox.Show("Veuillez confirmer la Suppression ??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                service.DeleteUser(userSelect.Id);
                service.listerUser(dtgvUser);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string profil = radProfil1.Text;
            if (radProfil2.Checked)
            {
                profil = radProfil2.Text;
            }
           Utilisateur user = new Utilisateur()
            {
               
                FullName=txtNom.Text,
                Login=txtLogin.Text,
                Pwd=txtPwd.Text,
                Profil=profil
            };

            service.CreerUser(user);
            service.listerUser(dtgvUser);
        }
    }
}
