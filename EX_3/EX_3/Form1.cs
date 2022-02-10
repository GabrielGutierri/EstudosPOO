using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_3
{
    public partial class Form1 : Form
    {
        Funcionario funcionario;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();
            try
            {
                funcionario.SetCodigo(Convert.ToInt32(txtCodigo.Text));
                funcionario.SetNome(txtNome.Text);
                funcionario.SetRG(txtRG.Text);
                funcionario.SetSalario(Convert.ToDouble( txtSalario.Text));

                MessageBox.Show("Funcionário criado!");
            }
            catch(Exception erro)
            {
                funcionario = null;
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcionario != null)
            {
                txtResumo.Text = "Resumo:" + Environment.NewLine +
                    "Código: " + funcionario.GetCodigo() + Environment.NewLine +
                    "Nome: " + funcionario.GetNome() + Environment.NewLine +
                    "RG: " + funcionario.GetRG() + Environment.NewLine +
                    "Salário: " + funcionario.GetSalario() + Environment.NewLine +
                    "INSS: " + funcionario.GetINSS() + Environment.NewLine +
                    "Salário final: " + funcionario.GetSalarioFinal();
            }
            else
                MessageBox.Show("Primeiro, crie o funcionário!!!");
        }
    }
}
