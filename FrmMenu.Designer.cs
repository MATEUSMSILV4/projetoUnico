namespace projetoUnico
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadrastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorDeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadrastoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem,
            this.admDeInventarioToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.arquivoToolStripMenuItem.Text = "Estoque ";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inventarioToolStripMenuItem.Text = "Agendamento";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // admDeInventarioToolStripMenuItem
            // 
            this.admDeInventarioToolStripMenuItem.Name = "admDeInventarioToolStripMenuItem";
            this.admDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.admDeInventarioToolStripMenuItem.Text = "Adm de inventario";
            // 
            // cadrastoToolStripMenuItem
            // 
            this.cadrastoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.Usuario,
            this.produtoToolStripMenuItem});
            this.cadrastoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadrastoToolStripMenuItem.Name = "cadrastoToolStripMenuItem";
            this.cadrastoToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.cadrastoToolStripMenuItem.Text = "Cadastro";
            // 
            // MenuCliente
            // 
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(135, 22);
            this.MenuCliente.Text = "Cliente ";
            this.MenuCliente.Click += new System.EventHandler(this.MenuCliente_Click);
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(135, 22);
            this.Usuario.Text = "Usuário";
            this.Usuario.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.produtoToolStripMenuItem.Text = "Produto ";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leitorDeXMLToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.relatoriosToolStripMenuItem.Text = "Relatorios ";
            // 
            // leitorDeXMLToolStripMenuItem
            // 
            this.leitorDeXMLToolStripMenuItem.Name = "leitorDeXMLToolStripMenuItem";
            this.leitorDeXMLToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.leitorDeXMLToolStripMenuItem.Text = "Leitor de XML";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telapToolStripMenuItem,
            this.aReceberToolStripMenuItem});
            this.vendasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.vendasToolStripMenuItem.Text = "Pagamentos ";
            // 
            // telapToolStripMenuItem
            // 
            this.telapToolStripMenuItem.Name = "telapToolStripMenuItem";
            this.telapToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.telapToolStripMenuItem.Text = "pententes ";
            // 
            // aReceberToolStripMenuItem
            // 
            this.aReceberToolStripMenuItem.Name = "aReceberToolStripMenuItem";
            this.aReceberToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aReceberToolStripMenuItem.Text = "A receber ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.White;
            this.lblData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(0, 530);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblData.Size = new System.Drawing.Size(0, 22);
            this.lblData.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblHora.Location = new System.Drawing.Point(536, 345);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHora.Size = new System.Drawing.Size(105, 40);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.White;
            this.lbldate.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbldate.Location = new System.Drawing.Point(536, 402);
            this.lbldate.Name = "lbldate";
            this.lbldate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbldate.Size = new System.Drawing.Size(105, 40);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "label1";
            // 
            // Logo
            // 
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Image = global::projetoUnico.Properties.Resources.SIMBOLO_TRANSPARENTE;
            this.Logo.Location = new System.Drawing.Point(516, 199);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(212, 127);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.WaitOnLoad = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1170, 552);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadrastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCliente;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leitorDeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReceberToolStripMenuItem;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbldate;
    }
}