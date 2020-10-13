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
    public partial class frmCompte : Form
    {
        private string sErreur = "Erreur de saisie :\n";
        public frmCompte()
        {
            InitializeComponent();
            //remplissage informations VisiteurConnecté (en vu d'une visualisation ou futur modifications)
            bsVisiteur.DataSource = Modele.VisiteurConnecte;
            txtNom.Text = ((Visiteur)bsVisiteur.Current).nom.ToString();
            txtPrenom.Text = ((Visiteur)bsVisiteur.Current).prenom.ToString();
            txtRue.Text = ((Visiteur)bsVisiteur.Current).rue.ToString();
            txtCP.Text = ((Visiteur)bsVisiteur.Current).cp.ToString();
            txtVille.Text = ((Visiteur)bsVisiteur.Current).ville.ToString();
            dgvRegion.DataSource = ((Visiteur)bsVisiteur.Current).Region.ToList();
            dgvRegion.RowHeadersVisible = false;
            for (int i = 0; i < dgvRegion.ColumnCount; i++)
            {
                dgvRegion.Columns[i].Visible = false;
            }
            dgvRegion.Columns["libRegion"].Visible = true;
            dgvRegion.ColumnHeadersVisible = false;
        }

        private void BtnModifValid_Click(object sender, EventArgs e)
        {
            if (btnModifValid.Text == "Modifier")
            {
                txtNom.ReadOnly = false;
                txtPrenom.ReadOnly = false;
                txtRue.ReadOnly = false;
                txtCP.ReadOnly = false;
                txtVille.ReadOnly = false;
                btnModifValid.Text = "Valider";
            }
            else
            {
                if (test())
                {
                    MessageBox.Show(sErreur, "Attention !");
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    string nom = txtNom.Text.Trim();
                    string prenom = txtPrenom.Text.Trim();
                    string rue = txtRue.Text.Trim();
                    string cp = txtCP.Text.Trim();
                    string ville = txtVille.Text.Trim();
                    Modele.modifierVisiteur(nom, prenom, rue, cp, ville);
                }
            }
            
        }

        private bool test()
        {
            bool erreur = false;
            if (txtNom.Text.Length == 0)
            {
                erreur = true;
                sErreur += "\t\u25C9\tNom visiteur vide\n";
            }
            if(txtPrenom.Text.Length == 0)
            {
                erreur = true;
                sErreur += "\t\u25C9\tPrenom visiteur vide\n";
            }
            if(txtRue.Text.Length == 0)
            {
                erreur = true;
                sErreur += "\t\u25C9\tRue visiteur vide\n";
            }
            if(txtCP.Text.Length != 5)
            {
                erreur = true;
                sErreur += "\t\u25C9\tCode postal visiteur incorrect\n";
            }
            if(txtVille.Text.Length == 0)
            {
                erreur = true;
                sErreur += "\t\u25C9\tVille visiteur vide\n";
            }
            return erreur;
        }
    }
}
