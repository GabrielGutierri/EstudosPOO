namespace EX09
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(30, 93);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 2;
            this.lblRG.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salário:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(68, 90);
            this.maskedTextBox1.Mask = "00.000.000-0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(151, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(68, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(68, 131);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(151, 20);
            this.txtSalario.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(80, 172);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 23);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(267, 13);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(220, 138);
            this.txtResultados.TabIndex = 11;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 203);
            this.Controls.Add(this.txtResultados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtResultados;
    }
}

