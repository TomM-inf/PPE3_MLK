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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            lblTitre.ForeColor = System.Drawing.Color.FromArgb(46,28,142);
            lblMsg.Visible = false;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            string reponse = Modele.validConnexion(txtIdentifiant.Text, txtMDP.Text);
            lblMsg.Text = reponse;
            lblMsg.Visible = true;
        }
    }
}
