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
    public partial class FrmFrais : Form
    {
        private List<string> mois = new List<string> { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "août", "septembre", "octobre", "novembre", "décembre" };

        public FrmFrais()
        {
            

            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            btnModif.Visible = false;
            textBox5.Text = Modele.nomVisiteur();
            Txtnom2.Text = Modele.nomVisiteur();
            txtIdVisiteur.Text = Modele.IDVisiteur();

            bsFicheFrais.DataSource = Modele.ListeFiche();
            dgvListFicheFrais.DataSource = bsFicheFrais;

            

            



                for (int i = 0; i < dgvListFicheFrais.ColumnCount; i++)
            {
                dgvListFicheFrais.Columns[i].Visible = false;
            }


            


             


            dgvListFicheFrais.Columns["dateModif"].Visible = true;
            dgvListFicheFrais.Columns["dateModif"].DisplayIndex = 1;
            dgvListFicheFrais.Columns["dateModif"].HeaderText="Date de Modification";
            dgvListFicheFrais.Columns["montantValide"].Visible = true;
            dgvListFicheFrais.Columns["montantValide"].DisplayIndex = 0;
            dgvListFicheFrais.Columns["montantValide"].HeaderText="Montant";
            dgvListFicheFrais.Columns["idVisiteur"].Visible = true;

           
            

            

        }


        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            //faire en sorte que ça sauvegarde 
            btnQuitter.Visible = true;
            btnModif.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            
        }


        private void txt1_TextChanged(object sender, EventArgs e)
        {
            btnQuitter.Visible = false;
            btnModif.Visible = true;
        }

        private void Txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;

            //AFFICHER LA DATE////////////////////////////////////////////////////////////////////////////////////////////////
            string vretour = "";
            vretour=((fichefrais)bsFicheFrais.Current).mois.Substring(4, 2);  //on sélectionne 2 caracteres apres le carac 4  de mois
            int vretour2 = Int32.Parse(vretour); //on met les caracteres en int
            vretour = mois[vretour2 - 1]; //on prend et réajuste le résultat (la liste commence par 0 mais janvier est le mois N°1)
            txtDate.Text = vretour; //on affiche dans la case.
            //FIN DATE //////////////////////////////////////////////////////////////////////////////////////////////////////////




            //DGV FRAIS FORFAITAIRES////////////////////////////////////////////////////////////////////////////////////////
            bsFraisForfait.DataSource = Modele.rembouMoisPasDep(((fichefrais)bsFicheFrais.Current).idVisiteur, ((fichefrais)bsFicheFrais.Current).mois);

            dgv1.DataSource = bsFraisForfait;

            dgv1.Columns[4].Visible = false;


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            //DGV HORS FORFAIT//////////////////////////////////////////////////////////////////////////////////////////

            bsFraisHorsForfait.DataSource = Modele.FraisHorsForfait(((fichefrais)bsFicheFrais.Current).idVisiteur, ((fichefrais)bsFicheFrais.Current).mois);

            dgv2.DataSource = bsFraisHorsForfait;




            /*for (int i = 0; i < dgv2.ColumnCount; i++) //afficher QUE les bonnes colonnes
            {
                dgv2.Columns[i].Visible = false;
            }*/
            
            dgv2.Columns[0].Visible = false;
            //dgv2.Columns[1].Visible = false;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        }
    }
}
