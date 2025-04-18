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
    public partial class frmEmissao: Form
    {
        Conection cn = new Conection();
        public frmEmissao()
        {
            InitializeComponent();
            txtVendedor.Text = frmLogin.SessaoUsuario.CodUsuLog.ToString();
            txtVendedor.Enabled = false;
            lblParcela.Visible = false;
            cbmParcela.Visible = false;
            CarregarClientes();
            CarregarProdutos();
        }
        public void CarregarProdutos()
        {
            DataTable produtosAtivos = new DataTable();
            List<string> produtosParaInativar = new List<string>();

            try
            {
                cn.Open();
                string query = "SELECT nome, quantidade FROM Produto WHERE status = 'Ativo'";
                using (SqlCommand cmd = new SqlCommand(query, cn.Connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(produtosAtivos);
                }

                foreach (DataRow row in produtosAtivos.Rows)
                {
                    string nomeProduto = row["Nome"].ToString();
                    int quantidadeEstoque = Convert.ToInt32(row["Quantidade"]);

                    if (quantidadeEstoque > 0)
                    {
                        cbmProduto.Items.Add(nomeProduto);
                    }
                    else
                    {
                        produtosParaInativar.Add(nomeProduto);
                    }
                }

                // Agora inative os produtos fora de estoque
                foreach (string produto in produtosParaInativar)
                {
                    InativarProduto(produto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void InativarProduto(string nomeProduto)
        {
            try
            {
                cn.Open();
                string updateQuery = "update Produto set status = 'Inativo' where nome = @NomeProduto";
                using (SqlCommand cmd = new SqlCommand(updateQuery, cn.Connection))
                {
                    cmd.Parameters.AddWithValue("@NomeProduto", nomeProduto);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inativar produto: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        public void CarregarClientes()
        {
            try
            {
                cn.Open();
                string query = "select Cod_cli, nome from Cliente";
                using (SqlCommand cmd = new SqlCommand(query, cn.Connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbmClientes.Items.Add(new KeyValuePair<int, string>(
                                reader.GetInt32(0), //Cod_cli
                                reader.GetString(1) //nome
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
            cbmClientes.DisplayMember = "Value"; // Nome do cliente
            cbmClientes.ValueMember = "Key"; // Cod_cli
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string vendedor = txtVendedor.Text;
            string tipoPagamento = cbmTipoPagamento.SelectedItem?.ToString();
            int parcelas = 0;

            // Capturar o valor da parcela selecionada
            if (cbmParcela.Visible && int.TryParse(cbmParcela.SelectedItem?.ToString(), out int parcelaSelecionada))
            {
                parcelas = parcelaSelecionada;
            }

            int codPedido;
            decimal valorTotal = 0;

            if ((txtVendedor.Text != "") && (cbmClientes.Text != "") && (cbmTipoPagamento.Text != ""))
            {
                try
                {
                    cn.Open();

                    // Iniciar transação
                    using (SqlTransaction transaction = cn.Connection.BeginTransaction())
                    {
                        try
                        {
                            // Calcular o valor total
                            foreach (DataGridViewRow row in dgvItens.Rows)
                            {
                                if (row.Cells["Produto"].Value != null && row.Cells["Quantidade"].Value != null && row.Cells["PrecoUnitario"].Value != null)
                                {
                                    decimal subtotal = Convert.ToDecimal(row.Cells["Quantidade"].Value) * Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);
                                    valorTotal += subtotal;
                                }
                            }

                            // Gerar manualmente o próximo valor de cod_ped
                            string getMaxCodPedQuery = "SELECT ISNULL(MAX(Cod_ped), 0) + 1 FROM Pedido_nota";
                            using (SqlCommand cmd = new SqlCommand(getMaxCodPedQuery, cn.Connection, transaction))
                            {
                                codPedido = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // Gerar manualmente o próximo valor de cod_pag
                            int codPag = 0;
                            bool codPagGerado = false;

                            while (!codPagGerado)
                            {
                                try
                                {
                                    // Obter o próximo valor de Cod_pag
                                    string getMaxCodPagQuery = "SELECT ISNULL(MAX(Cod_pag), 0) + 1 FROM Pagamento";
                                    using (SqlCommand cmd = new SqlCommand(getMaxCodPagQuery, cn.Connection, transaction))
                                    {
                                        codPag = Convert.ToInt32(cmd.ExecuteScalar());
                                    }

                                    // Verificar se o Cod_pag já existe
                                    string verificarCodPagQuery = "SELECT COUNT(*) FROM Pagamento WHERE Cod_pag = @CodPag";
                                    using (SqlCommand cmd = new SqlCommand(verificarCodPagQuery, cn.Connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@CodPag", codPag);
                                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                                        if (count == 0)
                                        {
                                            codPagGerado = true; // Valor único encontrado
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception("Erro ao gerar um código único para Cod_pag: " + ex.Message);
                                }
                            }

                            // Inserir na tabela Pedido_nota
                            string clienteID = ((KeyValuePair<int, string>)cbmClientes.SelectedItem).Key.ToString();
                            string insertPedidoNota = @"
                                    INSERT INTO Pedido_nota (Cod_ped, Cod_usu, Cod_cli, Data, Valor)
                                    VALUES (
                                        @CodPedido,
                                        @Vendedor,
                                        @ClienteId,
                                        GETDATE(),
                                        @Valor
                                    );";

                            using (SqlCommand cmd = new SqlCommand(insertPedidoNota, cn.Connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@CodPedido", codPedido); // Valor gerado manualmente
                                cmd.Parameters.AddWithValue("@Vendedor", vendedor); // Cod_usu do vendedor logado
                                cmd.Parameters.AddWithValue("@ClienteId", clienteID); // Cod_cli do cliente selecionado
                                cmd.Parameters.AddWithValue("@Valor", valorTotal); // Valor total do pedido
                                cmd.ExecuteNonQuery();
                            }

                            // Inserir na tabela Pagamento
                            string insertPagamento = @"
                                    INSERT INTO Pagamento (Cod_pag, Cod_ped, Cod_usu, Tipo_pagamento, Data, Parcela, Valor)
                                    VALUES (
                                        @CodPag,
                                        @CodPedido,
                                        @Vendedor,
                                        @TipoPagamento,
                                        GETDATE(),
                                        @Parcela,
                                        @Valor
                                    )";
                            using (SqlCommand cmd = new SqlCommand(insertPagamento, cn.Connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@CodPag", codPag);
                                cmd.Parameters.AddWithValue("@CodPedido", codPedido);
                                cmd.Parameters.AddWithValue("@Vendedor", vendedor);
                                cmd.Parameters.AddWithValue("@TipoPagamento", tipoPagamento);
                                cmd.Parameters.AddWithValue("@Parcela", parcelas > 0 ? (object)parcelas : DBNull.Value);
                                cmd.Parameters.AddWithValue("@Valor", valorTotal);
                                cmd.ExecuteNonQuery();
                            }

                            // Atualizar a quantidade de produtos no estoque
                            foreach (DataGridViewRow row in dgvItens.Rows)
                            {
                                if (row.Cells["Produto"].Value != null && row.Cells["Quantidade"].Value != null)
                                {
                                    string produto = row.Cells["Produto"].Value.ToString();
                                    int quantidadeVendida = Convert.ToInt32(row.Cells["Quantidade"].Value);

                                    // Atualizar a quantidade no banco de dados
                                    string atualizarEstoqueQuery = @"
                                            UPDATE Produto
                                            SET Quantidade = Quantidade - @QuantidadeVendida
                                            WHERE Nome = @Produto AND Quantidade >= @QuantidadeVendida";

                                    using (SqlCommand cmd = new SqlCommand(atualizarEstoqueQuery, cn.Connection, transaction))
                                    {
                                        cmd.Parameters.AddWithValue("@QuantidadeVendida", quantidadeVendida);
                                        cmd.Parameters.AddWithValue("@Produto", produto);

                                        int rowsAffected = cmd.ExecuteNonQuery();
                                        if (rowsAffected == 0)
                                        {
                                            throw new Exception($"Estoque insuficiente para o produto: {produto}");
                                        }
                                    }
                                }
                            }

                            // Confirmar transação
                            transaction.Commit();
                            MessageBox.Show("Venda registrada com sucesso!");
                            // Limpar os campos
                            cbmProduto.Items.Clear();
                            CarregarProdutos();
                            dgvItens.Rows.Clear();
                            txtQuantidade.Clear();
                            cbmProduto.SelectedIndex = -1; // Desseleciona o produto
                        }
                        catch (Exception ex)
                        {
                            // Reverter transação em caso de erro
                            transaction.Rollback();
                            MessageBox.Show("Erro ao registrar a venda: " + ex.Message);
                            // Recarrega o cmbProduto
                            cbmProduto.Items.Clear();
                            CarregarProdutos();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
            }
        }

        private void cbmTipoPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbmTipoPagamento.SelectedItem == "Parcelado")
            {
                lblParcela.Visible = true;
                cbmParcela.Visible = true;
            }
            else
            {
                lblParcela.Visible = false;
                cbmParcela.Visible = false;
            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cbmProduto.SelectedItem != null && txtQuantidade.Text != "")
            {
                string produto = cbmProduto.SelectedItem.ToString();
                int quantidade = Convert.ToInt32(txtQuantidade.Text);
                decimal precoUnitario = 0;
                // Obter o preço unitário do produto
                try
                {
                    cn.Open();
                    string query = "SELECT preco FROM Produto WHERE Nome = @Produto";
                    using (SqlCommand cmd = new SqlCommand(query, cn.Connection))
                    {
                        cmd.Parameters.AddWithValue("@Produto", produto);
                        precoUnitario = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter preço do produto: " + ex.Message);
                }
                finally
                {
                    cn.Close();
                }
                // Adicionar o produto ao DataGridView
                dgvItens.Rows.Add(produto, quantidade, precoUnitario, quantidade * precoUnitario);
            }
            else
            {
                MessageBox.Show("Selecione um produto e insira a quantidade.");
            }
        }
    }
}
