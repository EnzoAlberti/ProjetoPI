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
    public partial class frmRelatExt: Form
    {
        public frmRelatExt()
        {
            InitializeComponent();
        }

        private void frmRelatExt_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Pedido_nota'. Você pode movê-la ou removê-la conforme necessário.
            this.pedido_notaTableAdapter.Fill(this.dbServicoDataSet.Pedido_nota);

            this.reportViewer1.RefreshReport();
        }
    }
}
