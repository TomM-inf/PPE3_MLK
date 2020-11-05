namespace PPE3_MLK
{
    partial class frmListeVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSecReg = new System.Windows.Forms.Panel();
            this.pnlResp = new System.Windows.Forms.Panel();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenomResp = new System.Windows.Forms.Label();
            this.lblNomResp = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.cboReg = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblSecteur = new System.Windows.Forms.Label();
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.pnlRespSecteur = new System.Windows.Forms.Panel();
            this.txtPrenomSecteur = new System.Windows.Forms.TextBox();
            this.txtNomSecteur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSecReg.SuspendLayout();
            this.pnlResp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            this.pnlRespSecteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSecReg
            // 
            this.pnlSecReg.Controls.Add(this.pnlResp);
            this.pnlSecReg.Controls.Add(this.cboReg);
            this.pnlSecReg.Controls.Add(this.lblRegion);
            this.pnlSecReg.Controls.Add(this.dgvVisiteur);
            this.pnlSecReg.Controls.Add(this.lblIntitule);
            this.pnlSecReg.Location = new System.Drawing.Point(12, 100);
            this.pnlSecReg.Name = "pnlSecReg";
            this.pnlSecReg.Size = new System.Drawing.Size(776, 338);
            this.pnlSecReg.TabIndex = 0;
            // 
            // pnlResp
            // 
            this.pnlResp.Controls.Add(this.txtPrenom);
            this.pnlResp.Controls.Add(this.txtNom);
            this.pnlResp.Controls.Add(this.lblPrenomResp);
            this.pnlResp.Controls.Add(this.lblNomResp);
            this.pnlResp.Controls.Add(this.lblResp);
            this.pnlResp.Location = new System.Drawing.Point(221, 4);
            this.pnlResp.Name = "pnlResp";
            this.pnlResp.Size = new System.Drawing.Size(275, 76);
            this.pnlResp.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(58, 47);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(44, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // lblPrenomResp
            // 
            this.lblPrenomResp.AutoSize = true;
            this.lblPrenomResp.Location = new System.Drawing.Point(3, 50);
            this.lblPrenomResp.Name = "lblPrenomResp";
            this.lblPrenomResp.Size = new System.Drawing.Size(49, 13);
            this.lblPrenomResp.TabIndex = 2;
            this.lblPrenomResp.Text = "Prénom :";
            // 
            // lblNomResp
            // 
            this.lblNomResp.AutoSize = true;
            this.lblNomResp.Location = new System.Drawing.Point(3, 19);
            this.lblNomResp.Name = "lblNomResp";
            this.lblNomResp.Size = new System.Drawing.Size(35, 13);
            this.lblNomResp.TabIndex = 1;
            this.lblNomResp.Text = "Nom :";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(3, 1);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(218, 13);
            this.lblResp.TabIndex = 0;
            this.lblResp.Text = "Nom et prénom du responsable de la région :";
            // 
            // cboReg
            // 
            this.cboReg.FormattingEnabled = true;
            this.cboReg.Location = new System.Drawing.Point(7, 20);
            this.cboReg.Name = "cboReg";
            this.cboReg.Size = new System.Drawing.Size(121, 21);
            this.cboReg.TabIndex = 3;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(4, 4);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(109, 13);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Sélectionner la région";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AllowUserToAddRows = false;
            this.dgvVisiteur.AllowUserToDeleteRows = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(7, 86);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.Size = new System.Drawing.Size(316, 249);
            this.dgvVisiteur.TabIndex = 1;
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(7, 70);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(154, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Liste des visiteurs de la région :";
            // 
            // bsRegion
            // 
            this.bsRegion.CurrentChanged += new System.EventHandler(this.BsSecteurRegion_CurrentChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(16, 13);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(115, 13);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Sélectionner le secteur";
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(19, 29);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 2;
            this.cboSecteur.DisplayMemberChanged += new System.EventHandler(this.CboSecteur_DisplayMemberChanged);
            // 
            // bsSecteur
            // 
            this.bsSecteur.CurrentChanged += new System.EventHandler(this.BsSecteur_CurrentChanged);
            // 
            // pnlRespSecteur
            // 
            this.pnlRespSecteur.Controls.Add(this.txtPrenomSecteur);
            this.pnlRespSecteur.Controls.Add(this.txtNomSecteur);
            this.pnlRespSecteur.Controls.Add(this.label1);
            this.pnlRespSecteur.Controls.Add(this.label2);
            this.pnlRespSecteur.Controls.Add(this.label3);
            this.pnlRespSecteur.Location = new System.Drawing.Point(233, 12);
            this.pnlRespSecteur.Name = "pnlRespSecteur";
            this.pnlRespSecteur.Size = new System.Drawing.Size(275, 76);
            this.pnlRespSecteur.TabIndex = 5;
            // 
            // txtPrenomSecteur
            // 
            this.txtPrenomSecteur.Location = new System.Drawing.Point(58, 47);
            this.txtPrenomSecteur.Name = "txtPrenomSecteur";
            this.txtPrenomSecteur.ReadOnly = true;
            this.txtPrenomSecteur.Size = new System.Drawing.Size(100, 20);
            this.txtPrenomSecteur.TabIndex = 4;
            // 
            // txtNomSecteur
            // 
            this.txtNomSecteur.Location = new System.Drawing.Point(44, 19);
            this.txtNomSecteur.Name = "txtNomSecteur";
            this.txtNomSecteur.ReadOnly = true;
            this.txtNomSecteur.Size = new System.Drawing.Size(100, 20);
            this.txtNomSecteur.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom et prénom du responsable du secteur :";
            // 
            // frmListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRespSecteur);
            this.Controls.Add(this.cboSecteur);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.pnlSecReg);
            this.Name = "frmListeVisiteur";
            this.ShowIcon = false;
            this.Text = "Liste des visiteurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeVisiteur_FormClosed);
            this.pnlSecReg.ResumeLayout(false);
            this.pnlSecReg.PerformLayout();
            this.pnlResp.ResumeLayout(false);
            this.pnlResp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            this.pnlRespSecteur.ResumeLayout(false);
            this.pnlRespSecteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSecReg;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cboReg;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Panel pnlResp;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label lblNomResp;
        private System.Windows.Forms.Label lblPrenomResp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.Panel pnlRespSecteur;
        private System.Windows.Forms.TextBox txtPrenomSecteur;
        private System.Windows.Forms.TextBox txtNomSecteur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}