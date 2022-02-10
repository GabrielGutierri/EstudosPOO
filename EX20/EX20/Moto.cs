using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    public class Moto : Automovel
    {
        private int _cilindrada;

        public int Cilindrada { 
            get => _cilindrada;
            set
            {
                if (value < 0)
                    throw new Exception("cilindradas não podem ser menores que zero.");
                _cilindrada = value;
            }
        }

        public Moto(int cilindradas, string desc, double capMax, double velo, double capCar) : base(desc, capMax, velo, capCar)
        {
            Cilindrada = cilindradas;
        }

        public string Empinar()
        {
            return "Empinando...";
        }
        public override double PagarPedagio()
        {
            return 2;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Cilindrada} cilindradas.";
        }
    }
}
