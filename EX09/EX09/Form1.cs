using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX09
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nome = txtNome.Text;
                string rg = maskedTextBox1.Text;
                double salario = Convert.ToDouble(txtSalario.Text);

                Funcionario novo = new Funcionario(codigo, nome, rg, salario);
                txtResultados.Text = $"Código: {novo.Codigo}" + Environment.NewLine + $"Nome: {novo.Nome}"
                    + Environment.NewLine + $"RG: {novo.RG}" + Environment.NewLine + $"Salário:{novo.Salario}"
                     + Environment.NewLine + $"INSS: {novo.Inss}" + Environment.NewLine + $"Salário com INSS: {novo.CalculaSalario}";
            }
            catch (FormatException fErr)
            {
                MessageBox.Show($"Dado com o formato incorreto, verifique se foi posta um entrada inválida.");
            }
            catch (Exception err)
            {
               
                MessageBox.Show(err.Message);
            }
        }
    }
}
