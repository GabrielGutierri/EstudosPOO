using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    class Program
    {
        //Gabriel Gutierri da Costa RA:082200014 EC3
        static int Soma(int a, int b)
        {
            return a + b;
        }

        static double Soma(double a, double b)
        {
            return a + b;
        }

        static double Soma(string a, string b)
        {
            return Convert.ToDouble(a) + Convert.ToDouble(b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Soma(1, 1));
            Console.WriteLine(Soma(20, 15.068));
            Console.WriteLine(Soma(0.5, 1.5));
            Console.WriteLine(Soma("1", "1"));
            Console.ReadLine();
        }
    }
}
