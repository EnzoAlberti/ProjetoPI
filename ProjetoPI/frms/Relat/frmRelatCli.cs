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
    public partial class frmRelatCli: Form
    {
        public frmRelatCli()
        {
            InitializeComponent();
        }

        private void frmRelatCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbServicoDataSet.Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
