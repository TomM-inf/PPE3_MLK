﻿using System;
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
            pnlSecReg.Visible = false;
            if(Modele.ActionVisiteur == 0 || Modele.ActionVisiteur == 0)
            {
                pnlSecReg.Visible = true;
                if(Modele.ActionVisiteur == 0)
                {
                    lblSelection.Text = "Sélectionner le secteur";
                    lblIntitule.Text = "Liste des visiteurs du secteur :";
                    
                }
                if(Modele.ActionVisiteur == 1)
                {
                    lblSelection.Text = "Sélectionner la région";
                    lblIntitule.Text = "Liste des visiteurs de la région :";
                }
            }
        }

        private void FrmListeVisiteur_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.MdiParent.IsMdiContainer = false;
        }
    }
}