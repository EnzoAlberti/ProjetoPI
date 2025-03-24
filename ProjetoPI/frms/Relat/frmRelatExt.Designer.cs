namespace ProjetoPI
{
    partial class frmRelatExt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dbServicoDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbServicoDataSet = new ProjetoPI.dbServicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidonotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedido_notaTableAdapter = new ProjetoPI.dbServicoDataSetTableAdapters.Pedido_notaTableAdapter();
            this.dbServicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidonotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbServicoDataSetBindingSource1
            // 
            this.dbServicoDataSetBindingSource1.DataSource = this.dbServicoDataSet;
            this.dbServicoDataSetBindingSource1.Position = 0;
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dbServicoDataSetBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoPI.frms.Relat.Relat.RelatExt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pedidonotaBindingSource
            // 
            this.pedidonotaBindingSource.DataMember = "Pedido_nota";
            this.pedidonotaBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // pedido_notaTableAdapter
            // 
            this.pedido_notaTableAdapter.ClearBeforeFill = true;
            // 
            // dbServicoDataSetBindingSource
            // 
            this.dbServicoDataSetBindingSource.DataSource = this.dbServicoDataSet;
            this.dbServicoDataSetBindingSource.Position = 0;
            // 
            // frmRelatExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatExt";
            this.Text = "Relatório de Extrato";
            this.Load += new System.EventHandler(this.frmRelatExt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidonotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource pedidonotaBindingSource;
        private dbServicoDataSetTableAdapters.Pedido_notaTableAdapter pedido_notaTableAdapter;
        private System.Windows.Forms.BindingSource dbServicoDataSetBindingSource1;
        private System.Windows.Forms.BindingSource dbServicoDataSetBindingSource;
    }
}