namespace ProjetoPI
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extratoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.extratoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ediçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDeFundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbUsuario = new System.Windows.Forms.ToolStripButton();
            this.tsbCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbSobre = new System.Windows.Forms.ToolStripButton();
            this.tsbLogoff = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ediçõesToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem1,
            this.clienteToolStripMenuItem1,
            this.produtoToolStripMenuItem1,
            this.fornecedorToolStripMenuItem1,
            this.extratoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.usuárioToolStripMenuItem1_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.fornecedorToolStripMenuItem1_Click);
            // 
            // extratoToolStripMenuItem
            // 
            this.extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            this.extratoToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.extratoToolStripMenuItem.Text = "Extrato";
            this.extratoToolStripMenuItem.Click += new System.EventHandler(this.extratoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem2,
            this.clienteToolStripMenuItem2,
            this.produtoToolStripMenuItem2,
            this.fornecedorToolStripMenuItem2,
            this.extratoToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // usuárioToolStripMenuItem2
            // 
            this.usuárioToolStripMenuItem2.Name = "usuárioToolStripMenuItem2";
            this.usuárioToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.usuárioToolStripMenuItem2.Text = "Usuário";
            this.usuárioToolStripMenuItem2.Click += new System.EventHandler(this.usuárioToolStripMenuItem2_Click);
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // produtoToolStripMenuItem2
            // 
            this.produtoToolStripMenuItem2.Name = "produtoToolStripMenuItem2";
            this.produtoToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.produtoToolStripMenuItem2.Text = "Produto";
            this.produtoToolStripMenuItem2.Click += new System.EventHandler(this.produtoToolStripMenuItem2_Click);
            // 
            // fornecedorToolStripMenuItem2
            // 
            this.fornecedorToolStripMenuItem2.Name = "fornecedorToolStripMenuItem2";
            this.fornecedorToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem2.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem2.Click += new System.EventHandler(this.fornecedorToolStripMenuItem2_Click);
            // 
            // extratoToolStripMenuItem1
            // 
            this.extratoToolStripMenuItem1.Name = "extratoToolStripMenuItem1";
            this.extratoToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.extratoToolStripMenuItem1.Text = "Extrato";
            this.extratoToolStripMenuItem1.Click += new System.EventHandler(this.extratoToolStripMenuItem1_Click);
            // 
            // ediçõesToolStripMenuItem
            // 
            this.ediçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem3,
            this.clienteToolStripMenuItem3,
            this.produtoToolStripMenuItem3,
            this.fornecedorToolStripMenuItem3});
            this.ediçõesToolStripMenuItem.Name = "ediçõesToolStripMenuItem";
            this.ediçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ediçõesToolStripMenuItem.Text = "Alterações";
            // 
            // usuárioToolStripMenuItem3
            // 
            this.usuárioToolStripMenuItem3.Name = "usuárioToolStripMenuItem3";
            this.usuárioToolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.usuárioToolStripMenuItem3.Text = "Usuário";
            // 
            // clienteToolStripMenuItem3
            // 
            this.clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            this.clienteToolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.clienteToolStripMenuItem3.Text = "Cliente";
            this.clienteToolStripMenuItem3.Click += new System.EventHandler(this.clienteToolStripMenuItem3_Click);
            // 
            // produtoToolStripMenuItem3
            // 
            this.produtoToolStripMenuItem3.Name = "produtoToolStripMenuItem3";
            this.produtoToolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.produtoToolStripMenuItem3.Text = "Produto";
            // 
            // fornecedorToolStripMenuItem3
            // 
            this.fornecedorToolStripMenuItem3.Name = "fornecedorToolStripMenuItem3";
            this.fornecedorToolStripMenuItem3.Size = new System.Drawing.Size(134, 22);
            this.fornecedorToolStripMenuItem3.Text = "Fornecedor";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDeFundoToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // imagemDeFundoToolStripMenuItem
            // 
            this.imagemDeFundoToolStripMenuItem.Name = "imagemDeFundoToolStripMenuItem";
            this.imagemDeFundoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagemDeFundoToolStripMenuItem.Text = "Imagem de fundo";
            this.imagemDeFundoToolStripMenuItem.Click += new System.EventHandler(this.imagemDeFundoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuario,
            this.tsbCliente,
            this.tsbProduto,
            this.tsbSobre,
            this.tsbLogoff});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbUsuario
            // 
            this.tsbUsuario.Image = global::ProjetoPI.Properties.Resources.Users;
            this.tsbUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuario.Name = "tsbUsuario";
            this.tsbUsuario.Size = new System.Drawing.Size(56, 35);
            this.tsbUsuario.Text = "Usuários";
            this.tsbUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUsuario.Click += new System.EventHandler(this.tsbUsuario_Click);
            // 
            // tsbCliente
            // 
            this.tsbCliente.Image = global::ProjetoPI.Properties.Resources.Users;
            this.tsbCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCliente.Name = "tsbCliente";
            this.tsbCliente.Size = new System.Drawing.Size(53, 35);
            this.tsbCliente.Text = "Clientes";
            this.tsbCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCliente.Click += new System.EventHandler(this.tsbCliente_Click);
            // 
            // tsbProduto
            // 
            this.tsbProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduto.Image")));
            this.tsbProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduto.Name = "tsbProduto";
            this.tsbProduto.Size = new System.Drawing.Size(54, 35);
            this.tsbProduto.Text = "Produto";
            this.tsbProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProduto.Click += new System.EventHandler(this.tsbProduto_Click);
            // 
            // tsbSobre
            // 
            this.tsbSobre.Image = ((System.Drawing.Image)(resources.GetObject("tsbSobre.Image")));
            this.tsbSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSobre.Name = "tsbSobre";
            this.tsbSobre.Size = new System.Drawing.Size(41, 35);
            this.tsbSobre.Text = "Sobre";
            this.tsbSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSobre.Click += new System.EventHandler(this.tsbSobre_Click);
            // 
            // tsbLogoff
            // 
            this.tsbLogoff.Image = global::ProjetoPI.Properties.Resources.shutdown;
            this.tsbLogoff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogoff.Name = "tsbLogoff";
            this.tsbLogoff.Size = new System.Drawing.Size(46, 35);
            this.tsbLogoff.Text = "Logoff";
            this.tsbLogoff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogoff.Click += new System.EventHandler(this.tsbLogoff_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario,
            this.tsslIP,
            this.tsslNomePC,
            this.tsslData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 722);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(122, 19);
            this.tsslUsuario.Text = "toolStripStatusLabel1";
            // 
            // tsslIP
            // 
            this.tsslIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(122, 19);
            this.tsslIP.Text = "toolStripStatusLabel2";
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(122, 19);
            this.tsslNomePC.Text = "toolStripStatusLabel3";
            // 
            // tsslData
            // 
            this.tsslData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(122, 19);
            this.tsslData.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 746);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de vendas - Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extratoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem extratoToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbUsuario;
        private System.Windows.Forms.ToolStripButton tsbCliente;
        private System.Windows.Forms.ToolStripButton tsbProduto;
        private System.Windows.Forms.ToolStripButton tsbLogoff;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslIP;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomePC;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDeFundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbSobre;
        private System.Windows.Forms.ToolStripMenuItem ediçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem3;
    }
}