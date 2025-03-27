using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class frmCadFor: Form
    {
        public frmCadFor()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (nome_fantTextBox.Text == "")
                    MessageBox.Show("O nome deve ser preenchido");
                if (emailTextBox.Text == "")
                    MessageBox.Show("O email deve ser preenchido");
                if (telefoneTextBox.Text == "")
                    MessageBox.Show("O telefone deve ser preenchido");
                if (ufTextBox.Text == "")
                    MessageBox.Show("O UF deve ser preenchido");
                if (cidadeTextBox.Text == "")
                    MessageBox.Show("A cidade deve ser preenchida");
                if (ruaTextBox.Text == "")
                    MessageBox.Show("A rua deve ser preenchida");
                if (cepTextBox.Text == "")
                    MessageBox.Show("O cep deve ser preenchido");
                if (bairroTextBox.Text == "")
                    MessageBox.Show("O bairro deve ser preenchido");
                if(statusComboBox.Text == "")
                    MessageBox.Show("O status deve ser preenchido");
                else
                {
                    this.Validate();
                    this.fornecedorBindingSource.EndEdit();
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    this.fornecedorTableAdapter.Update(this.dbServicoDataSet.Fornecedor);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível savar " + "pelo seguinte motivo: " + ex.Message);
            }
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmCadFor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.dbServicoDataSet.Fornecedor);

        }
        private async Task BuscarCEP()
        {
            string cep = cepTextBox.Text.Trim().Replace("-", ""); // Remove o traço se existir

            if (cep.Length == 8)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cep}/json/";
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            dynamic dados = JsonConvert.DeserializeObject(json);

                            if (dados.erro == null) // Verifica se o CEP existe
                            {
                                ruaTextBox.Text = dados.logradouro;
                                bairroTextBox.Text = dados.bairro;
                                cidadeTextBox.Text = dados.localidade;
                                ufTextBox.Text = dados.uf;
                            }
                            else
                            {
                                MessageBox.Show("CEP não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LiberarCampos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao buscar o CEP. Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CEP inválido! Digite um CEP com 8 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LiberarCampos()
        {
            ruaTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            ufTextBox.Enabled = true;
        }
        private async void cepTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await BuscarCEP();
            }
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            cod_usuTextBox.Text = frmLogin.SessaoUsuario.CodUsuLog.ToString();
        }
    }
}
