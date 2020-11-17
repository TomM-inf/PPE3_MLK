using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data; //DataTable

namespace PPE3_MLK
{
    public partial class frmListeVisiteur : Form
    {
        private System.EventArgs x;
        public frmListeVisiteur()
        {
            InitializeComponent();
            pnlSecReg.Visible = false;
            if(Modele.ActionVisiteur == 0 || Modele.ActionVisiteur == 1)
            {
                pnlResp.Visible = false;
                pnlRespSecteur.Visible = false;
                if (Modele.ActionVisiteur == 0)
                {
                    pnlSecReg.Location = new Point(12, 100);
                    cboSecteur.ValueMember = "idSecteur";
                    cboSecteur.DisplayMember = "libSecteur";
                    bsSecteur.DataSource = Modele.listeSecteur();
                    cboSecteur.DataSource = bsSecteur;
                    cboSecteur.SelectedIndex = -1;
                }
                if(Modele.ActionVisiteur == 1)
                {
                    lblSecteur.Visible = false;
                    cboSecteur.Visible = false;
                    cboReg.ValueMember = "idRegion";
                    cboReg.DisplayMember = "libRegion";
                    bsRegion.DataSource = Modele.listeRegion();
                    cboReg.DataSource = bsRegion;
                    cboReg.SelectedIndex = -1;
                    pnlSecReg.Location = new Point(12,12);
                }
                pnlSecReg.Visible = true;
            }
        }

        private void FrmListeVisiteur_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }

        private void BsSecteurRegion_CurrentChanged(object sender, EventArgs e)
        {

            if(cboReg.SelectedIndex!= -1) //on vérifie que la selection n'est pas vide
            {
                //remplissage DGV
                bsVisiteur.DataSource = ((Region)bsRegion.Current).Visiteur1.ToList();
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
                pnlResp.Visible = true;
                //Remplissage RESP
                txtNom.Text = ((Region)bsRegion.Current).Visiteur.nom;
                txtPrenom.Text = ((Region)bsRegion.Current).Visiteur.prenom;
                
            }
        }

        private void BsSecteur_CurrentChanged(object sender, EventArgs e)
        {
            //remplissage bsRegion
            cboReg.ValueMember = "idRegion";
            cboReg.DisplayMember = "libRegion";
            bsRegion.DataSource = ((Secteur)bsSecteur.Current).Region.ToList();
            cboReg.DataSource = bsRegion;
            cboReg.SelectedIndex = -1;
            //Remplissage RESP secteur
            //if (cboSecteur.SelectedIndex > -1)
            {
                pnlRespSecteur.Visible = true;
                txtNomSecteur.Text = ((Secteur)bsSecteur.Current).Visiteur.nom;
                txtPrenomSecteur.Text = ((Secteur)bsSecteur.Current).Visiteur.prenom;
            }
            //remplissage bs region
            cboReg.ValueMember = "idRegion";
            cboReg.DisplayMember = "libRegion";
            cboReg.DataSource = bsRegion;
            cboReg.SelectedIndex = -1;
            pnlResp.Visible = false;
        }
    }
}
