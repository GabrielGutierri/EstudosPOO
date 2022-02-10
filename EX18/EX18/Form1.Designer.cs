namespace EX18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCheque = new System.Windows.Forms.CheckBox();
            this.btnCadastraCC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastraCP = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNumeroConta = new System.Windows.Forms.TextBox();
            this.txtAniversario = new System.Windows.Forms.TextBox();
            this.txtCCAtrelada = new System.Windows.Forms.TextBox();
            this.lbListar = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNumeroAcoes = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLimite);
            this.groupBox1.Controls.Add(this.btnCadastraCC);
            this.groupBox1.Controls.Add(this.cbCheque);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta Corrente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCCAtrelada);
            this.groupBox2.Controls.Add(this.txtAniversario);
            this.groupBox2.Controls.Add(this.btnCadastraCP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(310, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta Poupança";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número da conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite cartão de crédito:";
            // 
            // cbCheque
            // 
            this.cbCheque.AutoSize = true;
            this.cbCheque.Location = new System.Drawing.Point(70, 62);
            this.cbCheque.Name = "cbCheque";
            this.cbCheque.Size = new System.Drawing.Size(140, 17);
            this.cbCheque.TabIndex = 4;
            this.cbCheque.Text = "Utiliza talão de cheque?";
            this.cbCheque.UseVisualStyleBackColor = true;
            // 
            // btnCadastraCC
            // 
            this.btnCadastraCC.Location = new System.Drawing.Point(51, 113);
            this.btnCadastraCC.Name = "btnCadastraCC";
            this.btnCadastraCC.Size = new System.Drawing.Size(181, 26);
            this.btnCadastraCC.TabIndex = 5;
            this.btnCadastraCC.Text = "Cadastrar conta corrente";
            this.btnCadastraCC.UseVisualStyleBackColor = true;
            this.btnCadastraCC.Click += new System.EventHandler(this.btnCadastraCC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dia do aniversário: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Conta corrente atrelada: ";
            // 
            // btnCadastraCP
            // 
            this.btnCadastraCP.Location = new System.Drawing.Point(84, 113);
            this.btnCadastraCP.Name = "btnCadastraCP";
            this.btnCadastraCP.Size = new System.Drawing.Size(181, 26);
            this.btnCadastraCP.TabIndex = 6;
            this.btnCadastraCP.Text = "Cadastrar conta poupança";
            this.btnCadastraCP.UseVisualStyleBackColor = true;
            this.btnCadastraCP.Click += new System.EventHandler(this.btnCadastraCP_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtNumeroConta
            // 
            this.txtNumeroConta.Location = new System.Drawing.Point(405, 10);
            this.txtNumeroConta.Name = "txtNumeroConta";
            this.txtNumeroConta.Size = new System.Drawing.Size(219, 20);
            this.txtNumeroConta.TabIndex = 5;
            // 
            // txtAniversario
            // 
            this.txtAniversario.Location = new System.Drawing.Point(136, 35);
            this.txtAniversario.Name = "txtAniversario";
            this.txtAniversario.Size = new System.Drawing.Size(178, 20);
            this.txtAniversario.TabIndex = 7;
            // 
            // txtCCAtrelada
            // 
            this.txtCCAtrelada.Location = new System.Drawing.Point(136, 63);
            this.txtCCAtrelada.Name = "txtCCAtrelada";
            this.txtCCAtrelada.Size = new System.Drawing.Size(178, 20);
            this.txtCCAtrelada.TabIndex = 8;
            // 
            // lbListar
            // 
            this.lbListar.FormattingEnabled = true;
            this.lbListar.Location = new System.Drawing.Point(12, 228);
            this.lbListar.Name = "lbListar";
            this.lbListar.Size = new System.Drawing.Size(624, 121);
            this.lbListar.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(12, 200);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(148, 22);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDepositar);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.txtNumeroAcoes);
            this.groupBox3.Controls.Add(this.btnSacar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(642, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 145);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ações";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(109, 63);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(178, 20);
            this.txtValor.TabIndex = 8;
            // 
            // txtNumeroAcoes
            // 
            this.txtNumeroAcoes.Location = new System.Drawing.Point(109, 37);
            this.txtNumeroAcoes.Name = "txtNumeroAcoes";
            this.txtNumeroAcoes.Size = new System.Drawing.Size(178, 20);
            this.txtNumeroAcoes.TabIndex = 7;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(8, 113);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(77, 26);
            this.btnSacar.TabIndex = 6;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Número da conta: ";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(210, 113);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(77, 26);
            this.btnDepositar.TabIndex = 9;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(132, 31);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(154, 20);
            this.txtLimite.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 352);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lbListar);
            this.Controls.Add(this.txtNumeroConta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastraCC;
        private System.Windows.Forms.CheckBox cbCheque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCAtrelada;
        private System.Windows.Forms.TextBox txtAniversario;
        private System.Windows.Forms.Button btnCadastraCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNumeroConta;
        private System.Windows.Forms.ListBox lbListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNumeroAcoes;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimite;
    }
}

