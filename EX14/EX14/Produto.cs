using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    class Produto: ICadastro
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Salvar();
        }

        public void Salvar()
        {
            string caminho = "dados.txt";
            //$"P|{this.Codigo}|{this.Nome}|{this.Preco}"
            File.AppendAllText(caminho, $"P|{this.Codigo}|{this.Nome}|{this.Preco}{Environment.NewLine}");

        }

        public bool Pesquisar(string valor)
        {
            string[] linhas = File.ReadAllLines("dados.txt");
            foreach (var linha in linhas)
            {
                string[] dadosLinha = linha.Split('|');
                if (dadosLinha[0] == "P")
                {
                    if (dadosLinha[2] == valor)
                    {
                        Codigo = Convert.ToInt32(dadosLinha[1]);
                        Nome = dadosLinha[2];
                        Preco = Convert.ToDouble(dadosLinha[3]);
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
