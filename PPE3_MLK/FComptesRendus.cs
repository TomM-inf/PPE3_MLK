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
            cboPraticient.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cboPraticient.DisplayMember = "libMedecin";
            bsMedecin.DataSource = Modele.listeMedecin();
            cboPraticient.DataSource = bsMedecin;
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = Modele.listeStyle();
            cboStyle.DataSource = bsStyle;

            if (Modele.ActionGestionRapport == 2)
            {
                txtNumero.Text = Modele.rapportChoisi.idRapport;
                dateTimePicker1.Text = Modele.rapportChoisi.dateRapport;
                cboMotif.Text = Modele.rapportChoisi.idMotif;
                txtBilan.Text = Modele.rapportChoisi.bilan();
                //.Text = Modele.rapportChoisi.idVisiteur.ToString();
                cboPraticient.Text = Modele.rapportChoisi.MEDECIN.libMedecin;
                cboRemplacent.Text = Modele.rapportChoisi.MEDECIN.libMedecin;
            }
        }
    }
       /* private void Label8_Click(object sender, EventArgs e)
        {
            if (chkPresent.Checked == false)
            {
                label8.Visible = true;
                cboRemplacent.Visible = true;

            }    
        }*/
    }
}
