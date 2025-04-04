﻿using System;
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
    public partial class frmPesqPro : Form
    {
        Conection cn = new Conection();
        public frmPesqPro()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmPesqPro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dbServicoDataSet.Produto);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "select * from Produto where cod_pro = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable produto = new DataTable();
                    da.Fill(produto);
                    produtoDataGridView.DataSource = produto;
                }
                if (cbmFiltrar.Text == "Marca")
                {
                    string sql = "select * from Produto where marca like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable produto = new DataTable();
                    da.Fill(produto);
                    produtoDataGridView.DataSource = produto;
                }
                if(cbmFiltrar.Text == "Nome")
                {
                    string sql = "select * from Produto where nome like '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn.Connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable produto = new DataTable();
                    da.Fill(produto);
                    produtoDataGridView.DataSource = produto;
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
