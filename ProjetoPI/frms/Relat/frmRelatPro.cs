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
    public partial class frmRelatPro: Form
    {
        public frmRelatPro()
        {
            InitializeComponent();
        }

        private void frmRelatPro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dbServicoDataSet.Produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
