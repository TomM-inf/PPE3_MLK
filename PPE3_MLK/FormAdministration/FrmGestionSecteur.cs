﻿using System;
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
        string error = "Erreur :\n";
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

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            pnlSecteur.Visible = true;
            bsResponsable.DataSource = Modele.listevisiteur();
            txtLib.Text = ((Secteur)bsSecteur.Current).libSecteur;
            cboResp.ValueMember = "idVisiteur";
            cboResp.DisplayMember = "nom";
            cboResp.DataSource = bsResponsable;
            cboResp.SelectedIndex = -1;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (test())
            {

            }
        }

        private bool test()
        {
            bool vretour = true;
            if (txtLib.TextLength < 1)
            {
                vretour = false;
                error += "\tLe libellé doit être supérieur à 1 caractère\n";
            }
            return vretour;
        }
    }
}
