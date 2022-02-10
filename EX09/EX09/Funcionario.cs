using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX09
{
    public class Funcionario
    {
        private int _codigo;
        private string _nome;
        private string _rg;
        private double _salario;

        public int Codigo{
            get {
                return _codigo;
            } 
            private set {
                if (value <= 0)
                {
                    throw new Exception("o código deve ser maior que zero.");
                }
                _codigo = value;
            } 
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("nome obrigatório.");
                _nome = value;
            }
        }
        public string RG
        {
            get
            {
                return _rg;
            }
            private set
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
            get
            {
                return _salario;
            }
            private set
            {
                if (value <= 0)
                    throw new Exception("salario deve ser maior que zero.");
                _salario = value;
            }
        }

        public Funcionario(int codigo, string nome, string rg, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            RG = rg;
            Salario = salario;
        }

        public double Inss { get => Salario * 0.11; }

        public double CalculaSalario { get => Salario - Inss; }
    }
}
