using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    public class Aluno
    {
        private string _nome;
        private double _nota1;
        private double _nota2;

        public string Nome {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("nome obrigatório.");
                }

                if(value.IndexOf(' ') == -1)
                {
                    throw new Exception("nome deve contar um sobrenome.");
                }
                _nome = value;
            } 
        }

        public double Nota1
        {
            get => _nota1;
            set
            {
                if (value < 0 || value >10)
                    throw new Exception("nota deve estar entre zero e dez.");
                _nota1 = value;
            }
        }

        public double Nota2
        {
            get => _nota2;
            set
            {
                if (value < 0 || value > 10)
                    throw new Exception("nota deve estar entre zero e dez.");
                _nota2 = value;
            }
        }

        public double Media { get => (Nota1 + Nota2) / 2; }
    }
}
