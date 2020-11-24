namespace PPE3_MLK
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrpMain = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsDuCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiérarchieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesSecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrpMain
            // 
            this.menuStrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.visiteursToolStripMenuItem,
            this.administationToolStripMenuItem});
            this.menuStrpMain.Location = new System.Drawing.Point(0, 0);
            this.menuStrpMain.Name = "menuStrpMain";
            this.menuStrpMain.Size = new System.Drawing.Size(800, 24);
            this.menuStrpMain.TabIndex = 0;
            this.menuStrpMain.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsDuCompteToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // informationsDuCompteToolStripMenuItem
            // 
            this.informationsDuCompteToolStripMenuItem.Name = "informationsDuCompteToolStripMenuItem";
            this.informationsDuCompteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.informationsDuCompteToolStripMenuItem.Text = "Gestion du compte";
            this.informationsDuCompteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.informationsDuCompteToolStripMenuItem.Click += new System.EventHandler(this.InformationsDuCompteToolStripMenuItem_Click);
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parSecteurToolStripMenuItem,
            this.parRegionToolStripMenuItem,
            this.hiérarchieToolStripMenuItem});
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteurs";
            // 
            // parSecteurToolStripMenuItem
            // 
            this.parSecteurToolStripMenuItem.Name = "parSecteurToolStripMenuItem";
            this.parSecteurToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.parSecteurToolStripMenuItem.Text = "Par secteur";
            this.parSecteurToolStripMenuItem.Click += new System.EventHandler(this.ParSecteurToolStripMenuItem_Click);
            // 
            // parRegionToolStripMenuItem
            // 
            this.parRegionToolStripMenuItem.Name = "parRegionToolStripMenuItem";
            this.parRegionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.parRegionToolStripMenuItem.Text = "Par region";
            this.parRegionToolStripMenuItem.Click += new System.EventHandler(this.ParRegionToolStripMenuItem_Click);
            // 
            // hiérarchieToolStripMenuItem
            // 
            this.hiérarchieToolStripMenuItem.Name = "hiérarchieToolStripMenuItem";
            this.hiérarchieToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.hiérarchieToolStripMenuItem.Text = "Hiérarchie";
            this.hiérarchieToolStripMenuItem.Click += new System.EventHandler(this.HiérarchieToolStripMenuItem_Click);
            // 
            // administationToolStripMenuItem
            // 
            this.administationToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.administationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesComptesToolStripMenuItem,
            this.gestionDesSecteursToolStripMenuItem});
            this.administationToolStripMenuItem.Name = "administationToolStripMenuItem";
            this.administationToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.administationToolStripMenuItem.Text = "Administation";
            // 
            // gestionDesComptesToolStripMenuItem
            // 
            this.gestionDesComptesToolStripMenuItem.Name = "gestionDesComptesToolStripMenuItem";
            this.gestionDesComptesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionDesComptesToolStripMenuItem.Text = "Gestion des comptes";
            this.gestionDesComptesToolStripMenuItem.Click += new System.EventHandler(this.GestionDesComptesToolStripMenuItem_Click);
            // 
            // gestionDesSecteursToolStripMenuItem
            // 
            this.gestionDesSecteursToolStripMenuItem.Name = "gestionDesSecteursToolStripMenuItem";
            this.gestionDesSecteursToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.gestionDesSecteursToolStripMenuItem.Text = "Gestion des secteurs";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrpMain);
            this.MainMenuStrip = this.menuStrpMain;
            this.Name = "FrmMenu";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.menuStrpMain.ResumeLayout(false);
            this.menuStrpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrpMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationsDuCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiérarchieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesSecteursToolStripMenuItem;
    }
}

