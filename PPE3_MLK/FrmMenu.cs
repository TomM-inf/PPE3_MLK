using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE3_MLK
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            informationsDuCompteToolStripMenuItem.Alignment = ToolStripItemAlignment.Left;
            this.IsMdiContainer = false;
        }

        private void InformationsDuCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompte fCompte = new frmCompte();
            fCompte.ShowDialog();
        }

        private void affichageParent()
        {
            this.IsMdiContainer = true;
            frmListeVisiteur flv = new frmListeVisiteur();
            flv.MdiParent = this;
            flv.Show();
      
        }
        private void ParSecteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modele.ActionVisiteur = 0;
            affichageParent();
        }

        private void ParRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modele.ActionVisiteur = 1;
            affichageParent();
        }

        private void HiérarchieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modele.ActionVisiteur = 2;
            affichageParent();
        }
    }
}
