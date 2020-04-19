using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Cargaison_LIAGE3_GLRS3
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
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
            
            if (f2 == null)
            {
                f2 = new FrmUser();
                f2.MdiParent = this;
                f2.Show();
            }
            
        }

             private void clearChild(){
                foreach(Form  f in this.MdiChildren)
                {
                    f.Close();
                }

            }
    }
}
