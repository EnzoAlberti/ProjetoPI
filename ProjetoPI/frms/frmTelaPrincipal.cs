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
    public partial class frmTelaPrincipal: Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }
        public void ApplyBackgroundSettings()
        {
            if (Properties.Settings.Default.BackgroundColor != Color.Empty)
            {
                if (this.IsMdiContainer)
                {
                    foreach (Control ctl in this.Controls)
                    {
                        if (ctl is MdiClient)
                        {
                            ctl.BackColor = Properties.Settings.Default.BackgroundColor;
                        }
                    }
                }
                else
                {
                    this.BackColor = Properties.Settings.Default.BackgroundColor;
                }
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BackgroundImage))
            {
                this.BackgroundImage = Image.FromFile(Properties.Settings.Default.BackgroundImage);
            }
            else
            {
                this.BackgroundImage = null;
            }
        }
        public void exibefrmCadUsu()
        {
            try
            {
                frmCadUsu usuario = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCadUsu)
                    {
                        usuario = (frmCadUsu)frm;
                        break;
                    }
                }
                if (usuario == null)
                {
                    usuario = new frmCadUsu();
                    usuario.MdiParent = this;
                    usuario.Show();
                }
                usuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
        
        public void exibefrmCadCli()
        {
            try
            {
                frmCadCli cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCadCli)
                    {
                        cliente = (frmCadCli)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCadCli();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmCadPro()
        {
            try
            {
                frmCadPro pro = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCadPro)
                    {
                        pro = (frmCadPro)frm;
                        break;
                    }
                }
                if (pro == null)
                {
                    pro = new frmCadPro();
                    pro.MdiParent = this;
                    pro.Show();
                }
                pro.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmCadFor()
        {
            try
            {
                frmCadFor forn = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCadFor)
                    {
                        forn = (frmCadFor)frm;
                        break;
                    }
                }
                if (forn == null)
                {
                    forn = new frmCadFor();
                    forn.MdiParent = this;
                    forn.Show();
                }
                forn.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmPesqUsu() 
        {
            try
            {
                frmPesqUsu pesqUsu = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmPesqUsu)
                    {
                        pesqUsu = (frmPesqUsu)frm;
                        break;
                    }
                }
                if (pesqUsu == null)
                {
                    pesqUsu = new frmPesqUsu();
                    pesqUsu.MdiParent = this;
                    pesqUsu.Show();
                }
                pesqUsu.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmPesqCli()
        {
            try
            {
                frmPesqCli pesqCli = null;
                foreach(Form frm in this.MdiChildren)
                {
                    pesqCli = (frmPesqCli)frm;
                    break;
                }
                if(pesqCli == null)
                {
                    pesqCli = new frmPesqCli();
                    pesqCli.MdiParent = this;
                    pesqCli.Show();
                }
                pesqCli.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmPesqPro()
        {
            try
            {
                frmPesqPro pesqPro = null;
                foreach (Form frm in this.MdiChildren)
                {
                    pesqPro = (frmPesqPro)frm;
                    break;
                }
                if (pesqPro == null)
                {
                    pesqPro = new frmPesqPro();
                    pesqPro.MdiParent = this;
                    pesqPro.Show();
                }
                pesqPro.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmPesqFor()
        {
            try
            {
                frmPesqFor pesqFor = null;
                foreach (Form frm in this.MdiChildren)
                {
                    pesqFor = (frmPesqFor)frm;
                    break;
                }
                if (pesqFor == null)
                {
                    pesqFor = new frmPesqFor();
                    pesqFor.MdiParent = this;
                    pesqFor.Show();
                }
                pesqFor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmPesqExt()
        {
            try
            {
                frmPesqExt pesqExt = null;
                foreach (Form frm in this.MdiChildren)
                {
                    pesqExt = (frmPesqExt)frm;
                    break;
                }
                if (pesqExt == null)
                {
                    pesqExt = new frmPesqExt();
                    pesqExt.MdiParent = this;
                    pesqExt.Show();
                }
                pesqExt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmRelatCli()
        {
            try
            {
                frmRelatCli relatCli = null;
                foreach (Form frm in this.MdiChildren)
                {
                    relatCli = (frmRelatCli)frm;
                    break;
                }
                if (relatCli == null)
                {
                    relatCli = new frmRelatCli();
                    relatCli.MdiParent = this;
                    relatCli.Show();
                }
                relatCli.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmRelatUsu()
        {
            try
            {
                frmRelatUsu relatUsu = null;
                foreach (Form frm in this.MdiChildren)
                {
                    relatUsu = (frmRelatUsu)frm;
                    break;
                }
                if (relatUsu == null)
                {
                    relatUsu = new frmRelatUsu();
                    relatUsu.MdiParent = this;
                    relatUsu.Show();
                }
                relatUsu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmRelatPro()
        {
            try
            {
                frmRelatPro relatPro = null;
                foreach (Form frm in this.MdiChildren)
                {
                    relatPro = (frmRelatPro)frm;
                    break;
                }
                if (relatPro == null)
                {
                    relatPro = new frmRelatPro();
                    relatPro.MdiParent = this;
                    relatPro.Show();
                }
                relatPro.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmRelatFor()
        {
            try
            {
                frmRelatFor relatFor = null;
                foreach (Form frm in this.MdiChildren)
                {
                    relatFor = (frmRelatFor)frm;
                    break;
                }
                if (relatFor == null)
                {
                    relatFor = new frmRelatFor();
                    relatFor.MdiParent = this;
                    relatFor.Show();
                }
                relatFor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmRelatExt()
        {
            try
            {
                frmRelatExt relatExt = null;
                foreach (Form frm in this.MdiChildren)
                {
                    relatExt = (frmRelatExt)frm;
                    break;
                }
                if (relatExt == null)
                {
                    relatExt = new frmRelatExt();
                    relatExt.MdiParent = this;
                    relatExt.Show();
                }
                relatExt.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void exibefrmCadExt()
        {
            try
            {
                frmRelatExt ext = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmRelatExt)
                    {
                        ext = (frmRelatExt)frm;
                        break;
                    }
                }
                if (ext == null)
                {
                    ext = new frmRelatExt();
                    ext.MdiParent = this;
                    ext.Show();
                }
                ext.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado;
            string myHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHost;
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);
            foreach(System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tsslIP.Text = "IP: " + myIP;
            }
            ApplyBackgroundSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Now.ToString("G");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCadUsu usuario = null;
                foreach(Form frm in this.MdiChildren)
                {
                    if (frm is frmCadUsu)
                    {
                        usuario = (frmCadUsu)frm;
                        break;
                    }
                }
                if(usuario == null)
                {
                    usuario = new frmCadUsu();
                    usuario.MdiParent = this;
                    usuario.Show();
                }
                usuario.Focus();
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possível se conectar com o formulário devido ao erro: "+ex.Message,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibefrmCadCli();
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            exibefrmCadUsu();
        }

        private void tsbCliente_Click(object sender, EventArgs e)
        {
            exibefrmCadCli();
        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            exibefrmCadPro();
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibefrmCadPro();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibefrmCadFor();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibefrmPesqUsu();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibefrmPesqCli();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibefrmPesqPro();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibefrmPesqFor();
        }

        private void extratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibefrmPesqExt();
        }

        private void usuárioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            exibefrmRelatUsu();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            exibefrmRelatCli();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            exibefrmRelatPro();
        }

        private void fornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            exibefrmRelatFor();
        }

        private void extratoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibefrmRelatExt();
        }

        private void imagemDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigBackground ConfigForm = new frmConfigBackground();
            ConfigForm.ShowDialog();
        }
    }
}
