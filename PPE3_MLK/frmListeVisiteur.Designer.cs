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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bsRegion = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelection = new System.Windows.Forms.Label();
            this.cboSecReg = new System.Windows.Forms.ComboBox();
            this.pnlSecReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSecReg
            // 
            this.pnlSecReg.Controls.Add(this.cboSecReg);
            this.pnlSecReg.Controls.Add(this.lblSelection);
            this.pnlSecReg.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(316, 353);
            this.dataGridView1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSecReg;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsRegion;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ComboBox cboSecReg;
    }
}