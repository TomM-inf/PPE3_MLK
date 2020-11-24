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
        }
        private void btnVisionner_Click(object sender, EventArgs e)
        {
            Modele.ActionGestionRapport = 1;
            FComptesRendus open = new FComptesRendus();
            open.Show();

        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsRapport.Current.GetType();
            int id = (int)type.GetProperty("idRapport").GetValue(bsRapport.Current, null);
            Modele.getRapportParNum(id);
            Modele.ActionGestionRapport = 2;
            FComptesRendus open = new FComptesRendus();
            open.Show();
        }

        private void BtnCreer_Click(object sender, EventArgs e)
        {
            Modele.ActionGestionRapport = 3;
            FComptesRendus open = new FComptesRendus();
            open.Show();
        }
    }
}
