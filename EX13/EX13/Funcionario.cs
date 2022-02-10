using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    class Funcionario
    {
        public string Nome { get; set; }
        public enum sexo
        {
            masculino = 1,
            feminino = 2
        };
        public enum estadoCivil
        {
            solteiro = 1,
            casado = 2,
            viuvo = 3
        };

        public sexo Sexo { get; private set; }
        public DateTime DataNascimento { get; set; }


        public Funcionario(string nome, int sexoParam, int estado, DateTime dataNasc)
        {
            Nome = nome;
            DataNascimento = dataNasc;
            
            if(sexoParam == 0)
            {
                Sexo = (sexo) sexoParam + 1;
            }

            if (sexoParam == 1)
                Sexo = (sexo) sexoParam + 1;
        }
    }
}
