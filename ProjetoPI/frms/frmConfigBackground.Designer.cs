namespace ProjetoPI
{
    partial class frmConfigBackground
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCorFundo;
        private System.Windows.Forms.Button btnImagemFundo;
        private System.Windows.Forms.Button btnRestaurarPadrao;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCorFundo = new System.Windows.Forms.Button();
            this.btnImagemFundo = new System.Windows.Forms.Button();
            this.btnRestaurarPadrao = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(12, 226);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(124, 23);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCorFundo
            // 
            this.btnCorFundo.Location = new System.Drawing.Point(12, 12);
            this.btnCorFundo.Name = "btnCorFundo";
            this.btnCorFundo.Size = new System.Drawing.Size(124, 23);
            this.btnCorFundo.TabIndex = 1;
            this.btnCorFundo.Text = "Cor de Fundo";
            this.btnCorFundo.UseVisualStyleBackColor = true;
            this.btnCorFundo.Click += new System.EventHandler(this.btnCorFundo_Click);
            // 
            // btnImagemFundo
            // 
            this.btnImagemFundo.Location = new System.Drawing.Point(12, 41);
            this.btnImagemFundo.Name = "btnImagemFundo";
            this.btnImagemFundo.Size = new System.Drawing.Size(124, 23);
            this.btnImagemFundo.TabIndex = 2;
            this.btnImagemFundo.Text = "Imagem de Fundo";
            this.btnImagemFundo.UseVisualStyleBackColor = true;
            this.btnImagemFundo.Click += new System.EventHandler(this.btnImagemFundo_Click);
            // 
            // btnRestaurarPadrao
            // 
            this.btnRestaurarPadrao.Location = new System.Drawing.Point(12, 70);
            this.btnRestaurarPadrao.Name = "btnRestaurarPadrao";
            this.btnRestaurarPadrao.Size = new System.Drawing.Size(124, 23);
            this.btnRestaurarPadrao.TabIndex = 3;
            this.btnRestaurarPadrao.Text = "Restaurar Padrão";
            this.btnRestaurarPadrao.UseVisualStyleBackColor = true;
            this.btnRestaurarPadrao.Click += new System.EventHandler(this.btnRestaurarPadrao_Click);
            // 
            // frmConfigBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRestaurarPadrao);
            this.Controls.Add(this.btnImagemFundo);
            this.Controls.Add(this.btnCorFundo);
            this.Controls.Add(this.btnAplicar);
            this.Name = "frmConfigBackground";
            this.Text = "Configurar Fundo";
            this.ResumeLayout(false);

        }
    }
}
