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
    public partial class FrmChangementMDP : Form
    {
        private string sError = "Erreur dans :\n";
        public FrmChangementMDP()
        {
            InitializeComponent();
        }

        private bool test()
        {
            bool error = false;
            if (Modele.validMDP(txtMdpActu.Text))
            {
                error = true;
                sError += "\n\t\u25C9 Le mot de passe actuel est erroné";
            }
            if (txtNewMdp.Text != txtNewMdp2.Text)
            {
                error = true;
                sError += "\n\t\u25C9 Les nouveaux mot de passe ne correspondent pas";
            }
            if (txtNewMdp.Text.Length <= 3)
            {
                error = true;
                sError += "\n\t\u25C9 Le nouveau mot de passe doit contenir plus de 3 caractères";
            }
            return error;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (test())
            {
                MessageBox.Show(sError, "Erreur !");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                Modele.changementMDP(txtNewMdp.Text);
                MessageBox.Show("Le mot de passe à bien été changé.", "Réussite !");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
