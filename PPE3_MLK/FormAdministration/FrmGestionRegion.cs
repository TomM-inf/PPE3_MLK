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
    public partial class FormGestionRegion : Form
    {
        string error = "Erreur :\n";
        public FormGestionRegion()
        {
            InitializeComponent();
        }

        private bool test()
        {
            bool vretour = true;
            if (txtLib.TextLength < 1)
            {
                vretour = false;
                error += "\n\t\u25C9 Le libellé doit être supérieur à 1 caractère\n";
            }
            return vretour;
        }

        private void FormGestionRegion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }
    }
}
