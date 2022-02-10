using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Salvar();
        }

        public void Salvar()
        {
            string caminho = "dados.txt";
            //$"P|{this.Codigo}|{this.Nome}|{this.Preco}"
            File.AppendAllText(caminho, $"F|{this.Codigo}|{this.Nome}{Environment.NewLine}");
        }

        public bool Pesquisar(string valor)
        {
            if (File.Exists("dados.txt"))
            {
                string[] linhas = File.ReadAllLines("dados,txt");
                foreach (var linha in linhas)
                {
                    string[] dados = linha.Split('|');
                    if(dados[0]=="F" && dados[2] == valor)
                    {
                        Codigo = Convert.ToInt32(dados[1]);
                        Nome = dados[2];
                        return true;
                    }
                } 
            }
            return false;
        }
    }
}
