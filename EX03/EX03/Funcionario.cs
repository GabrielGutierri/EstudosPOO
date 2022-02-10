using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX03
{
    public class Funcionario
    {
        private int _codigo;
        private string _nome;
        private string _rg;
        private double _salario;

        public int Codigo
        {
            get => _codigo;
            set {
                if (value <= 0)
                {
                    throw new Exception("o código deve ser maior que zero.");
                }
                _codigo = value;
            }
        }

        public string Nome
        {
            get => _nome;

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("nome obrigatório.");
                _nome = value;
            }
        }

        public string RG
        {
            get => _rg;

            set
            {
                Regex regexRG = new Regex(@"[0-9]{2}.[0-9]{3}.[0-9]{3}-[0-9]");
                MatchCollection matches = regexRG.Matches(value);
                if (string.IsNullOrEmpty(value) || regexRG.IsMatch(value) == false)
                    throw new Exception("rg obrigatório.");
                _rg = value;
            }
        }

        public double Salario
        {
            get => _salario;
            set
            {
                if (value <= 0)
                    throw new Exception("salario deve ser maior que zero.");
                _salario = value;
            }
        }


        public double Inss { get => Salario * 0.11; }

        public double CalculaSalario { get => Salario - Inss;}
    }
}
