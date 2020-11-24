namespace PPE3_MLK
{
    partial class FrmFrais
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModif = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txtnom2 = new System.Windows.Forms.TextBox();
            this.txtTotalFrais = new System.Windows.Forms.TextBox();
            this.txtTotalDate = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtIdVisiteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dgvListFicheFrais = new System.Windows.Forms.DataGridView();
            this.bsFicheFrais = new System.Windows.Forms.BindingSource(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bsLigneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsFraisHorsForfait = new System.Windows.Forms.BindingSource(this.components);
            this.bsFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connecté en tant que";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Consulter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModif);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.dgvListFicheFrais);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 511);
            this.panel1.TabIndex = 4;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(96, 378);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(141, 23);
            this.btnModif.TabIndex = 3;
            this.btnModif.Text = "accepter les modifications";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv2);
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Controls.Add(this.Txtnom2);
            this.panel2.Controls.Add(this.txtTotalFrais);
            this.panel2.Controls.Add(this.txtTotalDate);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtIdVisiteur);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(289, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 488);
            this.panel2.TabIndex = 2;
            // 
            // Txtnom2
            // 
            this.Txtnom2.Location = new System.Drawing.Point(287, 36);
            this.Txtnom2.Name = "Txtnom2";
            this.Txtnom2.ReadOnly = true;
            this.Txtnom2.Size = new System.Drawing.Size(100, 20);
            this.Txtnom2.TabIndex = 10;
            // 
            // txtTotalFrais
            // 
            this.txtTotalFrais.Location = new System.Drawing.Point(364, 453);
            this.txtTotalFrais.Name = "txtTotalFrais";
            this.txtTotalFrais.ReadOnly = true;
            this.txtTotalFrais.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFrais.TabIndex = 8;
            // 
            // txtTotalDate
            // 
            this.txtTotalDate.Location = new System.Drawing.Point(258, 453);
            this.txtTotalDate.Name = "txtTotalDate";
            this.txtTotalDate.ReadOnly = true;
            this.txtTotalDate.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDate.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(132, 62);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 4;
            this.txtDate.TextChanged += new System.EventHandler(this.Txt2_TextChanged);
            // 
            // txtIdVisiteur
            // 
            this.txtIdVisiteur.Location = new System.Drawing.Point(132, 36);
            this.txtIdVisiteur.Name = "txtIdVisiteur";
            this.txtIdVisiteur.ReadOnly = true;
            this.txtIdVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtIdVisiteur.TabIndex = 3;
            this.txtIdVisiteur.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mois";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Visiteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "REMBOURSEMENT DE FRAIS ENGAGES";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(15, 378);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // dgvListFicheFrais
            // 
            this.dgvListFicheFrais.AllowUserToAddRows = false;
            this.dgvListFicheFrais.AllowUserToDeleteRows = false;
            this.dgvListFicheFrais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFicheFrais.Location = new System.Drawing.Point(15, 12);
            this.dgvListFicheFrais.Name = "dgvListFicheFrais";
            this.dgvListFicheFrais.ReadOnly = true;
            this.dgvListFicheFrais.Size = new System.Drawing.Size(245, 360);
            this.dgvListFicheFrais.TabIndex = 0;
            // 
            // bsFicheFrais
            // 
            this.bsFicheFrais.CurrentChanged += new System.EventHandler(this.BsFicheFrais_CurrentChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(148, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(151, 20);
            this.textBox5.TabIndex = 5;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(27, 105);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(407, 152);
            this.dgv1.TabIndex = 4;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(27, 274);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(407, 150);
            this.dgv2.TabIndex = 11;
            // 
            // FrmFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Name = "FrmFrais";
            this.Text = "FrmFrais";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFicheFrais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLigneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisHorsForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsFicheFrais;
        private System.Windows.Forms.DataGridView dgvListFicheFrais;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdVisiteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTotalFrais;
        private System.Windows.Forms.TextBox txtTotalDate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.BindingSource bsLigneFraisForfait;
        private System.Windows.Forms.BindingSource bsFraisHorsForfait;
        private System.Windows.Forms.TextBox Txtnom2;
        private System.Windows.Forms.BindingSource bsFraisForfait;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
    }
}