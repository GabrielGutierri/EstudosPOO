using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Feito por Gabriel Gutierri da Costa RA: 082200014
            Jogo jogo = new Jogo("The last of us", "Aventura", Convert.ToDateTime("12/05/2013")));
                      
            Console.WriteLine($"{jogo.Codigo} - {jogo.Nome} - {jogo.Categoria} - {jogo.DataLancamento.ToShortDateString()}");
            
            Console.ReadLine();
        }
    }
}
