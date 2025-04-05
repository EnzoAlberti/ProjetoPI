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
    public partial class frmConfigBackground : Form
    {
        public frmConfigBackground()
        {
            InitializeComponent();
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            SaveSettings();
            ApplySettings();
            this.Close();
        }
        private void btnCorFundo_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackgroundColor = colorDialog.Color;
            }
        }
        private void btnImagemFundo_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackgroundImage = openFileDialog.FileName;
            }
        }
        private void btnRestaurarPadrao_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            ApplySettings();
        }
        private void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
        private void ApplySettings()
        {
            var mainForm = Application.OpenForms.OfType<frmTelaPrincipal>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.ApplyBackgroundSettings();
            }
        }
    }
}
