namespace ProjetoPI
{
    partial class frmEditFor
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
            System.Windows.Forms.Label cod_forLabel;
            System.Windows.Forms.Label nome_fantLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cod_usuLabel;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFor));
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.FornecedorTableAdapter();
            this.tableAdapterManager = new ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.fornecedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fornecedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_forTextBox = new System.Windows.Forms.TextBox();
            this.nome_fantTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.cod_usuTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            cod_forLabel = new System.Windows.Forms.Label();
            nome_fantLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cod_usuLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).BeginInit();
            this.fornecedorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_forLabel
            // 
            cod_forLabel.AutoSize = true;
            cod_forLabel.Location = new System.Drawing.Point(12, 42);
            cod_forLabel.Name = "cod_forLabel";
            cod_forLabel.Size = new System.Drawing.Size(43, 13);
            cod_forLabel.TabIndex = 1;
            cod_forLabel.Text = "Código:";
            // 
            // nome_fantLabel
            // 
            nome_fantLabel.AutoSize = true;
            nome_fantLabel.Location = new System.Drawing.Point(12, 68);
            nome_fantLabel.Name = "nome_fantLabel";
            nome_fantLabel.Size = new System.Drawing.Size(57, 13);
            nome_fantLabel.TabIndex = 3;
            nome_fantLabel.Text = "nome fant:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(12, 94);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 5;
            cnpjLabel.Text = "CNPJ:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 120);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 146);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 9;
            telefoneLabel.Text = "Telefone:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(12, 276);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(30, 13);
            ruaLabel.TabIndex = 11;
            ruaLabel.Text = "Rua:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(12, 250);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 13;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(12, 224);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 15;
            cidadeLabel.Text = "Cidade:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(12, 198);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 17;
            ufLabel.Text = "UF:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(12, 172);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 19;
            cepLabel.Text = "CEP:";
            // 
            // cod_usuLabel
            // 
            cod_usuLabel.AutoSize = true;
            cod_usuLabel.Location = new System.Drawing.Point(12, 329);
            cod_usuLabel.Name = "cod_usuLabel";
            cod_usuLabel.Size = new System.Drawing.Size(46, 13);
            cod_usuLabel.TabIndex = 21;
            cod_usuLabel.Text = "Usuário:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 302);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 23;
            statusLabel.Text = "Status:";
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Pedido_notaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // fornecedorBindingNavigator
            // 
            this.fornecedorBindingNavigator.AddNewItem = null;
            this.fornecedorBindingNavigator.BindingSource = this.fornecedorBindingSource;
            this.fornecedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedorBindingNavigatorSaveItem});
            this.fornecedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedorBindingNavigator.Name = "fornecedorBindingNavigator";
            this.fornecedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedorBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.fornecedorBindingNavigator.TabIndex = 0;
            this.fornecedorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fornecedorBindingNavigatorSaveItem
            // 
            this.fornecedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedorBindingNavigatorSaveItem.Image")));
            this.fornecedorBindingNavigatorSaveItem.Name = "fornecedorBindingNavigatorSaveItem";
            this.fornecedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecedorBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fornecedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedorBindingNavigatorSaveItem_Click);
            // 
            // cod_forTextBox
            // 
            this.cod_forTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cod_for", true));
            this.cod_forTextBox.Enabled = false;
            this.cod_forTextBox.Location = new System.Drawing.Point(75, 39);
            this.cod_forTextBox.Name = "cod_forTextBox";
            this.cod_forTextBox.Size = new System.Drawing.Size(121, 20);
            this.cod_forTextBox.TabIndex = 2;
            // 
            // nome_fantTextBox
            // 
            this.nome_fantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nome_fant", true));
            this.nome_fantTextBox.Location = new System.Drawing.Point(75, 65);
            this.nome_fantTextBox.Name = "nome_fantTextBox";
            this.nome_fantTextBox.Size = new System.Drawing.Size(121, 20);
            this.nome_fantTextBox.TabIndex = 4;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(75, 91);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(121, 20);
            this.cnpjTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(75, 117);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 8;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(75, 143);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefoneTextBox.TabIndex = 10;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "rua", true));
            this.ruaTextBox.Location = new System.Drawing.Point(75, 273);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(121, 20);
            this.ruaTextBox.TabIndex = 12;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "bairro", true));
            this.bairroTextBox.Location = new System.Drawing.Point(75, 247);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(121, 20);
            this.bairroTextBox.TabIndex = 14;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(75, 221);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(121, 20);
            this.cidadeTextBox.TabIndex = 16;
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "uf", true));
            this.ufTextBox.Location = new System.Drawing.Point(75, 195);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(121, 20);
            this.ufTextBox.TabIndex = 18;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(75, 169);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(121, 20);
            this.cepTextBox.TabIndex = 20;
            // 
            // cod_usuTextBox
            // 
            this.cod_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "cod_usu", true));
            this.cod_usuTextBox.Enabled = false;
            this.cod_usuTextBox.Location = new System.Drawing.Point(75, 326);
            this.cod_usuTextBox.Name = "cod_usuTextBox";
            this.cod_usuTextBox.Size = new System.Drawing.Size(121, 20);
            this.cod_usuTextBox.TabIndex = 22;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(75, 299);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 24;
            // 
            // frmEditFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 394);
            this.Controls.Add(cod_forLabel);
            this.Controls.Add(this.cod_forTextBox);
            this.Controls.Add(nome_fantLabel);
            this.Controls.Add(this.nome_fantTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(cod_usuLabel);
            this.Controls.Add(this.cod_usuTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.fornecedorBindingNavigator);
            this.Name = "frmEditFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGerFor";
            this.Load += new System.EventHandler(this.frmEditFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).EndInit();
            this.fornecedorBindingNavigator.ResumeLayout(false);
            this.fornecedorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private dbServicoDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_forTextBox;
        private System.Windows.Forms.TextBox nome_fantTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox cod_usuTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}