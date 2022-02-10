using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX14
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliares.VerificaNome(txtNomeProd.Text))
                {
                    throw new Exception("nome do produto obrigatório.");
                }
                int codigoConvertido = Convert.ToInt32(txtCodigoProd.Text);
                if (!Auxiliares.VerificaCodigo(codigoConvertido))
                {
                    throw new Exception("codigo do produto deve ser maior que zero.");
                }
                double precoConvertido = Convert.ToDouble(txtPrecoProd.Text);
                if (!Auxiliares.VerificaPreco(precoConvertido))
                {
                    throw new Exception("preço deve ser positivo.");
                }

                Produto novoProduto = new Produto(codigoConvertido, txtNomeProd.Text, precoConvertido);
                txtCodigoProd.Text = "";
                txtNomeProd.Text = "";
                txtPrecoProd.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos de código ou preço devem conter números.");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliares.VerificaNome(txtNomeFunc.Text))
                {
                    throw new Exception("nome do funcionário obrigatório.");
                }
                int codigoConvertido = Convert.ToInt32(txtCodigoFunc.Text);
                if (!Auxiliares.VerificaCodigo(codigoConvertido))
                {
                    throw new Exception("codigo do funcionário deve ser maior que zero.");
                }

                Funcionario novoFunc = new Funcionario(codigoConvertido, txtNomeFunc.Text);
                txtCodigoFunc.Text = "";
                txtNomeFunc.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Campo de código deve conter números.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliares.VerificaNome(txtPesquisa.Text))
                {
                    throw new Exception("campo de pesquisa obrigatório.");
                }
                Funcionario func = new Funcionario();
                Produto prod = new Produto();
                if (prod.Pesquisar(txtPesquisa.Text))
                {
                    txtCodigoProd.Text = prod.Codigo.ToString();
                    txtNomeProd.Text = prod.Nome;
                    txtPrecoProd.Text = prod.Preco.ToString();
                }

                else if(func.Pesquisar(txtPesquisa.Text))
                {
                    txtCodigoFunc.Text = func.Codigo.ToString();
                    txtNomeFunc.Text = func.Nome;
                }

                else
                {
                    txtCodigoProd.Text = "";
                    txtNomeProd.Text = "";
                    txtPrecoProd.Text = "";
                    txtCodigoFunc.Text = "";
                    txtNomeFunc.Text = "";
                    MessageBox.Show("Dado não encontrado.");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
