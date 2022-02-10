using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feito por Gabriel Gutierri da Costa RA: 082200014
            Jogo[] jogos = new Jogo[10];
            string resp = "";
            while (resp != "n")
            {
                for (int i = 0; i < jogos.Length; i++)
                {
                    string nome = Auxiliar.LacoString("nome", "nome");
                    string categoria = Auxiliar.LacoString("categoria", "categoria");
                    DateTime data = Auxiliar.LacoData("data de lançamento");
                    int codigo = Auxiliar.LacoInt("código");

                    jogos[i] = new Jogo(codigo, nome, categoria, data);

                    do{
                        Console.WriteLine("Deseja continuar? [S/N]");
                        resp = Console.ReadLine().Trim().ToLower();
                        
                    }while (resp!="s" && resp !="n");
                    if (resp == "n")
                    {
                        break;
                    }
                }
            }

            foreach (var jogo in jogos)
            {
                if(jogo.Nome != null)
                    Console.WriteLine($"Código: {jogo.Codigo} - Nome: {jogo.Nome} - Categoria: {jogo.Categoria} - Data de Lançamento: {jogo.DataLanc.ToShortDateString()}");
            }
            Console.ReadLine();
        }
    }
}
