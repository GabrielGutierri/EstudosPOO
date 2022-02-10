using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX15
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }

        public Produto(int codigo, string descricao, string categoria)
        {
            Codigo = codigo;
            Descricao = descricao;
            Categoria = categoria;
            Auxiliar.AdicionarProduto(this);
        }
    }
}
