using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3

        static void ExibirTexto(string texto)
        {
            //int posicao = (Console.WindowWidth - texto.Length) / 2;
            //Console.CursorLeft = posicao;
            //Console.WriteLine(texto);

            //outro jeito
            int largura = texto.Length / 2;
            int consoleWidth = Console.WindowWidth / 2;
            Console.WriteLine(texto.PadLeft(consoleWidth + largura));
        }

        static void ExibirTexto(string texto, ConsoleColor cor)
        {
            int largura = texto.Length / 2;
            int consoleWidth = Console.WindowWidth / 2;
            Console.ForegroundColor = cor;
            Console.WriteLine(texto.PadLeft(consoleWidth + largura));
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void Main(string[] args)
        {
            ExibirTexto("teste teste testando o teste");
            ExibirTexto("teste ainda", ConsoleColor.Red);
            ExibirTexto("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            ExibirTexto("teste teste testando o teste");
            ExibirTexto("teste ainda", ConsoleColor.Red);
            ExibirTexto("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.ReadLine();
        }
    }
}
