using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    public class Jogo
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Categoria { get; private set; }
        public DateTime DataLanc { get; private set; }

        public Jogo(int codigo, string nome, string categoria, DateTime dataLanc)
        {
            Codigo = codigo;
            Nome = nome;
            Categoria = categoria;
            DataLanc = dataLanc;
        }

    }
}
