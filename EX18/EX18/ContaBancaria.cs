using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18
{
    public abstract class ContaBancaria
    {
        public string NomeCliente { get; set; }
        public string NumeroConta { get; private set; }

        
        public double Saldo{get; protected set;}

        public ContaBancaria(string nome, string numero)
        {
            NomeCliente = nome;
            NumeroConta = numero;
        }

        public virtual void Deposito(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("valor negativo.");
            }
            Saldo += valor;
        }

        public abstract void Saque(double valor);

        public override string ToString()
        {
            return $"{NomeCliente} - {NumeroConta} - Saldo: {Saldo}";
        }
    }
}
