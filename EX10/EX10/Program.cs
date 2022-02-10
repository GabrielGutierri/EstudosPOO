using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente("gabriel", 007, "12312312");
            conta.Depositar(100);
            conta.Saque(50);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
