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
            this.menuStrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrpMain
            // 
            this.menuStrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
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
            this.informationsDuCompteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationsDuCompteToolStripMenuItem.Text = "Gestion du compte";
            this.informationsDuCompteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.informationsDuCompteToolStripMenuItem.Click += new System.EventHandler(this.InformationsDuCompteToolStripMenuItem_Click);
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
    }
}

