namespace PPE3_MLK
{
    partial class FrmChangementMDP
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
            this.lblMdpActu = new System.Windows.Forms.Label();
            this.txtMdpActu = new System.Windows.Forms.TextBox();
            this.lblNewMdp = new System.Windows.Forms.Label();
            this.txtNewMdp = new System.Windows.Forms.TextBox();
            this.txtNewMdp2 = new System.Windows.Forms.TextBox();
            this.lblNewMdp2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMdpActu
            // 
            this.lblMdpActu.AutoSize = true;
            this.lblMdpActu.Location = new System.Drawing.Point(13, 13);
            this.lblMdpActu.Name = "lblMdpActu";
            this.lblMdpActu.Size = new System.Drawing.Size(109, 13);
            this.lblMdpActu.TabIndex = 0;
            this.lblMdpActu.Text = "Mot de passe actuel :";
            // 
            // txtMdpActu
            // 
            this.txtMdpActu.Location = new System.Drawing.Point(171, 10);
            this.txtMdpActu.Name = "txtMdpActu";
            this.txtMdpActu.PasswordChar = '*';
            this.txtMdpActu.Size = new System.Drawing.Size(100, 20);
            this.txtMdpActu.TabIndex = 1;
            // 
            // lblNewMdp
            // 
            this.lblNewMdp.AutoSize = true;
            this.lblNewMdp.Location = new System.Drawing.Point(13, 39);
            this.lblNewMdp.Name = "lblNewMdp";
            this.lblNewMdp.Size = new System.Drawing.Size(120, 13);
            this.lblNewMdp.TabIndex = 2;
            this.lblNewMdp.Text = "Nouveau mot de passe:";
            // 
            // txtNewMdp
            // 
            this.txtNewMdp.Location = new System.Drawing.Point(171, 36);
            this.txtNewMdp.Name = "txtNewMdp";
            this.txtNewMdp.PasswordChar = '*';
            this.txtNewMdp.Size = new System.Drawing.Size(100, 20);
            this.txtNewMdp.TabIndex = 3;
            // 
            // txtNewMdp2
            // 
            this.txtNewMdp2.Location = new System.Drawing.Point(171, 62);
            this.txtNewMdp2.Name = "txtNewMdp2";
            this.txtNewMdp2.PasswordChar = '*';
            this.txtNewMdp2.Size = new System.Drawing.Size(100, 20);
            this.txtNewMdp2.TabIndex = 4;
            // 
            // lblNewMdp2
            // 
            this.lblNewMdp2.AutoSize = true;
            this.lblNewMdp2.Location = new System.Drawing.Point(13, 65);
            this.lblNewMdp2.Name = "lblNewMdp2";
            this.lblNewMdp2.Size = new System.Drawing.Size(143, 13);
            this.lblNewMdp2.TabIndex = 5;
            this.lblNewMdp2.Text = "Répétez votre mot de passe:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(90, 88);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(171, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmChangementMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 149);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNewMdp2);
            this.Controls.Add(this.txtNewMdp2);
            this.Controls.Add(this.txtNewMdp);
            this.Controls.Add(this.lblNewMdp);
            this.Controls.Add(this.txtMdpActu);
            this.Controls.Add(this.lblMdpActu);
            this.Name = "FrmChangementMDP";
            this.ShowIcon = false;
            this.Text = "Changement de mot de passe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMdpActu;
        private System.Windows.Forms.TextBox txtMdpActu;
        private System.Windows.Forms.Label lblNewMdp;
        private System.Windows.Forms.TextBox txtNewMdp;
        private System.Windows.Forms.TextBox txtNewMdp2;
        private System.Windows.Forms.Label lblNewMdp2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}