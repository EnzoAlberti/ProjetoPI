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
    public partial class frmPesqFor: Form
    {
        Conection cn = new Conection();
        public frmPesqFor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmPesqFor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dbServicoDataSet.Fornecedor);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "select * from Cliente where cod_cli = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable forn = new DataTable();
                    da.Fill(forn);
                    fornecedorDataGridView.DataSource = forn;
                }
                if (cbmFiltrar.Text == "Nome")
                {
                    string sql = "select * from Cliente where nome like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable forn = new DataTable();
                    da.Fill(forn);
                    fornecedorDataGridView.DataSource = forn;
                }
            }
            catch(Exception ex)
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
