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
    public partial class frmCadPro: Form
    {
        public frmCadPro()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nomeTextBox.Text == "")
                    MessageBox.Show("O nome deve ser preenchido");
                if (marcaTextBox.Text == "")
                    MessageBox.Show("A marca deve ser preenchida");
                if (precoTextBox.Text == "")
                    MessageBox.Show("O preço deve ser preenchido");
                if (corTextBox.Text == "")
                    MessageBox.Show("A cor deve ser preenchida");
                if (tamanhoComboBox.Text == "")
                    MessageBox.Show("O tamanho deve ser preenchido");
                if (quantidadeTextBox.Text == "")
                    MessageBox.Show("A quantidade deve ser preenchida");
                if (statusComboBox.Text == "")
                    MessageBox.Show("A quantidade deve ser preenchida");
                else
                {
                    this.Validate();
                    this.produtoBindingSource.EndEdit();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    this.produtoTableAdapter.Update(this.dbServicoDataSet.Produto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível savar " + "pelo seguinte motivo: " + ex.Message);
            }
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmCadPro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dbServicoDataSet.Produto);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cod_usuTextBox.Text = frmLogin.SessaoUsuario.CodUsuLog.ToString();
        }
    }
}
