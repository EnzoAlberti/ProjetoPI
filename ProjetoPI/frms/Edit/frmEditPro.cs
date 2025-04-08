using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoPI
{
    public partial class frmEditPro: Form
    {
        public frmEditPro()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
                    throw new Exception("O nome deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(tamanhoTextBox.Text))
                    throw new Exception("O tamanho deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(corTextBox.Text))
                    throw new Exception("A cor deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(precoTextBox.Text))
                    throw new Exception("O preço deve ser preenchida.");
                if (string.IsNullOrWhiteSpace(marcaTextBox.Text))
                    throw new Exception("A marca deve ser preenchida.");
                if (string.IsNullOrWhiteSpace(tipoTextBox.Text))
                    throw new Exception("O tipo deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(quantidadeTextBox.Text))
                    throw new Exception("A quantidade deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(statusComboBox.Text))
                    throw new Exception("O status deve ser preenchido.");

                // Salvar alterações no banco de dados
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.produtoTableAdapter.Update(this.dbServicoDataSet.Produto);

                // Registrar log da edição
                string detalhes = $"Cliente editado: " +
                                  $"Nome: {nomeTextBox.Text}, " +
                                  $"Tamamnho: {tamanhoTextBox.Text}, " +
                                  $"Cor: {corTextBox.Text}, " +
                                  $"Preço: {precoTextBox.Text}, " +
                                  $"Marca: {marcaTextBox.Text}, " +
                                  $"Tipo: {tipoTextBox.Text}, " +
                                  $"Quantidade: {quantidadeTextBox.Text}, " +
                                  $"Status: {statusComboBox.Text} ";
                LogSistema.RegistrarAcao(frmLogin.SessaoUsuario.CodUsuLog.ToString(), "Edição de Produto", detalhes);
                MessageBox.Show("Edição realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
            }
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);
        }

        private void frmEditPro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.dbServicoDataSet.Produto);

        }
    }
}
