namespace PPE3_MLK.FormAdministration
{
    partial class FrmGestionSecteur
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
            this.bsSecteur = new System.Windows.Forms.BindingSource(this.components);
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.pnlSecteur = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboResp = new System.Windows.Forms.ComboBox();
            this.lblResp = new System.Windows.Forms.Label();
            this.lblLibSecteur = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.bsResponsable = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
            this.pnlSecteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSecteur
            // 
            this.cboSecteur.FormattingEnabled = true;
            this.cboSecteur.Location = new System.Drawing.Point(13, 13);
            this.cboSecteur.Name = "cboSecteur";
            this.cboSecteur.Size = new System.Drawing.Size(121, 21);
            this.cboSecteur.TabIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(13, 41);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // pnlSecteur
            // 
            this.pnlSecteur.Controls.Add(this.btnSave);
            this.pnlSecteur.Controls.Add(this.cboResp);
            this.pnlSecteur.Controls.Add(this.lblResp);
            this.pnlSecteur.Controls.Add(this.lblLibSecteur);
            this.pnlSecteur.Controls.Add(this.txtLib);
            this.pnlSecteur.Location = new System.Drawing.Point(13, 71);
            this.pnlSecteur.Name = "pnlSecteur";
            this.pnlSecteur.Size = new System.Drawing.Size(650, 214);
            this.pnlSecteur.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 63);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cboResp
            // 
            this.cboResp.FormattingEnabled = true;
            this.cboResp.Location = new System.Drawing.Point(87, 36);
            this.cboResp.Name = "cboResp";
            this.cboResp.Size = new System.Drawing.Size(121, 21);
            this.cboResp.TabIndex = 3;
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(6, 39);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(75, 13);
            this.lblResp.TabIndex = 2;
            this.lblResp.Text = "Responsable :";
            // 
            // lblLibSecteur
            // 
            this.lblLibSecteur.AutoSize = true;
            this.lblLibSecteur.Location = new System.Drawing.Point(6, 12);
            this.lblLibSecteur.Name = "lblLibSecteur";
            this.lblLibSecteur.Size = new System.Drawing.Size(43, 13);
            this.lblLibSecteur.TabIndex = 1;
            this.lblLibSecteur.Text = "Libellé :";
            // 
            // txtLib
            // 
            this.txtLib.Location = new System.Drawing.Point(87, 9);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(121, 20);
            this.txtLib.TabIndex = 0;
            // 
            // FrmGestionSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlSecteur);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cboSecteur);
            this.Name = "FrmGestionSecteur";
            this.ShowIcon = false;
            this.Text = "Gestion des secteur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGestionSecteur_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).EndInit();
            this.pnlSecteur.ResumeLayout(false);
            this.pnlSecteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResponsable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Panel pnlSecteur;
        private System.Windows.Forms.Label lblLibSecteur;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.ComboBox cboResp;
        private System.Windows.Forms.BindingSource bsResponsable;
        private System.Windows.Forms.Button btnSave;
    }
}