using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_15
{
    class Categoria
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Categoria(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }


        public static List<Categoria> ListarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            if (File.Exists("categorias.txt"))
            {
                string[] arquivo = File.ReadAllLines("categorias.txt", Encoding.Default);
                foreach (string linha in arquivo)
                {
                    string[] dados = linha.Split(',');

                    lista.Add(new Categoria(Convert.ToInt32(dados[0]), 
                                            dados[1]));
                }
            }

            return lista;
        }

    }
}
