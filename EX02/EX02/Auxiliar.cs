using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    public static class Auxiliar
    {
        public static string VerificaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome.Trim()))
                throw new Exception("o nome é obrigatório!");

            return nome;
        }

        public static string VerificaCategoria(string categoria)
        {
            if ((categoria != "ação" && categoria != "tiro" && categoria != "luta" && categoria != "esportes") || string.IsNullOrEmpty(categoria.Trim()))
                throw new Exception("categoria inválida!");
            return categoria;
        }

        public static int VerificaCodigo(int codigo)
        {
            if (codigo < 0)
                throw new Exception("o codigo deve ser positivo!");
            return codigo;
        }

        public static DateTime VerificaData(DateTime dataLanc)
        {
            if (dataLanc > DateTime.Now)
                throw new Exception("data de lançamento é maior que a data atual!");
            return dataLanc;
        }

        public static string LacoString(string tipo, string textoConsole)
        {
            if (tipo == "nome")
            {
                string parametro = "";
                do
                {
                    try
                    {
                        Console.WriteLine($"Insira o {textoConsole} do jogo: ");
                        parametro = VerificaNome(Console.ReadLine().Trim());
                        break;
                    }
                    catch(Exception erro)
                    {
                        Console.WriteLine($"{erro.Message}");
                    }
                } while (true);
                return parametro;
            }
            else
            {
                string parametro = "";
                do
                {
                    try
                    {
                        Console.WriteLine($"Insira a {textoConsole} do jogo: ");
                        parametro = VerificaCategoria(Console.ReadLine().Trim());
                        break;
                    }
                    catch(Exception erro)
                    {
                        Console.WriteLine(erro.Message);
                    }
                } while (true);
                return parametro;
            }
        }

        public static DateTime LacoData(string data)
        {
            DateTime dataLanc = DateTime.Now;
            do
            {
                try
                {
                    Console.WriteLine($"Insira a {data} do jogo: ");
                    dataLanc = VerificaData(Convert.ToDateTime(Console.ReadLine()));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite a data no formato dd/mm/aaaa");
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (true);
            return dataLanc;
        }

        public static int LacoInt(string c)
        {
            int codigo = 0;
            do
            {
                try
                {
                    Console.WriteLine($"Insira o {c} do jogo: ");
                    codigo = VerificaCodigo(Convert.ToInt32(Console.ReadLine()));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite apenas números.");
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            } while (true);
            return codigo;
        }
    }
}
