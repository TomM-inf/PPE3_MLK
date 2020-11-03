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
            this.lblIntitule = new System.Windows.Forms.Label();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.bsSecteurRegion = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelection = new System.Windows.Forms.Label();
            this.cboSecReg = new System.Windows.Forms.ComboBox();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSecReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteurRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSecReg
            // 
            this.pnlSecReg.Controls.Add(this.cboSecReg);
            this.pnlSecReg.Controls.Add(this.lblSelection);
            this.pnlSecReg.Controls.Add(this.dgvVisiteur);
            this.pnlSecReg.Controls.Add(this.lblIntitule);
            this.pnlSecReg.Location = new System.Drawing.Point(13, 13);
            this.pnlSecReg.Name = "pnlSecReg";
            this.pnlSecReg.Size = new System.Drawing.Size(775, 425);
            this.pnlSecReg.TabIndex = 0;
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(3, 53);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(35, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "label1";
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AllowUserToAddRows = false;
            this.dgvVisiteur.AllowUserToDeleteRows = false;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteur.Location = new System.Drawing.Point(7, 69);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            this.dgvVisiteur.Size = new System.Drawing.Size(316, 353);
            this.dgvVisiteur.TabIndex = 1;
            // 
            // bsSecteurRegion
            // 
            this.bsSecteurRegion.CurrentChanged += new System.EventHandler(this.BsSecteurRegion_CurrentChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(4, 4);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(35, 13);
            this.lblSelection.TabIndex = 2;
            this.lblSelection.Text = "label1";
            // 
            // cboSecReg
            // 
            this.cboSecReg.FormattingEnabled = true;
            this.cboSecReg.Location = new System.Drawing.Point(7, 20);
            this.cboSecReg.Name = "cboSecReg";
            this.cboSecReg.Size = new System.Drawing.Size(121, 21);
            this.cboSecReg.TabIndex = 3;
            // 
            // frmListeVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSecReg);
            this.Name = "frmListeVisiteur";
            this.ShowIcon = false;
            this.Text = "Liste des visiteurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListeVisiteur_FormClosed);
            this.pnlSecReg.ResumeLayout(false);
            this.pnlSecReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteurRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSecReg;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.BindingSource bsSecteurRegion;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cboSecReg;
        private System.Windows.Forms.BindingSource bsVisiteur;
    }
}