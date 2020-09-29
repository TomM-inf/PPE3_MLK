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
        }
        //prendre exemple sur FCompositeurOeuvre de musicAtout
        private void bsFicheFrais_CurrentChanged(object sender, EventArgs e)
        {
            //bsFicheFrais.DataSource =                A COMPLETER QUAND LA BDD SERA OK
            dgvListFicheFrais.DataSource = bsFicheFrais;
            for (int i=0; i<dgvListFicheFrais.ColumnCount; i++)
            {
                dgvListFicheFrais.Columns[i].Visible = false;
            }


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
            panel2.Visible = true;
            
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

        
    }
}
