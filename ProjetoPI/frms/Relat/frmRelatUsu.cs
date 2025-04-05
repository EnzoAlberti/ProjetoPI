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
    public partial class frmRelatUsu: Form
    {
        public frmRelatUsu()
        {
            InitializeComponent();
        }

        private void frmRelatUsu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.dbServicoDataSet.Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
