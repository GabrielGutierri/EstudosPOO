using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    public class Jogo
    {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public DateTime DataLancamento { get; set; }
        public static int Qtde { get; private set; }

        //private int qtde = 0;
        public Jogo(string nome, string categoria, DateTime dataLancamento)
        {
            Codigo = ++Qtde;

            if (string.IsNullOrEmpty(nome.Trim()))
                throw new Exception("nome vazio!");
            Nome = nome;

            if (string.IsNullOrEmpty(categoria.Trim()))
                throw new Exception("categoria vazia!");
            Categoria = categoria;

            if (dataLancamento > DateTime.Now)
                throw new Exception("data maior que a de hoje");

            DataLancamento = dataLancamento;
        } 
    }
}
