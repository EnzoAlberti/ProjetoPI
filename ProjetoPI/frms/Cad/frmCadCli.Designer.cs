namespace ProjetoPI
{
    partial class frmCadCli
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
            System.Windows.Forms.Label cod_cliLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_nascLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label status_cliLabel;
            System.Windows.Forms.Label cod_usuLabel;
            System.Windows.Forms.Label ruaLabel;
            System.Windows.Forms.Label tipo_docLabel;
            System.Windows.Forms.Label docLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCli));
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.clienteTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cod_cliTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_nascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.bairroTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.status_cliComboBox = new System.Windows.Forms.ComboBox();
            this.cod_usuTextBox = new System.Windows.Forms.TextBox();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.docTextBox = new System.Windows.Forms.TextBox();
            this.tipo_docComboBox = new System.Windows.Forms.ComboBox();
            cod_cliLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_nascLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            status_cliLabel = new System.Windows.Forms.Label();
            cod_usuLabel = new System.Windows.Forms.Label();
            ruaLabel = new System.Windows.Forms.Label();
            tipo_docLabel = new System.Windows.Forms.Label();
            docLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_cliLabel
            // 
            cod_cliLabel.AutoSize = true;
            cod_cliLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tipo_doc", true));
            cod_cliLabel.Location = new System.Drawing.Point(12, 44);
            cod_cliLabel.Name = "cod_cliLabel";
            cod_cliLabel.Size = new System.Drawing.Size(43, 13);
            cod_cliLabel.TabIndex = 1;
            cod_cliLabel.Text = "Código:";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 70);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // data_nascLabel
            // 
            data_nascLabel.AutoSize = true;
            data_nascLabel.Location = new System.Drawing.Point(3, 99);
            data_nascLabel.Name = "data_nascLabel";
            data_nascLabel.Size = new System.Drawing.Size(66, 13);
            data_nascLabel.TabIndex = 5;
            data_nascLabel.Text = "Nascimento:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 122);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 7;
            telefoneLabel.Text = "Telefone:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(12, 249);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "Cidade:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(12, 223);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(24, 13);
            ufLabel.TabIndex = 11;
            ufLabel.Text = "UF:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(12, 301);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 13;
            bairroLabel.Text = "Bairro:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(12, 197);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 15;
            cepLabel.Text = "CEP:";
            // 
            // status_cliLabel
            // 
            status_cliLabel.AutoSize = true;
            status_cliLabel.Location = new System.Drawing.Point(12, 330);
            status_cliLabel.Name = "status_cliLabel";
            status_cliLabel.Size = new System.Drawing.Size(40, 13);
            status_cliLabel.TabIndex = 17;
            status_cliLabel.Text = "Status:";
            // 
            // cod_usuLabel
            // 
            cod_usuLabel.AutoSize = true;
            cod_usuLabel.Location = new System.Drawing.Point(3, 357);
            cod_usuLabel.Name = "cod_usuLabel";
            cod_usuLabel.Size = new System.Drawing.Size(46, 13);
            cod_usuLabel.TabIndex = 19;
            cod_usuLabel.Text = "Usuario:";
            // 
            // ruaLabel
            // 
            ruaLabel.AutoSize = true;
            ruaLabel.Location = new System.Drawing.Point(12, 275);
            ruaLabel.Name = "ruaLabel";
            ruaLabel.Size = new System.Drawing.Size(30, 13);
            ruaLabel.TabIndex = 23;
            ruaLabel.Text = "Rua:";
            // 
            // tipo_docLabel
            // 
            tipo_docLabel.AutoSize = true;
            tipo_docLabel.Location = new System.Drawing.Point(3, 148);
            tipo_docLabel.Name = "tipo_docLabel";
            tipo_docLabel.Size = new System.Drawing.Size(89, 13);
            tipo_docLabel.TabIndex = 24;
            tipo_docLabel.Text = "Tipo Documento:";
            // 
            // docLabel
            // 
            docLabel.AutoSize = true;
            docLabel.Location = new System.Drawing.Point(3, 171);
            docLabel.Name = "docLabel";
            docLabel.Size = new System.Drawing.Size(65, 13);
            docLabel.TabIndex = 25;
            docLabel.Text = "Documento:";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Pedido_notaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // cod_cliTextBox
            // 
            this.cod_cliTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cod_cli", true));
            this.cod_cliTextBox.Enabled = false;
            this.cod_cliTextBox.Location = new System.Drawing.Point(75, 41);
            this.cod_cliTextBox.Name = "cod_cliTextBox";
            this.cod_cliTextBox.Size = new System.Drawing.Size(200, 20);
            this.cod_cliTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(75, 67);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // data_nascDateTimePicker
            // 
            this.data_nascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "data_nasc", true));
            this.data_nascDateTimePicker.Location = new System.Drawing.Point(75, 93);
            this.data_nascDateTimePicker.Name = "data_nascDateTimePicker";
            this.data_nascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nascDateTimePicker.TabIndex = 6;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(75, 119);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefoneTextBox.TabIndex = 8;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade", true));
            this.cidadeTextBox.Enabled = false;
            this.cidadeTextBox.Location = new System.Drawing.Point(75, 246);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 10;
            // 
            // ufTextBox
            // 
            this.ufTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "uf", true));
            this.ufTextBox.Enabled = false;
            this.ufTextBox.Location = new System.Drawing.Point(75, 220);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(200, 20);
            this.ufTextBox.TabIndex = 12;
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bairroTextBox.Enabled = false;
            this.bairroTextBox.Location = new System.Drawing.Point(75, 298);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(200, 20);
            this.bairroTextBox.TabIndex = 14;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(75, 194);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(200, 20);
            this.cepTextBox.TabIndex = 16;
            this.cepTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cepTextBox_KeyDown);
            // 
            // status_cliComboBox
            // 
            this.status_cliComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "status_cli", true));
            this.status_cliComboBox.FormattingEnabled = true;
            this.status_cliComboBox.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.status_cliComboBox.Location = new System.Drawing.Point(75, 327);
            this.status_cliComboBox.Name = "status_cliComboBox";
            this.status_cliComboBox.Size = new System.Drawing.Size(200, 21);
            this.status_cliComboBox.TabIndex = 18;
            // 
            // cod_usuTextBox
            // 
            this.cod_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cod_usu", true));
            this.cod_usuTextBox.Enabled = false;
            this.cod_usuTextBox.Location = new System.Drawing.Point(75, 354);
            this.cod_usuTextBox.Name = "cod_usuTextBox";
            this.cod_usuTextBox.Size = new System.Drawing.Size(200, 20);
            this.cod_usuTextBox.TabIndex = 20;
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "rua", true));
            this.ruaTextBox.Enabled = false;
            this.ruaTextBox.Location = new System.Drawing.Point(75, 272);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(200, 20);
            this.ruaTextBox.TabIndex = 24;
            // 
            // docTextBox
            // 
            this.docTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "doc", true));
            this.docTextBox.Location = new System.Drawing.Point(75, 168);
            this.docTextBox.Name = "docTextBox";
            this.docTextBox.Size = new System.Drawing.Size(200, 20);
            this.docTextBox.TabIndex = 26;
            // 
            // tipo_docComboBox
            // 
            this.tipo_docComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "tipo_doc", true));
            this.tipo_docComboBox.FormattingEnabled = true;
            this.tipo_docComboBox.Items.AddRange(new object[] {
            "",
            "CPF",
            "CNPJ"});
            this.tipo_docComboBox.Location = new System.Drawing.Point(98, 145);
            this.tipo_docComboBox.Name = "tipo_docComboBox";
            this.tipo_docComboBox.Size = new System.Drawing.Size(177, 21);
            this.tipo_docComboBox.TabIndex = 27;
            // 
            // frmCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 394);
            this.Controls.Add(this.tipo_docComboBox);
            this.Controls.Add(docLabel);
            this.Controls.Add(this.docTextBox);
            this.Controls.Add(tipo_docLabel);
            this.Controls.Add(cod_cliLabel);
            this.Controls.Add(this.cod_cliTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(data_nascLabel);
            this.Controls.Add(this.data_nascDateTimePicker);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufTextBox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(status_cliLabel);
            this.Controls.Add(this.status_cliComboBox);
            this.Controls.Add(cod_usuLabel);
            this.Controls.Add(this.cod_usuTextBox);
            this.Controls.Add(ruaLabel);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Name = "frmCadCli";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbServicoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cod_cliTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_nascDateTimePicker;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.TextBox bairroTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.ComboBox status_cliComboBox;
        private System.Windows.Forms.TextBox cod_usuTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.TextBox docTextBox;
        private System.Windows.Forms.ComboBox tipo_docComboBox;
    }
}