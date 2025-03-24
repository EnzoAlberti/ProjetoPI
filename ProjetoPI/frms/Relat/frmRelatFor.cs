using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class frmRelatFor: Form
    {
        public frmRelatFor()
        {
            InitializeComponent();
        }

        private void frmRelatFor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dbServicoDataSet.Fornecedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
