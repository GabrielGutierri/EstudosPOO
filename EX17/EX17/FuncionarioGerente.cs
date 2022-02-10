using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    class FuncionarioGerente:Funcionario
    {
        public double BonusEmReais { get; set; }
        public int FuncSubordinados { get; set; }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + BonusEmReais;
        }

        public override string ToString()
        {
            return base.ToString() + $" Quantidade de subordinados: {FuncSubordinados}";
        }
    }
}
