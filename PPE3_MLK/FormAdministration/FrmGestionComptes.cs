using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_MLK
{
    public partial class FrmGestionComptes : Form
    {
        public FrmGestionComptes()
        {
            InitializeComponent();
            bsVisiteur.DataSource = Modele.listevisiteur();
            dgvVisiteur.DataSource = bsVisiteur;
            for (int i = 0; i < dgvVisiteur.ColumnCount; i++)
            {
                dgvVisiteur.Columns[i].Visible = false;
            }
            dgvVisiteur.Columns["nom"].Visible = true;
            dgvVisiteur.Columns["nom"].HeaderText = "Nom";
            dgvVisiteur.Columns["prenom"].Visible = true;
            dgvVisiteur.Columns["prenom"].HeaderText = "Prenom";
            dgvVisiteur.ClearSelection();
            dgvVisiteur.RowHeadersVisible = false;
        }

        private void FrmGestionComptes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }

        private void BsVisiteur_CurrentChanged(object sender, EventArgs e)
        {
            if((Visiteur)bsVisiteur.Current != null) //si un élément est sélectionné on affiche le pannel
            {
                pnlCompte.Visible = true;
            }
            if(((Visiteur)bsVisiteur.Current).etatCompte == false) // si le compte est désactivé
            {
                radioInactif.Checked = true; //le radio btn inactif est coché
            }
            else //sinon si il est vrai (ou null)
            {
                radioActif.Checked = true; //le radio btn actif est coché
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (radioActif.Checked)
            {
                Modele.changementEtat(((Visiteur)bsVisiteur.Current), true);
            }
            else
            {
                Modele.changementEtat(((Visiteur)bsVisiteur.Current), false);
            }
        }
    }
}
