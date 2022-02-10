using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18
{
    class ContaCorrente : ContaBancaria
    {
        private double _limite;
        public bool UtilizaTalaoCheque {get; set;}
        public double Limite { 
            get => _limite;
            set 
            {
                if (value < 0)
                    throw new Exception("limite não pode ser menor que zero.");
                _limite = value;
            } 
        }

        public ContaCorrente(string nome, string numero, double limite, bool talao) : base(nome, numero)
        {
            Limite = limite;
            UtilizaTalaoCheque = talao;
        }
        public override void Saque(double valor)
        {
            if (valor <= 0)
                throw new Exception("valor não pode ser negativo");
            if (Saldo + Limite - valor < 0)
                throw new Exception("você não tem mais crédito.");
            Saldo -= valor;
        }

        public override string ToString()
        {
            double limiteReal = Limite;
            if (Saldo < 0)
                limiteReal += Saldo;
            return base.ToString() + $" - Limite: {limiteReal} - Talão de cheque: {(UtilizaTalaoCheque ? "Sim" : "Não")} - Conta Corrente";
        }
    }
}
