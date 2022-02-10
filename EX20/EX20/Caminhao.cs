using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    public class Caminhao : Automovel
    {
        private int _eixos;

        public int Eixos
        {
            get => _eixos;
            set
            {
                if (value < 0)
                    throw new Exception("cilindradas não podem ser menores que zero.");
                _eixos = value;
            }
        }

        public Caminhao(int eixos, string desc, double capMax, double velo, double capCar) : base(desc, capMax, velo, capCar)
        {
            Eixos = eixos;
        }

        public override void Carregar(double peso)
        {
            try
            {
                base.Carregar(peso);
                Console.WriteLine("Carregado!");
            }
            catch
            {
                Console.WriteLine("Sobrecarregado");
            }
        }

        public override void Acelerar()
        {
            if (base.CapacidadeCarregada > base.CapacidadeMaximaEmKg)
                throw new Exception("Sobrecarregado!");
            base.Acelerar();
        }

        public void Descarregar()
        {
            CapacidadeCarregada = 0;
        }

        public override double PagarPedagio()
        {
            return Convert.ToDouble(Eixos) * 5;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Eixos} eixos";
        }
    }
}
