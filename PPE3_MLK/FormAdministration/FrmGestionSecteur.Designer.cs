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
            ((System.ComponentModel.ISupportInitialize)(this.bsSecteur)).BeginInit();
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
            // pnlSecteur
            // 
            this.pnlSecteur.Location = new System.Drawing.Point(13, 71);
            this.pnlSecteur.Name = "pnlSecteur";
            this.pnlSecteur.Size = new System.Drawing.Size(650, 214);
            this.pnlSecteur.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsSecteur;
        private System.Windows.Forms.ComboBox cboSecteur;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Panel pnlSecteur;
    }
}