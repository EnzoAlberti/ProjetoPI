using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class frmGerCli : Form
    {
        public frmGerCli()
        {
            InitializeComponent();
        }

        private void frmGerCli_Load(object sender, EventArgs e)
        {
            // Carregar os dados do cliente
            this.clienteTableAdapter.Fill(this.dbServicoDataSet.Cliente);
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações básicas
                if (string.IsNullOrWhiteSpace(nomeTextBox.Text))
                    throw new Exception("O nome deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(telefoneTextBox.Text))
                    throw new Exception("O telefone deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(ufTextBox.Text))
                    throw new Exception("O UF deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(cidadeTextBox.Text))
                    throw new Exception("A cidade deve ser preenchida.");
                if (string.IsNullOrWhiteSpace(ruaTextBox.Text))
                    throw new Exception("A rua deve ser preenchida.");
                if (string.IsNullOrWhiteSpace(cepTextBox.Text))
                    throw new Exception("O CEP deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(bairroTextBox.Text))
                    throw new Exception("O bairro deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(tipo_docComboBox.Text))
                    throw new Exception("O tipo de documento deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(docTextBox.Text))
                    throw new Exception("O documento deve ser preenchido.");
                if (string.IsNullOrWhiteSpace(status_cliComboBox.Text))
                    throw new Exception("O status do cliente deve ser preenchido.");

                // Salvar alterações no banco de dados
                this.Validate();
                this.clienteBindingSource.EndEdit();
                this.clienteTableAdapter.Update(this.dbServicoDataSet.Cliente);

                // Registrar log da edição
                string detalhes = $"Cliente editado: " +
                                  $"Nome: {nomeTextBox.Text}, " +
                                  $"Telefone: {telefoneTextBox.Text}, " +
                                  $"UF: {ufTextBox.Text}, " +
                                  $"Cidade: {cidadeTextBox.Text}, " +
                                  $"Rua: {ruaTextBox.Text}, " +
                                  $"CEP: {cepTextBox.Text}, " +
                                  $"Bairro: {bairroTextBox.Text}, " +
                                  $"Tipo de Documento: {tipo_docComboBox.Text}, " +
                                  $"Documento: {docTextBox.Text}, " +
                                  $"Status: {status_cliComboBox.Text}, " +
                                  $"Data de Nascimento: {data_nascDateTimePicker.Text}";

                LogSistema.RegistrarAcao(frmLogin.SessaoUsuario.CodUsuLog.ToString(), "Edição de Cliente", detalhes);

                MessageBox.Show("Edição realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar alterações: {ex.Message}");
            }
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

        private async void cepTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await BuscarCEP();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cod_usuTextBox.Text = frmLogin.SessaoUsuario.CodUsuLog.ToString();
        }
    }
}

