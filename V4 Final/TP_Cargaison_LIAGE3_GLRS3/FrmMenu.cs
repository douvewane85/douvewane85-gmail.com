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

namespace TP_Cargaison_LIAGE3_GLRS3
{
    public partial class FrmMenu : Form
    {
        User user;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(User user)
        {
            InitializeComponent();
            this.user = user;
        }



        Form1 f1;
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
                clearChild();
                f1 = new Form1();
                f1.MdiParent = this;
                f1.Show();
           
            
        }
        FrmUser f2;
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
                clearChild();
                f2 = new FrmUser();
                f2.MdiParent = this;
                f2.Show();
           
            
        }

             private void clearChild(){
                foreach(Form  f in this.MdiChildren)
                {
                    f.Close();
                }

            }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            labelNomPrenom.Text = string.Format("Nom et Prenom :{0}", user.FullName);
        }

        private void linkDeconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmConnexion().Show();
            this.Hide();
        }
    }
}
