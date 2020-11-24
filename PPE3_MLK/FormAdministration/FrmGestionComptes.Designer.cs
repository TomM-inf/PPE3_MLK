namespace PPE3_MLK
{
    partial class FrmGestionComptes
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
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCompte = new System.Windows.Forms.Panel();
            this.lblCompte = new System.Windows.Forms.Label();
            this.radioActif = new System.Windows.Forms.RadioButton();
            this.radioInactif = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.pnlCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AllowUserToAddRows = false;
            this.dgvVisiteur.AllowUserToDeleteRows = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(13, 13);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.Size = new System.Drawing.Size(213, 326);
            this.dgvVisiteur.TabIndex = 0;
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.CurrentChanged += new System.EventHandler(this.BsVisiteur_CurrentChanged);
            // 
            // pnlCompte
            // 
            this.pnlCompte.Controls.Add(this.btnSave);
            this.pnlCompte.Controls.Add(this.radioInactif);
            this.pnlCompte.Controls.Add(this.radioActif);
            this.pnlCompte.Controls.Add(this.lblCompte);
            this.pnlCompte.Location = new System.Drawing.Point(233, 13);
            this.pnlCompte.Name = "pnlCompte";
            this.pnlCompte.Size = new System.Drawing.Size(200, 100);
            this.pnlCompte.TabIndex = 1;
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Location = new System.Drawing.Point(3, 9);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(85, 13);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Etat du compte :";
            // 
            // radioActif
            // 
            this.radioActif.AutoSize = true;
            this.radioActif.Location = new System.Drawing.Point(4, 26);
            this.radioActif.Name = "radioActif";
            this.radioActif.Size = new System.Drawing.Size(46, 17);
            this.radioActif.TabIndex = 1;
            this.radioActif.TabStop = true;
            this.radioActif.Text = "Actif";
            this.radioActif.UseVisualStyleBackColor = true;
            // 
            // radioInactif
            // 
            this.radioInactif.AutoSize = true;
            this.radioInactif.Location = new System.Drawing.Point(4, 49);
            this.radioInactif.Name = "radioInactif";
            this.radioInactif.Size = new System.Drawing.Size(54, 17);
            this.radioInactif.TabIndex = 2;
            this.radioInactif.TabStop = true;
            this.radioInactif.Text = "Inactif";
            this.radioInactif.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmGestionComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.pnlCompte);
            this.Controls.Add(this.dgvVisiteur);
            this.Name = "FrmGestionComptes";
            this.ShowIcon = false;
            this.Text = "Gestion des comptes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGestionComptes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.pnlCompte.ResumeLayout(false);
            this.pnlCompte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Panel pnlCompte;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.RadioButton radioInactif;
        private System.Windows.Forms.RadioButton radioActif;
        private System.Windows.Forms.Button btnSave;
    }
}