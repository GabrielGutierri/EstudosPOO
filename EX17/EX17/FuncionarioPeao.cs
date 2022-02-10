using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    class FuncionarioPeao:Funcionario
    {
        public double HorasExtrasEmReais { get; set; }

        public override double CalculaSalario()
        {
            return base.CalculaSalario() + HorasExtrasEmReais;
        }

        public override string ToString()
        {
            return base.ToString() + $" Horas extras: {HorasExtrasEmReais}";
        }
    }
}
