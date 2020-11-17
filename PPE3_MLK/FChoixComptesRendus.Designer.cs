namespace PPE3_MLK
{
    partial class FChoixComptesRendus
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisionner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMedecin = new System.Windows.Forms.ComboBox();
            this.dgvRapport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMois = new System.Windows.Forms.ComboBox();
            this.cboAnnee = new System.Windows.Forms.ComboBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.bsAnnee = new System.Windows.Forms.BindingSource(this.components);
            this.bsMois = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Année";
            // 
            // btnVisionner
            // 
            this.btnVisionner.Location = new System.Drawing.Point(125, 378);
            this.btnVisionner.Name = "btnVisionner";
            this.btnVisionner.Size = new System.Drawing.Size(75, 23);
            this.btnVisionner.TabIndex = 1;
            this.btnVisionner.Text = "Visionner";
            this.btnVisionner.UseVisualStyleBackColor = true;
            this.btnVisionner.Click += new System.EventHandler(this.btnVisionner_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(358, 378);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(596, 378);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 3;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.BtnCreer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medecin";
            // 
            // cboMedecin
            // 
            this.cboMedecin.DisplayMember = "adresse";
            this.cboMedecin.FormattingEnabled = true;
            this.cboMedecin.Location = new System.Drawing.Point(550, 62);
            this.cboMedecin.Name = "cboMedecin";
            this.cboMedecin.Size = new System.Drawing.Size(121, 21);
            this.cboMedecin.TabIndex = 5;
            this.cboMedecin.ValueMember = "adresse";
            this.cboMedecin.SelectedIndexChanged += new System.EventHandler(this.CboMedecin_SelectedIndexChanged);
            // 
            // dgvRapport
            // 
            this.dgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapport.Location = new System.Drawing.Point(125, 101);
            this.dgvRapport.Name = "dgvRapport";
            this.dgvRapport.Size = new System.Drawing.Size(546, 251);
            this.dgvRapport.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mois";
            // 
            // cboMois
            // 
            this.cboMois.FormattingEnabled = true;
            this.cboMois.Location = new System.Drawing.Point(348, 62);
            this.cboMois.Name = "cboMois";
            this.cboMois.Size = new System.Drawing.Size(121, 21);
            this.cboMois.TabIndex = 10;
            // 
            // cboAnnee
            // 
            this.cboAnnee.FormattingEnabled = true;
            this.cboAnnee.Location = new System.Drawing.Point(166, 62);
            this.cboAnnee.Name = "cboAnnee";
            this.cboAnnee.Size = new System.Drawing.Size(121, 21);
            this.cboAnnee.TabIndex = 11;
            // 
            // FChoixComptesRendus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboAnnee);
            this.Controls.Add(this.cboMois);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRapport);
            this.Controls.Add(this.cboMedecin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnVisionner);
            this.Controls.Add(this.label1);
            this.Name = "FChoixComptesRendus";
            this.Text = "FChoixComptesRendus";
            this.Load += new System.EventHandler(this.FChoixComptesRendus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMois)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisionner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMedecin;
        private System.Windows.Forms.DataGridView dgvRapport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMois;
        private System.Windows.Forms.ComboBox cboAnnee;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.BindingSource bsMedecin;
        private System.Windows.Forms.BindingSource bsAnnee;
        private System.Windows.Forms.BindingSource bsMois;
    }
}