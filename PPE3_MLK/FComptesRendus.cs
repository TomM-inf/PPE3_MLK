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
    public partial class FComptesRendus : Form
    {
        public FComptesRendus()
        {
            InitializeComponent();
        }

        private void FComptesRendus_Load(object sender, EventArgs e)
        {
            cboPraticient.ValueMember = "idMedecin";
            cboPraticient.DisplayMember = "nom";
            bsMedecin.DataSource = Modele.listeMedecin();
            cboPraticient.DataSource = bsMedecin;

            cboRemplacent.ValueMember = "idMedecin"; //id remplacent au long terms
            cboRemplacent.DisplayMember = "nom";
            bsMedecin.DataSource = Modele.listeMedecin();
            cboRemplacent.DataSource = bsMedecin;

            cboMotif.ValueMember = "idMotif";
            cboMotif.DisplayMember = "libMotif";
            bsMotif.DataSource = Modele.listeMotif();
            cboMotif.DataSource = bsMotif;
            if (Modele.ActionGestionRapport == 1)
            {
                txtNumero.Text = Modele.RapportChoisi.idRapport.ToString();
                dateTimePicker1.Text = Modele.RapportChoisi.dateRapport.ToString();
                cboMotif.Text = Modele.RapportChoisi.MOTIF.libMotif.ToString();
                txtBilan.Text = Modele.RapportChoisi.bilan.ToString();
                cboPraticient.Text = Modele.RapportChoisi.MEDECIN.nom.ToString();
                cboRemplacent.Text = Modele.RapportChoisi.idMedecin.ToString();
                txtNumero.ReadOnly = true;
                dateTimePicker1.Enabled = false;
                cboMotif.Enabled = false;
                txtBilan.ReadOnly = true;
                cboPraticient.Enabled = false;
                cboRemplacent.Enabled = false;
            }
            if (Modele.ActionGestionRapport == 2)
            {
                txtNumero.Text = Modele.RapportChoisi.idRapport.ToString();
                dateTimePicker1.Text = Modele.RapportChoisi.dateRapport.ToString();
                cboMotif.Text = Modele.RapportChoisi.MOTIF.libMotif.ToString();
                txtBilan.Text = Modele.RapportChoisi.bilan.ToString();
                cboPraticient.Text = Modele.RapportChoisi.MEDECIN.nom.ToString();
                cboRemplacent.Text = Modele.RapportChoisi.idMedecin.ToString();
            }
            else
            {
                txtNumero.Text = Modele.idRapport().ToString();
            }


        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            System.Type type1 = bsMedecin.Current.GetType();
            System.Type type2 = bsMotif.Current.GetType();
            int idRapport = int.Parse(txtNumero.Text.ToString());
            int idMedecin = (int)type1.GetProperty("idMedecin").GetValue(bsMedecin.Current, null);
            DateTime dateRapport = dateTimePicker1.Value;
            string idVisiteur = "a12".ToString();
            string bilan = txtBilan.Text.ToString();
            int idMotif = (int)type2.GetProperty("idMotif").GetValue(bsMotif.Current, null);
            if (Modele.ActionGestionRapport == 2)
            {
                Modele.ModifRapport(dateRapport, idMotif, bilan, idVisiteur, idMedecin);
                this.Close();
            }

            if (Modele.ActionGestionRapport == 3)
            {
                Modele.AjoutRapport(dateRapport, idMotif, bilan, idVisiteur, idMedecin);
                this.Close();
            }
        }

        private void ChkPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPresent.Checked)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}

