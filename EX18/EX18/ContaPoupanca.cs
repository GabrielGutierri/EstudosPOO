using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX18
{
    class ContaPoupanca : ContaBancaria
    {
        public int DiaAniversario { get; set; }
        public string NumeroContaCorrenteAtrelada { get; set; }

        public ContaPoupanca(string nome, string numeroConta, int diaAniversario, string contaAtrelada):base(nome, numeroConta)
        {
            DiaAniversario = diaAniversario;
            NumeroContaCorrenteAtrelada = contaAtrelada;
        }
        
        public override void Saque(double valor)
        {
            if (valor < 0)
            {
                throw new Exception("valor negativo.");
            }

            if (Saldo - valor < 0)
                throw new Exception("não tem mais crédito");
            Saldo -= valor;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Aniversário: {DiaAniversario} - CC Atrelada: {NumeroContaCorrenteAtrelada} - Conta Poupança";
        }
    }
}
