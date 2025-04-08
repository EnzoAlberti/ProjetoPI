namespace ProjetoPI
{
    partial class frmPesqExt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.pedido_notaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_notaTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.Pedido_notaTableAdapter();
            this.tableAdapterManager = new ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.pedido_notaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_notaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_notaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "Código Nota",
            "Código Cliente",
            "Código Usuário"});
            this.cbmFiltrar.Location = new System.Drawing.Point(66, 17);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(80, 21);
            this.cbmFiltrar.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(283, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(175, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(91, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedido_notaBindingSource
            // 
            this.pedido_notaBindingSource.DataMember = "Pedido_nota";
            this.pedido_notaBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // pedido_notaTableAdapter
            // 
            this.pedido_notaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Pedido_notaTableAdapter = this.pedido_notaTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // pedido_notaDataGridView
            // 
            this.pedido_notaDataGridView.AllowUserToAddRows = false;
            this.pedido_notaDataGridView.AllowUserToDeleteRows = false;
            this.pedido_notaDataGridView.AutoGenerateColumns = false;
            this.pedido_notaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedido_notaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pedido_notaDataGridView.DataSource = this.pedido_notaBindingSource;
            this.pedido_notaDataGridView.Location = new System.Drawing.Point(1, 45);
            this.pedido_notaDataGridView.Name = "pedido_notaDataGridView";
            this.pedido_notaDataGridView.ReadOnly = true;
            this.pedido_notaDataGridView.Size = new System.Drawing.Size(542, 405);
            this.pedido_notaDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_ped";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_ped";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_usu";
            this.dataGridViewTextBoxColumn2.HeaderText = "cod_usu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cod_cli";
            this.dataGridViewTextBoxColumn3.HeaderText = "cod_cli";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn4.HeaderText = "data";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmPesqExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 450);
            this.Controls.Add(this.pedido_notaDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesqExt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Extrato";
            this.Load += new System.EventHandler(this.frmPesqExt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_notaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedido_notaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource pedido_notaBindingSource;
        private dbServicoDataSetTableAdapters.Pedido_notaTableAdapter pedido_notaTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pedido_notaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}