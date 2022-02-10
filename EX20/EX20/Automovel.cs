using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX20
{
    public abstract class Automovel
    {
        private double _capacidadeMaxima;
        private double _velocidadeAtual;
        private double _capacidadeCarregada;

        public string Descricao { get; set; }
        public double CapacidadeMaximaEmKg{
            get => _capacidadeMaxima;
            protected set {
                if (value < 0)
                    throw new Exception("capacidade não deve ser negativa");
                _capacidadeMaxima = value;
            } 
        }
        public double VelocidadeAtualEmKM 
        {
            get => _velocidadeAtual;
            protected set {
                if (value < 0)
                    throw new Exception("velocidade não deve ser negativa");
                _velocidadeAtual = value;
            } 
        }
        public double CapacidadeCarregada {
            get => _capacidadeCarregada;
            protected set {
                if (value < 0)
                    throw new Exception("capacidade não deve ser negativa");
                _capacidadeCarregada = value;
            } 
        }

        public Automovel()
        {
            Descricao = "";
            CapacidadeCarregada = 0;
            VelocidadeAtualEmKM = 0;
            CapacidadeMaximaEmKg = 0;
        }

        public Automovel(string descricao, double capacidadeMax = 0, double velo = 0, double capacidadeCar = 0)
        {
            Descricao = descricao;
            CapacidadeMaximaEmKg = capacidadeMax;
            VelocidadeAtualEmKM = velo;
            CapacidadeCarregada = capacidadeCar;
        }

        public virtual void Carregar(double peso)
        {
            if (peso > CapacidadeMaximaEmKg || peso + CapacidadeCarregada > CapacidadeMaximaEmKg)
                throw new Exception("Capacidade máxima excedida.");
            CapacidadeCarregada += peso;
        }

        public virtual void Acelerar()
        {
            VelocidadeAtualEmKM += 1;
        }

        public abstract double PagarPedagio();

        public override string ToString()
        {
            return $"{Descricao} | {CapacidadeMaximaEmKg}kg | {VelocidadeAtualEmKM}km/h | {CapacidadeCarregada}kg | ";
        }
    }
}
