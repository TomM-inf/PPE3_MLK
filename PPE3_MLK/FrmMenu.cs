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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void InformationsDuCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompte fCompte = new frmCompte();
            fCompte.ShowDialog();
        }
    }
}
