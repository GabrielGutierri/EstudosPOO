using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX16
{
    public partial class Form1 : Form
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        List<Jogo> listaJogos = new List<Jogo>();
        public Form1()
        {
            InitializeComponent();
            cbFabricante.DataSource = Auxiliar.listaFabricante;
            cbFabricante.DisplayMember = "Nome";

            cbDificuldade.DataSource = Enum.GetValues(typeof(EnumDificuldade));
            cbFiltro.DataSource = Enum.GetValues(typeof(EnumDificuldade));
            cbFiltro.SelectedIndex = -1;
            if (File.Exists("jogos.txt"))
            {
                CarregaArquivo();
            }
        }

        private void CarregaArquivo()
        {
            string[] linhas = File.ReadAllLines("jogos.txt");
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split('|');
                Fabricante fabri = Auxiliar.listaFabricante.Find(f => f.Codigo == Convert.ToInt32(dados[4]));
                Jogo j = new Jogo(Convert.ToInt32(dados[0]), dados[1], (EnumDificuldade)Convert.ToInt32(dados[3]), fabri, Convert.ToDouble(dados[2]));

                listaJogos.Add(j);
            }
        }

        private void GravaEmArquivo()
        {
            string conteudo = "";
            foreach (Jogo j in listaJogos)
            {
                conteudo += j.Codigo + "|" +
                    j.Descricao + "|" +
                    j.Valor + "|" +
                    (int)j.Dificuldade + "|" +
                    j.FabricanteJogo.Codigo + Environment.NewLine;
            }
            File.WriteAllText("jogos.txt", conteudo);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliar.VerificaInt(txtCodigo.Text))
                {
                    throw new Exception("Código deve ser um número inteiro.");
                }
                if (!Auxiliar.VerificaDouble(txtValor.Text))
                    throw new Exception("Valor deve ser um double.");

                int codigo = Convert.ToInt32(txtCodigo.Text);
                double valor = Convert.ToDouble(txtValor.Text);

                Jogo novoJogo = new Jogo(codigo, txtDescricao.Text, (EnumDificuldade)cbDificuldade.SelectedIndex, Auxiliar.listaFabricante[cbFabricante.SelectedIndex], valor);
                listaJogos.Add(novoJogo);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        
        private void btnSalvartxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliar.VerificaInt(txtCodigo.Text))
                {
                    throw new Exception("Código deve ser um número inteiro.");
                }
                if (!Auxiliar.VerificaDouble(txtValor.Text))
                    throw new Exception("Valor deve ser um double.");

                Jogo j = new Jogo(Convert.ToInt32(txtCodigo.Text), txtDescricao.Text, (EnumDificuldade)cbDificuldade.SelectedIndex, cbFabricante.SelectedItem as Fabricante,  Convert.ToDouble(txtValor.Text));
               
                listaJogos.Add(j);

                GravaEmArquivo();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCarregarLista_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
            if (cbFiltro.SelectedIndex >= 0)
            {
                ListarPorFiltro(cbFiltro.SelectedIndex);
            }

            else
            {
                foreach (var jogo in listaJogos)
                {
                    lbLista.Items.Add($"{jogo.Descricao} - {jogo.Dificuldade} - {jogo.FabricanteJogo.Nome} - {jogo.Valor}");
                }
            }
            cbFiltro.SelectedIndex = -1;
        }

        private void ListarPorFiltro(int filtro)
        {
            foreach (var jogo in listaJogos)
            {
                if ((int)jogo.Dificuldade == filtro)
                    lbLista.Items.Add($"{jogo.Descricao} - {jogo.Dificuldade} - {jogo.FabricanteJogo.Nome} - {jogo.Valor}");
            }
        }

        private void btnAumentoReais_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliar.VerificaDouble(txtValorAumento.Text))
                {
                    throw new Exception("Aumento em Reais deve ser double.");
                }

                Jogo jogo = listaJogos.Find(j => j.Descricao == txtNomeAumento.Text);
                if(jogo == null)
                {
                    throw new Exception("Jogo não encontrado");
                }

                jogo.AtualizarPreco(Convert.ToDouble(txtValorAumento.Text));
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnAumentoPorcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Auxiliar.VerificaInt(txtValorAumento.Text))
                {
                    throw new Exception("Aumento em % deve ser inteiro.");
                }

                if (Convert.ToDouble(txtValorAumento.Text) > 100 || Convert.ToDouble(txtValorAumento.Text) <= 0)
                    throw new Exception("Aumento em % deve estar entre 0 e 100");

                Jogo jogo = listaJogos.Find(j => j.Descricao == txtNomeAumento.Text);
                if (jogo == null)
                {
                    throw new Exception("Jogo não encontrado");
                }

                jogo.AtualizarPreco(Convert.ToInt32(txtValorAumento.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
