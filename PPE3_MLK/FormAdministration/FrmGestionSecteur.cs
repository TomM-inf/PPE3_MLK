using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_MLK.FormAdministration
{
    public partial class FrmGestionSecteur : Form
    {
        public FrmGestionSecteur()
        {
            InitializeComponent();
            cboSecteur.ValueMember = "idSecteur";
            cboSecteur.DisplayMember = "libSecteur";
            bsSecteur.DataSource = Modele.listeSecteur();
            cboSecteur.DataSource = bsSecteur;
            cboSecteur.SelectedIndex = -1;
            pnlSecteur.Visible = false;
        }

        private void FrmGestionSecteur_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }
    }
}
