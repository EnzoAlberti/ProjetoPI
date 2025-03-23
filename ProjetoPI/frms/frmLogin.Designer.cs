﻿namespace ProjetoPI
{
    partial class frmLogin
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label senhaLabel;
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.ClienteTableAdapter();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbServicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(11, 128);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "email:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(11, 155);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(39, 13);
            senhaLabel.TabIndex = 3;
            senhaLabel.Text = "senha:";
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.PagamentoTableAdapter = null;
            this.tableAdapterManager.Pedido_notaTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoPI.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // emailComboBox
            // 
            this.emailComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email", true));
            this.emailComboBox.DataSource = this.usuarioBindingSource;
            this.emailComboBox.DisplayMember = "email";
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(51, 125);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(121, 21);
            this.emailComboBox.TabIndex = 2;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEntrar.Location = new System.Drawing.Point(231, 123);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightCoral;
            this.btnSair.Location = new System.Drawing.Point(231, 155);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.dbServicoDataSet;
            // 
            // dbServicoDataSetBindingSource
            // 
            this.dbServicoDataSetBindingSource.DataSource = this.dbServicoDataSet;
            this.dbServicoDataSetBindingSource.Position = 0;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(51, 152);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(121, 20);
            this.senhaTextBox.TabIndex = 7;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 223);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailComboBox);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private dbServicoDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private dbServicoDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource dbServicoDataSetBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}