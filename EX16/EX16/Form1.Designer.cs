namespace EX16
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.btnSalvartxt = new System.Windows.Forms.Button();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtValorAumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAumentoReais = new System.Windows.Forms.Button();
            this.btnAumentoPorcentagem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeAumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dificuldade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fabricante: ";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(79, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(137, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(79, 36);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(137, 50);
            this.txtDescricao.TabIndex = 6;
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Location = new System.Drawing.Point(79, 101);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(137, 21);
            this.cbDificuldade.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(79, 142);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(137, 20);
            this.txtValor.TabIndex = 8;
            // 
            // cbFabricante
            // 
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(81, 175);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(137, 21);
            this.cbFabricante.TabIndex = 9;
            // 
            // btnSalvartxt
            // 
            this.btnSalvartxt.Location = new System.Drawing.Point(261, 31);
            this.btnSalvartxt.Name = "btnSalvartxt";
            this.btnSalvartxt.Size = new System.Drawing.Size(135, 28);
            this.btnSalvartxt.TabIndex = 11;
            this.btnSalvartxt.Text = "Salvar";
            this.btnSalvartxt.UseVisualStyleBackColor = true;
            this.btnSalvartxt.Click += new System.EventHandler(this.btnSalvartxt_Click);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(261, 104);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(423, 147);
            this.lbLista.TabIndex = 13;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(261, 77);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(137, 21);
            this.cbFiltro.TabIndex = 14;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(404, 77);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(64, 21);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtValorAumento
            // 
            this.txtValorAumento.Location = new System.Drawing.Point(49, 6);
            this.txtValorAumento.Name = "txtValorAumento";
            this.txtValorAumento.Size = new System.Drawing.Size(137, 20);
            this.txtValorAumento.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor: ";
            // 
            // btnAumentoReais
            // 
            this.btnAumentoReais.Location = new System.Drawing.Point(9, 56);
            this.btnAumentoReais.Name = "btnAumentoReais";
            this.btnAumentoReais.Size = new System.Drawing.Size(97, 24);
            this.btnAumentoReais.TabIndex = 18;
            this.btnAumentoReais.Text = "Aumentar em R$";
            this.btnAumentoReais.UseVisualStyleBackColor = true;
            this.btnAumentoReais.Click += new System.EventHandler(this.btnAumentoReais_Click);
            // 
            // btnAumentoPorcentagem
            // 
            this.btnAumentoPorcentagem.Location = new System.Drawing.Point(111, 56);
            this.btnAumentoPorcentagem.Name = "btnAumentoPorcentagem";
            this.btnAumentoPorcentagem.Size = new System.Drawing.Size(97, 24);
            this.btnAumentoPorcentagem.TabIndex = 19;
            this.btnAumentoPorcentagem.Text = "Aumentar em %";
            this.btnAumentoPorcentagem.UseVisualStyleBackColor = true;
            this.btnAumentoPorcentagem.Click += new System.EventHandler(this.btnAumentoPorcentagem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNomeAumento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtValorAumento);
            this.panel1.Controls.Add(this.btnAumentoPorcentagem);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAumentoReais);
            this.panel1.Location = new System.Drawing.Point(474, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 92);
            this.panel1.TabIndex = 20;
            // 
            // txtNomeAumento
            // 
            this.txtNomeAumento.Location = new System.Drawing.Point(49, 30);
            this.txtNomeAumento.Name = "txtNomeAumento";
            this.txtNomeAumento.Size = new System.Drawing.Size(137, 20);
            this.txtNomeAumento.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nome: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cbFiltro);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.btnSalvartxt);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbDificuldade;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Button btnSalvartxt;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtValorAumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAumentoReais;
        private System.Windows.Forms.Button btnAumentoPorcentagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeAumento;
        private System.Windows.Forms.Label label7;
    }
}

