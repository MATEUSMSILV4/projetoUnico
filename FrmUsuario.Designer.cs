namespace projetoUnico
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.txtprocura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblendereço = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtAcesso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtprocura
            // 
            this.txtprocura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprocura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprocura.Location = new System.Drawing.Point(494, 123);
            this.txtprocura.Name = "txtprocura";
            this.txtprocura.Size = new System.Drawing.Size(188, 22);
            this.txtprocura.TabIndex = 30;
            this.txtprocura.Click += new System.EventHandler(this.txtprocura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "PROCURA:";
            // 
            // GridUser
            // 
            this.GridUser.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Location = new System.Drawing.Point(103, 218);
            this.GridUser.Name = "GridUser";
            this.GridUser.Size = new System.Drawing.Size(426, 258);
            this.GridUser.TabIndex = 28;
            this.GridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(103, 162);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(131, 22);
            this.txtCpf.TabIndex = 27;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(103, 190);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(131, 22);
            this.txtSenha.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(103, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 22);
            this.txtNome.TabIndex = 24;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(48, 164);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 16);
            this.lblcpf.TabIndex = 23;
            this.lblcpf.Text = "CPF:";
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(37, 196);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(48, 16);
            this.lblendereço.TabIndex = 22;
            this.lblendereço.Text = "Senha";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(48, 125);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 16);
            this.lblnome.TabIndex = 20;
            this.lblnome.Text = "NOME:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "cancelamento.png");
            this.imageList1.Images.SetKeyName(2, "delete-folder.png");
            this.imageList1.Images.SetKeyName(3, "editar-arquivo.png");
            this.imageList1.Images.SetKeyName(4, "sav.png");
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.ImageKey = "cancelamento.png";
            this.btnLimpar.ImageList = this.imageList1;
            this.btnLimpar.Location = new System.Drawing.Point(544, 436);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLimpar.Size = new System.Drawing.Size(108, 40);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.ImageKey = "delete-folder.png";
            this.btnDeletar.ImageList = this.imageList1;
            this.btnDeletar.Location = new System.Drawing.Point(544, 390);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(108, 40);
            this.btnDeletar.TabIndex = 34;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.ImageKey = "editar-arquivo.png";
            this.btnAtualizar.ImageList = this.imageList1;
            this.btnAtualizar.Location = new System.Drawing.Point(544, 338);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(108, 40);
            this.btnAtualizar.TabIndex = 33;
            this.btnAtualizar.Text = "EDITAR";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageIndex = 4;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(544, 278);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSalvar.Size = new System.Drawing.Size(108, 40);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.imageList1;
            this.btnNovo.Location = new System.Drawing.Point(544, 218);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNovo.Size = new System.Drawing.Size(108, 40);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtAcesso
            // 
            this.txtAcesso.Enabled = false;
            this.txtAcesso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcesso.FormattingEnabled = true;
            this.txtAcesso.Items.AddRange(new object[] {
            "Administrador",
            "Pleno",
            "Junior"});
            this.txtAcesso.Location = new System.Drawing.Point(494, 164);
            this.txtAcesso.Name = "txtAcesso";
            this.txtAcesso.Size = new System.Drawing.Size(186, 23);
            this.txtAcesso.TabIndex = 37;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(692, 488);
            this.Controls.Add(this.txtAcesso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtprocura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridUser);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.lblnome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtprocura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox txtAcesso;
    }
}