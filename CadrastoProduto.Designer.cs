namespace projetoUnico
{
    partial class frmCadrastoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadrastoProduto));
            this.txtDescriçao = new System.Windows.Forms.TextBox();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAulaizar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.GridProduct = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescriçao
            // 
            this.txtDescriçao.Enabled = false;
            this.txtDescriçao.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriçao.Location = new System.Drawing.Point(102, 67);
            this.txtDescriçao.Name = "txtDescriçao";
            this.txtDescriçao.Size = new System.Drawing.Size(254, 21);
            this.txtDescriçao.TabIndex = 1;
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoria.Enabled = false;
            this.CmbCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Items.AddRange(new object[] {
            "Alimenticios",
            "Cosmeticos ",
            "Varejo",
            "Diversos "});
            this.CmbCategoria.Location = new System.Drawing.Point(102, 172);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(254, 23);
            this.CmbCategoria.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Blue;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.ImageIndex = 0;
            this.btnNovo.ImageList = this.imageList1;
            this.btnNovo.Location = new System.Drawing.Point(620, 254);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(99, 41);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Blue;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.ImageIndex = 4;
            this.btnSalvar.ImageList = this.imageList1;
            this.btnSalvar.Location = new System.Drawing.Point(620, 296);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 41);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAulaizar
            // 
            this.btnAulaizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulaizar.ForeColor = System.Drawing.Color.Blue;
            this.btnAulaizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAulaizar.ImageIndex = 3;
            this.btnAulaizar.ImageList = this.imageList1;
            this.btnAulaizar.Location = new System.Drawing.Point(620, 338);
            this.btnAulaizar.Name = "btnAulaizar";
            this.btnAulaizar.Size = new System.Drawing.Size(99, 40);
            this.btnAulaizar.TabIndex = 6;
            this.btnAulaizar.Text = "Atualizar";
            this.btnAulaizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAulaizar.UseVisualStyleBackColor = true;
            this.btnAulaizar.Click += new System.EventHandler(this.btnAulaizar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(620, 379);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 42);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.ImageIndex = 1;
            this.btnLimpar.ImageList = this.imageList1;
            this.btnLimpar.Location = new System.Drawing.Point(620, 422);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 40);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // GridProduct
            // 
            this.GridProduct.BackgroundColor = System.Drawing.SystemColors.Info;
            this.GridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProduct.Location = new System.Drawing.Point(102, 254);
            this.GridProduct.Name = "GridProduct";
            this.GridProduct.Size = new System.Drawing.Size(512, 239);
            this.GridProduct.TabIndex = 9;
            this.GridProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categorias ";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(102, 210);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(254, 21);
            this.txtCod.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cod";
            // 
            // txtQtd
            // 
            this.txtQtd.Enabled = false;
            this.txtQtd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(102, 142);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(170, 21);
            this.txtQtd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Qtd";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(102, 106);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(170, 20);
            this.txtValor.TabIndex = 17;
            // 
            // txtBuscas
            // 
            this.txtBuscas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscas.Location = new System.Drawing.Point(513, 64);
            this.txtBuscas.Name = "txtBuscas";
            this.txtBuscas.Size = new System.Drawing.Size(168, 21);
            this.txtBuscas.TabIndex = 18;
            this.txtBuscas.TextChanged += new System.EventHandler(this.txtBuscas_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Busca";
            // 
            // frmCadrastoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(751, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBuscas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridProduct);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAulaizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.CmbCategoria);
            this.Controls.Add(this.txtDescriçao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadrastoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadrasto Produto";
            this.Load += new System.EventHandler(this.frmCadrastoProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescriçao;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAulaizar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView GridProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.TextBox txtBuscas;
        private System.Windows.Forms.Label label7;
    }
}