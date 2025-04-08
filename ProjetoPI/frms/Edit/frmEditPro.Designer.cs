namespace ProjetoPI
{
    partial class frmEditPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditPro));
            System.Windows.Forms.Label cod_proLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tamanhoLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label cod_usuLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label tipoLabel;
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_proTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.tamanhoTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.cod_usuTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            cod_proLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            tamanhoLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            cod_usuLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Pedido_notaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = null;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // cod_proLabel
            // 
            cod_proLabel.AutoSize = true;
            cod_proLabel.Location = new System.Drawing.Point(12, 40);
            cod_proLabel.Name = "cod_proLabel";
            cod_proLabel.Size = new System.Drawing.Size(43, 13);
            cod_proLabel.TabIndex = 1;
            cod_proLabel.Text = "Código:";
            // 
            // cod_proTextBox
            // 
            this.cod_proTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "cod_pro", true));
            this.cod_proTextBox.Enabled = false;
            this.cod_proTextBox.Location = new System.Drawing.Point(81, 37);
            this.cod_proTextBox.Name = "cod_proTextBox";
            this.cod_proTextBox.Size = new System.Drawing.Size(121, 20);
            this.cod_proTextBox.TabIndex = 2;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 66);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(81, 63);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // tamanhoLabel
            // 
            tamanhoLabel.AutoSize = true;
            tamanhoLabel.Location = new System.Drawing.Point(12, 92);
            tamanhoLabel.Name = "tamanhoLabel";
            tamanhoLabel.Size = new System.Drawing.Size(55, 13);
            tamanhoLabel.TabIndex = 5;
            tamanhoLabel.Text = "Tamanho:";
            // 
            // tamanhoTextBox
            // 
            this.tamanhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "tamanho", true));
            this.tamanhoTextBox.Location = new System.Drawing.Point(81, 89);
            this.tamanhoTextBox.Name = "tamanhoTextBox";
            this.tamanhoTextBox.Size = new System.Drawing.Size(121, 20);
            this.tamanhoTextBox.TabIndex = 6;
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Location = new System.Drawing.Point(12, 118);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(26, 13);
            corLabel.TabIndex = 7;
            corLabel.Text = "Cor:";
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "cor", true));
            this.corTextBox.Location = new System.Drawing.Point(81, 115);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(121, 20);
            this.corTextBox.TabIndex = 8;
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(12, 144);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 9;
            precoLabel.Text = "Preço:";
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(81, 141);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(121, 20);
            this.precoTextBox.TabIndex = 10;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(12, 170);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 11;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(81, 167);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(121, 20);
            this.marcaTextBox.TabIndex = 12;
            // 
            // cod_usuLabel
            // 
            cod_usuLabel.AutoSize = true;
            cod_usuLabel.Location = new System.Drawing.Point(12, 275);
            cod_usuLabel.Name = "cod_usuLabel";
            cod_usuLabel.Size = new System.Drawing.Size(44, 13);
            cod_usuLabel.TabIndex = 13;
            cod_usuLabel.Text = "usuário:";
            // 
            // cod_usuTextBox
            // 
            this.cod_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "cod_usu", true));
            this.cod_usuTextBox.Enabled = false;
            this.cod_usuTextBox.Location = new System.Drawing.Point(81, 272);
            this.cod_usuTextBox.Name = "cod_usuTextBox";
            this.cod_usuTextBox.Size = new System.Drawing.Size(121, 20);
            this.cod_usuTextBox.TabIndex = 14;
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(12, 222);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 15;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(81, 219);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantidadeTextBox.TabIndex = 16;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 248);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.statusComboBox.Location = new System.Drawing.Point(81, 245);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 18;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(12, 196);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 19;
            tipoLabel.Text = "Tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(81, 193);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(121, 20);
            this.tipoTextBox.TabIndex = 20;
            // 
            // frmEditPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 394);
            this.Controls.Add(cod_proLabel);
            this.Controls.Add(this.cod_proTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(tamanhoLabel);
            this.Controls.Add(this.tamanhoTextBox);
            this.Controls.Add(corLabel);
            this.Controls.Add(this.corTextBox);
            this.Controls.Add(precoLabel);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(cod_usuLabel);
            this.Controls.Add(this.cod_usuTextBox);
            this.Controls.Add(quantidadeLabel);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Name = "frmEditPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerPro";
            this.Load += new System.EventHandler(this.frmEditPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private dbServicoDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_proTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox tamanhoTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox cod_usuTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox tipoTextBox;
    }
}