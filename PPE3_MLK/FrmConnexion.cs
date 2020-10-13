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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            lblTitre.ForeColor = System.Drawing.Color.FromArgb(46,28,142);
            lblMsg.Visible = false;
            //préremplissage pour test A SUPPRIMER !!
            txtIdentifiant.Text = "dandre";
            txtMDP.Text = "oppg5";
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string reponse = Modele.validConnexion(txtIdentifiant.Text, txtMDP.Text);
            lblMsg.Text = reponse;
            lblMsg.Visible = true;
            if(reponse == "valide")
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }

        public static void ThreadProc()
        {
            Application.Run(new FrmMenu());
        }
    }
}
