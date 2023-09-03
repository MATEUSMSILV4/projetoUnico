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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadrastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leitorDeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(1170, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadrastoToolStripMenuItem
            // 
            this.cadrastoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCliente,
            this.Usuario,
            this.produtoToolStripMenuItem});
            this.cadrastoToolStripMenuItem.Name = "cadrastoToolStripMenuItem";
            this.cadrastoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cadrastoToolStripMenuItem.Text = "Cadrasto";
            // 
            // MenuCliente
            // 
            this.MenuCliente.Name = "MenuCliente";
            this.MenuCliente.Size = new System.Drawing.Size(180, 22);
            this.MenuCliente.Text = "Cliente ";
            this.MenuCliente.Click += new System.EventHandler(this.MenuCliente_Click);
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(180, 22);
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem.Text = "Produto ";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leitorDeXMLToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios ";
            // 
            // leitorDeXMLToolStripMenuItem
            // 
            this.leitorDeXMLToolStripMenuItem.Name = "leitorDeXMLToolStripMenuItem";
            this.leitorDeXMLToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.leitorDeXMLToolStripMenuItem.Text = "Leitor de XML";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telapToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.vendasToolStripMenuItem.Text = "vendas ";
            // 
            // telapToolStripMenuItem
            // 
            this.telapToolStripMenuItem.Name = "telapToolStripMenuItem";
            this.telapToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.telapToolStripMenuItem.Text = "TelaPdv";
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
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmMenu";
            this.Text = "Menu";
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
    }
}