using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "", valor;
            Pilha pilha = new Pilha(5);
            int posicao;
            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Empilhar \n " + "2-> Desempilhar \n " + "3-> Tamanho \n "
                        +"4-> Mostrar pilha \n " + "5-> Empilhar em uma posição \n " + "6-> Desempilhar em uma posição \n " + "9-> Sair");
                    opcao = Console.ReadLine();
                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para empilhar:");
                            valor = Console.ReadLine();
                            pilha.Empilha(valor);
                            break;
                        case "2":
                            string retorno = pilha.Desempilha();
                            Console.WriteLine($"Desempilhado: {retorno}");
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da pilha:{0}", pilha.Tamanho());
                            break;
                        case "4":
                            pilha.MostraVetor();
                            break;
                        case "5":
                            Console.WriteLine("Digite um valor para inserir:");
                            valor = Console.ReadLine();
                            Console.WriteLine("Digite a posição:");
                            posicao = Convert.ToInt32(Console.ReadLine());
                            pilha.Empilha(valor, posicao);
                            break;
                        case "6":
                            Console.WriteLine("Digite a posição:");
                            posicao = Convert.ToInt32(Console.ReadLine());
                            pilha.Desempilha(posicao);
                            break;
                        case "9":
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        
        }
    }
}
