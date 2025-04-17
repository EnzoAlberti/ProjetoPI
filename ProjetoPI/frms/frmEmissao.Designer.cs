namespace ProjetoPI
{
    partial class frmEmissao
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbmTipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTipoPag = new System.Windows.Forms.Label();
            this.lblParcela = new System.Windows.Forms.Label();
            this.cbmParcela = new System.Windows.Forms.ComboBox();
            this.cbmClientes = new System.Windows.Forms.ComboBox();
            this.cbmProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.PrecoUnitario,
            this.Subtotal});
            this.dgvItens.Location = new System.Drawing.Point(230, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(442, 439);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItens_CellValueChanged);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(62, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbmTipoPagamento
            // 
            this.cbmTipoPagamento.FormattingEnabled = true;
            this.cbmTipoPagamento.Items.AddRange(new object[] {
            "Pix",
            "Crédito",
            "Débito",
            "Parcelado"});
            this.cbmTipoPagamento.Location = new System.Drawing.Point(88, 67);
            this.cbmTipoPagamento.Name = "cbmTipoPagamento";
            this.cbmTipoPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbmTipoPagamento.TabIndex = 2;
            this.cbmTipoPagamento.SelectedIndexChanged += new System.EventHandler(this.cbmTipoPagamento_SelectedIndexChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(88, 20);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(121, 20);
            this.txtVendedor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            // 
            // lblTipoPag
            // 
            this.lblTipoPag.AutoSize = true;
            this.lblTipoPag.Location = new System.Drawing.Point(12, 68);
            this.lblTipoPag.Name = "lblTipoPag";
            this.lblTipoPag.Size = new System.Drawing.Size(64, 13);
            this.lblTipoPag.TabIndex = 7;
            this.lblTipoPag.Text = "Pagamento:";
            // 
            // lblParcela
            // 
            this.lblParcela.AutoSize = true;
            this.lblParcela.Location = new System.Drawing.Point(15, 94);
            this.lblParcela.Name = "lblParcela";
            this.lblParcela.Size = new System.Drawing.Size(46, 13);
            this.lblParcela.TabIndex = 8;
            this.lblParcela.Text = "Parcela:";
            // 
            // cbmParcela
            // 
            this.cbmParcela.FormattingEnabled = true;
            this.cbmParcela.Items.AddRange(new object[] {
            "2",
            "3"});
            this.cbmParcela.Location = new System.Drawing.Point(88, 94);
            this.cbmParcela.Name = "cbmParcela";
            this.cbmParcela.Size = new System.Drawing.Size(121, 21);
            this.cbmParcela.TabIndex = 9;
            // 
            // cbmClientes
            // 
            this.cbmClientes.FormattingEnabled = true;
            this.cbmClientes.Location = new System.Drawing.Point(88, 43);
            this.cbmClientes.Name = "cbmClientes";
            this.cbmClientes.Size = new System.Drawing.Size(121, 21);
            this.cbmClientes.TabIndex = 10;
            // 
            // cbmProduto
            // 
            this.cbmProduto.FormattingEnabled = true;
            this.cbmProduto.Location = new System.Drawing.Point(88, 147);
            this.cbmProduto.Name = "cbmProduto";
            this.cbmProduto.Size = new System.Drawing.Size(121, 21);
            this.cbmProduto.TabIndex = 11;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(15, 150);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(52, 13);
            this.lblProduto.TabIndex = 12;
            this.lblProduto.Text = "Produtos:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(143, 176);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(66, 23);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(15, 181);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 14;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(88, 178);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(49, 20);
            this.txtQuantidade.TabIndex = 15;
            // 
            // frmEmissao
            // 
            this.ClientSize = new System.Drawing.Size(672, 439);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.cbmProduto);
            this.Controls.Add(this.cbmClientes);
            this.Controls.Add(this.cbmParcela);
            this.Controls.Add(this.lblParcela);
            this.Controls.Add(this.lblTipoPag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.cbmTipoPagamento);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvItens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEmissao";
            this.Text = "Emissão de Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void dgvItens_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            // Verifica se a célula alterada é válida e está na coluna "Quantidade" ou "Preço Unitário"
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvItens.Columns["Quantidade"].Index || e.ColumnIndex == dgvItens.Columns["PrecoUnitario"].Index))
            {
                // Obtém os valores das células "Quantidade" e "Preço Unitário"
                var quantidadeCell = dgvItens.Rows[e.RowIndex].Cells["Quantidade"];
                var precoUnitarioCell = dgvItens.Rows[e.RowIndex].Cells["PrecoUnitario"];
                var subtotalCell = dgvItens.Rows[e.RowIndex].Cells["Subtotal"];

                if (decimal.TryParse(quantidadeCell.Value?.ToString(), out decimal quantidade) &&
                    decimal.TryParse(precoUnitarioCell.Value?.ToString(), out decimal precoUnitario))
                {
                    // Calcula o subtotal e atualiza a célula correspondente
                    subtotalCell.Value = quantidade * precoUnitario;
                }
                else
                {
                    // Limpa o valor do subtotal se os valores forem inválidos
                    subtotalCell.Value = null;
                }
            }
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbmTipoPagamento;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTipoPag;
        private System.Windows.Forms.Label lblParcela;
        private System.Windows.Forms.ComboBox cbmParcela;
        private System.Windows.Forms.ComboBox cbmClientes;
        private System.Windows.Forms.ComboBox cbmProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
    }
}