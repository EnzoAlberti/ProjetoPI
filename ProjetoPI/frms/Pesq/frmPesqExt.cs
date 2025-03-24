using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class frmPesqExt: Form
    {
        Conection cn = new Conection();
        public frmPesqExt()
        {
            InitializeComponent();
        }

        private void pedido_notaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedido_notaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmPesqExt_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Pedido_nota'. Você pode movê-la ou removê-la conforme necessário.
            this.pedido_notaTableAdapter.Fill(this.dbServicoDataSet.Pedido_nota);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "select * from Pedido_nota where cod_ped = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ped = new DataTable();
                    da.Fill(ped);
                    pedido_notaDataGridView.DataSource = ped;
                }
                if (cbmFiltrar.Text == "Código Cliente")
                {
                    string sql = "select * from Pedido_nota where cod_cli like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ped = new DataTable();
                    da.Fill(ped);
                    pedido_notaDataGridView.DataSource = ped;
                }
                if(cbmFiltrar.Text == "Código Usuário")
                {
                    string sql = "select * from Pedido where cod_usu like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ped = new DataTable();
                    da.Fill(ped);
                    pedido_notaDataGridView.DataSource = ped;
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
