namespace PPE3_MLK
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnMedicaments = new System.Windows.Forms.Button();
            this.btnPraticiens = new System.Windows.Forms.Button();
            this.btnVisiteurs = new System.Windows.Forms.Button();
            this.btnComptesRendus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.btnMedicaments);
            this.panel1.Controls.Add(this.btnPraticiens);
            this.panel1.Controls.Add(this.btnVisiteurs);
            this.panel1.Controls.Add(this.btnComptesRendus);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 585);
            this.panel1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuitter.Location = new System.Drawing.Point(0, 377);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 82);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnMedicaments
            // 
            this.btnMedicaments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicaments.Location = new System.Drawing.Point(0, 317);
            this.btnMedicaments.Name = "btnMedicaments";
            this.btnMedicaments.Size = new System.Drawing.Size(200, 60);
            this.btnMedicaments.TabIndex = 1;
            this.btnMedicaments.Text = "Medicaments";
            this.btnMedicaments.UseVisualStyleBackColor = true;
            // 
            // btnPraticiens
            // 
            this.btnPraticiens.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPraticiens.Location = new System.Drawing.Point(0, 246);
            this.btnPraticiens.Name = "btnPraticiens";
            this.btnPraticiens.Size = new System.Drawing.Size(200, 71);
            this.btnPraticiens.TabIndex = 4;
            this.btnPraticiens.Text = "Praticiens";
            this.btnPraticiens.UseVisualStyleBackColor = true;
            // 
            // btnVisiteurs
            // 
            this.btnVisiteurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVisiteurs.Location = new System.Drawing.Point(0, 179);
            this.btnVisiteurs.Name = "btnVisiteurs";
            this.btnVisiteurs.Size = new System.Drawing.Size(200, 67);
            this.btnVisiteurs.TabIndex = 3;
            this.btnVisiteurs.Text = "Visiteurs";
            this.btnVisiteurs.UseVisualStyleBackColor = true;
            // 
            // btnComptesRendus
            // 
            this.btnComptesRendus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComptesRendus.Location = new System.Drawing.Point(0, 103);
            this.btnComptesRendus.Name = "btnComptesRendus";
            this.btnComptesRendus.Size = new System.Drawing.Size(200, 76);
            this.btnComptesRendus.TabIndex = 2;
            this.btnComptesRendus.Text = "Comptes-Rendus";
            this.btnComptesRendus.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 103);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(215, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 561);
            this.panel2.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "GEstion des comptes rendus ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComptesRendus;
        private System.Windows.Forms.Button btnVisiteurs;
        private System.Windows.Forms.Button btnMedicaments;
        private System.Windows.Forms.Button btnPraticiens;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel2;
    }
}