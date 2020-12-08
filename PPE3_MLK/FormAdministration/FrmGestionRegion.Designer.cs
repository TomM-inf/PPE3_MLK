namespace PPE3_MLK
{
    partial class FormGestionRegion
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
            this.cboSecteur = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.pnlRegion = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblLibRegion = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.txtLib = new System.Windows.Forms.TextBox();
            this.cboResp = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlRegion.SuspendLayout();
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
            // 
            // pnlRegion
            // 
            this.pnlRegion.Controls.Add(this.btnSave);
            this.pnlRegion.Controls.Add(this.cboResp);
            this.pnlRegion.Controls.Add(this.txtLib);
            this.pnlRegion.Controls.Add(this.lblResp);
            this.pnlRegion.Controls.Add(this.lblLibRegion);
            this.pnlRegion.Location = new System.Drawing.Point(13, 71);
            this.pnlRegion.Name = "pnlRegion";
            this.pnlRegion.Size = new System.Drawing.Size(464, 262);
            this.pnlRegion.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblLibRegion
            // 
            this.lblLibRegion.AutoSize = true;
            this.lblLibRegion.Location = new System.Drawing.Point(7, 10);
            this.lblLibRegion.Name = "lblLibRegion";
            this.lblLibRegion.Size = new System.Drawing.Size(43, 13);
            this.lblLibRegion.TabIndex = 0;
            this.lblLibRegion.Text = "Libellé :";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(7, 35);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(75, 13);
            this.lblResp.TabIndex = 1;
            this.lblResp.Text = "Responsable :";
            // 
            // txtLib
            // 
            this.txtLib.Location = new System.Drawing.Point(88, 6);
            this.txtLib.Name = "txtLib";
            this.txtLib.Size = new System.Drawing.Size(121, 20);
            this.txtLib.TabIndex = 2;
            // 
            // cboResp
            // 
            this.cboResp.FormattingEnabled = true;
            this.cboResp.Location = new System.Drawing.Point(88, 32);
            this.cboResp.Name = "cboResp";
            this.cboResp.Size = new System.Drawing.Size(121, 21);
            this.cboResp.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Sauvegarde";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FormGestionRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRegion);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cboSecteur);
            this.Name = "FormGestionRegion";
            this.Text = "FormGestionRegion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGestionRegion_FormClosed);
            this.pnlRegion.ResumeLayout(false);
            this.pnlRegion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Panel pnlRegion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label lblLibRegion;
        private System.Windows.Forms.ComboBox cboResp;
        private System.Windows.Forms.TextBox txtLib;
        private System.Windows.Forms.Button btnSave;
    }
}