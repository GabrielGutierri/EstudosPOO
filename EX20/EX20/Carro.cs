using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    public class Carro : Automovel
    {
        private int _quantidadePortas;
        public int QuantidadePortas {
            get => _quantidadePortas;
            set {
                if (value < 0)
                    throw new Exception("quantidade de portas não deve ser negativa.");
                _quantidadePortas = value;
            } 
        }
        public bool UtilizandoReboque { get; set; }

        public Carro(int portas, bool reboque, string desc, double capMax, double velo, double capCar): base(desc, capMax,velo, capCar)
        {
            QuantidadePortas = portas;
            UtilizandoReboque = reboque;
        }

        public override double PagarPedagio()
        {
            if (UtilizandoReboque)
                return 7;
            return 10;
        }

        public override string ToString()
        {
            return base.ToString() + $"{QuantidadePortas} portas | {(UtilizandoReboque ? "utilizando reboque" : "sem reboque")}";
        }
    }
}
