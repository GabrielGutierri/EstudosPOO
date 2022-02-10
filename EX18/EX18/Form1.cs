using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX18
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA: 082200014 EC3
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ContaBancaria c = new ContaPoupanca("Gabriel", 007, 1200, "001");
            //c.Deposito(400);
            //c.Saque(-300);
            //MessageBox.Show($"{c.NomeCliente} - {c.Saldo}");
        }

        private void btnCadastraCC_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCamposEssenciais();
                double limite = Convert.ToDouble(txtLimite.Text);
                CheckState talao = cbCheque.CheckState;
                bool cheque = false;
                if (talao == CheckState.Checked) {
                    cheque = true;
                }
                ContaCorrente contaCorrente = new ContaCorrente(txtNome.Text, txtNumeroConta.Text, limite, cheque);
                Auxiliar.contas.Add(contaCorrente);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void VerificaCamposEssenciais()
        {
            if (!Auxiliar.VerificaString(txtNome.Text))
                throw new Exception("Nome é obrigatório");
            if (!Auxiliar.VerificaFormatoNumero(txtNumeroConta.Text))
                throw new Exception("Número está no formato errado. 9999-9");
            if (!Auxiliar.VerificaContaExistente(txtNumeroConta.Text))
                throw new Exception("Esse número de conta já existe.");
        }

        private void btnCadastraCP_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCamposEssenciais();
                int aniversario = Convert.ToInt32(txtAniversario.Text);
                if (!Auxiliar.VerificaDiaAniversario(aniversario))
                    throw new Exception("Aniversario maior que 31 ou menor que 0.");
                if (!Auxiliar.VerificaFormatoNumero(txtCCAtrelada.Text) || Auxiliar.VerificaContaExistente(txtCCAtrelada.Text))
                    throw new Exception("Conta atrelada não existe ou foi escrita no formato errado");
                ContaPoupanca contaPoupanca = new ContaPoupanca(txtNome.Text, txtNumeroConta.Text, aniversario, txtCCAtrelada.Text);
                Auxiliar.contas.Add(contaPoupanca);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbListar.Items.Clear();
            foreach (var conta in Auxiliar.contas)
            {
                lbListar.Items.Add(conta.ToString());
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Auxiliar.VerificaContaExistente(txtNumeroAcoes.Text) || !Auxiliar.VerificaFormatoNumero(txtNumeroAcoes.Text))
                {
                    throw new Exception("Conta não existe ou foi escrita no formato errado");
                }
                ContaBancaria conta = Auxiliar.PesquisaConta(txtNumeroAcoes.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                conta.Saque(valor);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Auxiliar.VerificaContaExistente(txtNumeroAcoes.Text) || !Auxiliar.VerificaFormatoNumero(txtNumeroAcoes.Text))
                {
                    throw new Exception("Conta não existe ou foi escrita no formato errado");
                }
                ContaBancaria conta = Auxiliar.PesquisaConta(txtNumeroAcoes.Text);
                double valor = Convert.ToDouble(txtValor.Text);
                conta.Deposito(valor);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
