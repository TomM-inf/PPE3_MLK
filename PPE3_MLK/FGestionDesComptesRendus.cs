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
    public partial class FGestionDesComptesRendus : Form
    {
        public FGestionDesComptesRendus()
        {
            InitializeComponent();
        }

        private void BtnComptesRendus_Click(object sender, EventArgs e)
        {
            FChoixComptesRendus open = new FChoixComptesRendus();
            open.FormBorderStyle = FormBorderStyle.None;
            open.TopLevel = false;
            panel2.Controls.Add(open);
            open.Show();
        }
        private void FGestionDesComptesRendus_Load(object sender, EventArgs e)
        {

        }
    }
}
