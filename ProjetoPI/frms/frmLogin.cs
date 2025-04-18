using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPI
{
    public partial class frmLogin: Form
    {
        public static String usuarioConectado;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString);
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }
        public void SplashScreen()
        {
            Application.Run(new frmSplash());
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            emailComboBox.SelectedItem = -1;
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbServicoDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.dbServicoDataSet.Usuario);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair?", "Aviso de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((emailComboBox.Text != "") && (senhaTextBox.Text != ""))
                {
                    SqlCommand comm = new SqlCommand("select * from Usuario where email = @usuario and " + "senha = @senha", conn);
                    comm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = emailComboBox.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                    conn.Open();
                    SqlDataReader reader = null;
                    reader = comm.ExecuteReader();
                    if (reader.Read())
                    {
                        usuarioConectado = emailComboBox.Text;
                        SessaoUsuario.CodUsuLog = (int)reader["cod_usu"];
                        LogSistema.ResgistrarLogin(usuarioConectado);
                        frmTelaPrincipal p = new frmTelaPrincipal();
                        this.Hide();
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        senhaTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios", "Aviso de segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static class SessaoUsuario
        {
            public static int CodUsuLog { get; set; }
        }
        private void senhaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if ((emailComboBox.Text != "") && (senhaTextBox.Text != ""))
                    {
                        SqlCommand comm = new SqlCommand("select * from Usuario where email = @usuario and " + "senha = @senha", conn);
                        comm.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = emailComboBox.Text;
                        comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                        conn.Open();
                        SqlDataReader reader = null;
                        reader = comm.ExecuteReader();
                        if (reader.Read())
                        {
                            usuarioConectado = emailComboBox.Text;
                            SessaoUsuario.CodUsuLog = (int)reader["cod_usu"];
                            LogSistema.ResgistrarLogin(usuarioConectado);
                            frmTelaPrincipal p = new frmTelaPrincipal();
                            this.Hide();
                            p.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            senhaTextBox.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos os campos são obrigatórios", "Aviso de segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                DialogResult result = MessageBox.Show("Deseja realmente sair?", "Aviso de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void senhaTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            senhaTextBox.UseSystemPasswordChar = true;
            senhaTextBox.Text = "";
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {            
        }

        private void emailComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                DialogResult result = MessageBox.Show("Deseja realmente sair?", "Aviso de segurança", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
            senhaTextBox.UseSystemPasswordChar = true;
            
        }

        private void senhaTextBox_Enter(object sender, EventArgs e)
        {
            senhaTextBox.Text = "";
        }
    }
}
