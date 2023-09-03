namespace projetoUnico
{
    partial class FrmLogin
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntar = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(88, 146);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(156, 25);
            this.txtnome.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(88, 187);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(156, 25);
            this.txtSenha.TabIndex = 1;
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(39, 146);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(45, 18);
            this.LblLogin.TabIndex = 2;
            this.LblLogin.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btnEntar
            // 
            this.btnEntar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntar.Location = new System.Drawing.Point(88, 220);
            this.btnEntar.Margin = new System.Windows.Forms.Padding(1);
            this.btnEntar.Name = "btnEntar";
            this.btnEntar.Size = new System.Drawing.Size(75, 32);
            this.btnEntar.TabIndex = 4;
            this.btnEntar.Text = "ENTRAR";
            this.btnEntar.UseVisualStyleBackColor = true;
            this.btnEntar.Click += new System.EventHandler(this.btnEntar_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Location = new System.Drawing.Point(169, 220);
            this.btnCANCELAR.Margin = new System.Windows.Forms.Padding(1);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(75, 32);
            this.btnCANCELAR.TabIndex = 5;
            this.btnCANCELAR.Text = "CANCELAR";
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::projetoUnico.Properties.Resources.silhueta_de_multiplos_usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(102, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(287, 283);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnEntar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntar;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}