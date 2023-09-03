namespace projetoUnico
{
    partial class FrmCadrasdocliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadrasdocliente));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblendereço = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprocura = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.frmcadrastoCliente = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLEMA = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnImage = new System.Windows.Forms.Button();
            this.imagem = new System.Windows.Forms.PictureBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.frmcadrastoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(42, 93);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 16);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "NOME:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(13, 193);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(81, 16);
            this.lblendereço.TabIndex = 3;
            this.lblendereço.Text = "ENDEREÇO:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(42, 131);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 16);
            this.lblcpf.TabIndex = 4;
            this.lblcpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(97, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 22);
            this.txtNome.TabIndex = 5;
            // 
            // txtEndereço
            // 
            this.txtEndereço.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereço.Enabled = false;
            this.txtEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereço.Location = new System.Drawing.Point(97, 193);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(286, 22);
            this.txtEndereço.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(97, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Enabled = false;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(97, 129);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(131, 22);
            this.txtCpf.TabIndex = 9;
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(96, 284);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(679, 246);
            this.Grid.TabIndex = 10;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "PROCURA:";
            // 
            // txtprocura
            // 
            this.txtprocura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprocura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprocura.Location = new System.Drawing.Point(510, 91);
            this.txtprocura.Name = "txtprocura";
            this.txtprocura.Size = new System.Drawing.Size(188, 22);
            this.txtprocura.TabIndex = 12;
            this.txtprocura.TextChanged += new System.EventHandler(this.txtprocura_TextChanged);
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(13, 161);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(78, 16);
            this.lbltelefone.TabIndex = 18;
            this.lbltelefone.Text = "TELEFONE:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(97, 161);
            this.txtTelefone.Mask = "(00) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(131, 22);
            this.txtTelefone.TabIndex = 19;
            // 
            // frmcadrastoCliente
            // 
            this.frmcadrastoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmcadrastoCliente.Controls.Add(this.pictureBox1);
            this.frmcadrastoCliente.Controls.Add(this.lblLEMA);
            this.frmcadrastoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmcadrastoCliente.Location = new System.Drawing.Point(0, 0);
            this.frmcadrastoCliente.Name = "frmcadrastoCliente";
            this.frmcadrastoCliente.Size = new System.Drawing.Size(964, 36);
            this.frmcadrastoCliente.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projetoUnico.Properties.Resources.cancel;
            this.pictureBox1.Location = new System.Drawing.Point(936, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblLEMA
            // 
            this.lblLEMA.AutoSize = true;
            this.lblLEMA.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLEMA.Location = new System.Drawing.Point(351, 3);
            this.lblLEMA.Name = "lblLEMA";
            this.lblLEMA.Size = new System.Drawing.Size(166, 29);
            this.lblLEMA.TabIndex = 0;
            this.lblLEMA.Text = "Cadrasto cliente";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete-folder.png");
            this.imageList1.Images.SetKeyName(1, "refresh.png");
            this.imageList1.Images.SetKeyName(2, "sav.png");
            this.imageList1.Images.SetKeyName(3, "cancelamento.png");
            this.imageList1.Images.SetKeyName(4, "editar-arquivo.png");
            this.imageList1.Images.SetKeyName(5, "add.png");
            this.imageList1.Images.SetKeyName(6, "adicionar-imagem.png");
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImage.ImageIndex = 6;
            this.btnImage.ImageList = this.imageList1;
            this.btnImage.Location = new System.Drawing.Point(825, 206);
            this.btnImage.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(103, 38);
            this.btnImage.TabIndex = 22;
            this.btnImage.Text = "Imagem";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // imagem
            // 
            this.imagem.BackColor = System.Drawing.Color.White;
            this.imagem.Image = global::projetoUnico.Properties.Resources.perfil2;
            this.imagem.Location = new System.Drawing.Point(811, 64);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(127, 136);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem.TabIndex = 21;
            this.imagem.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.ImageIndex = 3;
            this.btncancelar.ImageList = this.imageList1;
            this.btncancelar.Location = new System.Drawing.Point(578, 547);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btncancelar.Size = new System.Drawing.Size(115, 40);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeletar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.ImageKey = "delete-folder.png";
            this.btnDeletar.ImageList = this.imageList1;
            this.btnDeletar.Location = new System.Drawing.Point(457, 547);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(115, 40);
            this.btnDeletar.TabIndex = 16;
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
            this.btnAtualizar.Location = new System.Drawing.Point(336, 547);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(115, 40);
            this.btnAtualizar.TabIndex = 15;
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
            this.btnSalvar.ImageIndex = 2;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(215, 547);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSalvar.Size = new System.Drawing.Size(115, 40);
            this.btnSalvar.TabIndex = 14;
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
            this.btnNovo.ImageIndex = 5;
            this.btnNovo.ImageList = this.imageList1;
            this.btnNovo.Location = new System.Drawing.Point(96, 547);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnNovo.Size = new System.Drawing.Size(112, 40);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmCadrasdocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.frmcadrastoCliente);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtprocura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblnome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadrasdocliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadrasto Cliente ";
            this.Load += new System.EventHandler(this.FrmCadrasdocliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.frmcadrastoCliente.ResumeLayout(false);
            this.frmcadrastoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblendereço;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprocura;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel frmcadrastoCliente;
        private System.Windows.Forms.Label lblLEMA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ImageList imageList1;
    }
}

