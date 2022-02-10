using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    public class ContaCorrente
    {
        private double _saldo = 0;

        public string Numero { get; private set;}
        public int Agencia { get; private set; }
        public string Nome { get; set; }

        public double Saldo
        {
            get => _saldo;
        }

        public ContaCorrente(string nome, int agencia, string numero)
        {
            if(nome.Trim().Length == 0)
            {
                throw new Exception("nome obrigatório");
            }

            if(agencia< 0)
            {
                throw new Exception("agência deve ser maior que 0.");
            }

            if (numero.Trim().Length == 0)
            {
                throw new Exception("numero obrigatório");
            }
            Nome = nome;
            Agencia = agencia;
            Numero = numero;
        }

        public void Saque(double valor)
        {
            if(valor < 0 || _saldo - valor < 0)
            {
                throw new ArgumentException("Valor do saque deve ser maior que 0.");
            }

            if(_saldo < valor)
            {
                throw new ArgumentException("O valor deve ser maior que o saldo");
            }
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor do depósito deve ser maior que 0.");
            }

            _saldo += valor;
        }
    }
}
