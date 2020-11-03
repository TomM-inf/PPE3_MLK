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
            dgvListFicheFrais.Columns["idVisiteur"].Visible = false;



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
            btnQuitter.Visible = false;
            btnModif.Visible = true;
        }

        private void BsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
