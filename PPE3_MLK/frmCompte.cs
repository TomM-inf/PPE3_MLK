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
        }
    }
}
