
namespace EX_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(176, 45);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(731, 233);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(178, 62);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(281, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(586, 45);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(65, 182);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(176, 45);
            this.txtRG.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "RG";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(281, 182);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(586, 45);
            this.txtSalario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário";
            // 
            // txtResumo
            // 
            this.txtResumo.Location = new System.Drawing.Point(21, 419);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(907, 176);
            this.txtResumo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Exibir dados gravados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResumo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Button button1;
    }
}

