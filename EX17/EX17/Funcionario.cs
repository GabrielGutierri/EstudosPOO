using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public virtual double CalculaSalario()
        {
            return Salario;
        }

        public override string ToString()
        {
            return $"Código: {Codigo} - Nome: {Nome} - Salário: {Salario} - Salário calculado: {CalculaSalario()}";
        }
    }
}
