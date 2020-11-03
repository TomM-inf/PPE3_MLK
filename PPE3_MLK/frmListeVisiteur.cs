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
    public partial class frmListeVisiteur : Form
    {
        public frmListeVisiteur()
        {
            InitializeComponent();
        }

        private void FrmListeVisiteur_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }
    }
}
