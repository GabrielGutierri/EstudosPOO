using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX17
{
    class FuncionarioVendedor:Funcionario
    {
        public double MetaVendas { get; set; }
        public double Vendas { get; set; }
        public double PorcentagemVendas { get; set; }

        public override double CalculaSalario()
        {
            double resultado = base.CalculaSalario();
            if (Vendas >= MetaVendas)
                resultado = Salario + (Vendas * PorcentagemVendas / 100);
            return resultado;
         
        }

        public override string ToString()
        {
            return base.ToString() + $" Meta de vendas no mês: {MetaVendas} - Vendas no mês: {Vendas} - Porcentagem sobre vendas: {PorcentagemVendas}";
        }
    }
}
