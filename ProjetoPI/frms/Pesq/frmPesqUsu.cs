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
    public partial class frmPesqUsu : Form
    {
        Conection cn = new Conection();
        public frmPesqUsu()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmPesqUsu_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.dbServicoDataSet.Usuario);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "select * from Usuario where cod_cli = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    usuarioDataGridView.DataSource = usuario;
                }
                if (cbmFiltrar.Text == "Nome")
                {
                    string sql = "select * from Usuario where nome like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    usuarioDataGridView.DataSource = usuario;
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
