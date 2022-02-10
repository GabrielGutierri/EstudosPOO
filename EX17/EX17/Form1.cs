using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX17
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        List<Funcionario> funcionarios = new List<Funcionario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                FuncionarioGerente f = new FuncionarioGerente();
                PreenchePropriedadesFunc(f);
                f.BonusEmReais = Convert.ToDouble(txtBonusGerente.Text);
                f.FuncSubordinados = Convert.ToInt32(txtSubordinados.Text);
                
                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void PreenchePropriedadesFunc(Funcionario f) // todo objeto é passado por referência
        {
            f.Codigo = Convert.ToInt32(txtCodigo.Text);
            f.Nome = txtNomeFunc.Text;
            f.Salario = Convert.ToDouble(txtSalario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioPeao f = new FuncionarioPeao();
                PreenchePropriedadesFunc(f);
                f.HorasExtrasEmReais = Convert.ToDouble(txtHorasExtras.Text);

                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioVendedor f = new FuncionarioVendedor();
                PreenchePropriedadesFunc(f);
                f.MetaVendas = Convert.ToDouble(txtMeta.Text);
                f.Vendas = Convert.ToInt32(txtVendas.Text);
                f.PorcentagemVendas = Convert.ToDouble(txtPorcentagem.Text);
                funcionarios.Add(f);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtListagem.Clear();
            foreach (Funcionario f in funcionarios)
                txtListagem.Text += f.ToString() + Environment.NewLine;
        }
    }
}
