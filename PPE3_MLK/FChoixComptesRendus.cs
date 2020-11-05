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
    public partial class FChoixComptesRendus : Form
    {
        public FChoixComptesRendus()
        {
            InitializeComponent();
        }
        private void FChoixComptesRendus_Load(object sender, EventArgs e)
        {
            cboMedecin.ValueMember = "idMedecin";
            cboMedecin.DisplayMember = "nom";
            bsMedecin.DataSource = Modele.listeMedecin();
            cboMedecin.DataSource = bsMedecin;
        }
        private void CboMedecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRapport.DataSource = Modele.RapportParMedecin(int.Parse(cboMedecin.SelectedValue.ToString()));
            dgvRapport.DataSource = bsRapport;
            dgvRapport.Columns[0].HeaderText = "N°";
            dgvRapport.Columns[1].HeaderText = "Date";
            dgvRapport.Columns[2].HeaderText = "Medecin";
            dgvRapport.Columns[3].HeaderText = "Motif";
            dgvRapport.Columns[4].HeaderText = "Visiteur";
           // dgvRapport.Columns[5].Visible = false;
        }
        private void btnVisionner_Click(object sender, EventArgs e)
        {
            FComptesRendus open = new FComptesRendus();
            open.Show();
        }
    }
}
