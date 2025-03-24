using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjetoPI
{
    public partial class frmPesqCli: Form
    {
        Conection cn = new Conection();
        public frmPesqCli()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmPesqCli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbServicoDataSet.Cliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código")
                {
                    string sql = "select * from Cliente where cod_cli = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql,cn.Connection);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    da.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if(cbmFiltrar.Text == "Nome")
                {
                    string sql = "select * from Cliente where nome like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    da.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
