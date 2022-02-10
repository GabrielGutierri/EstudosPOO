using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13
{
    public static class Auxialiares
    {
        public static bool VerificaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome obrigatório.");
            }
            else
            {
                string[] nomes = nome.Trim().Split(' ');
                if (nomes.Length == 1)
                {
                    throw new Exception("Nome precisa ter um sobrenome.");
                }

                return true;
            }
        }

        public static bool VerificaData(DateTime data, out int idade)
        {
            if (data > DateTime.Now)
            {
                throw new Exception("Data de nascimento deve ser maior que a atual.");
            }

            idade = DateTime.Now.Year - data.Year;
            return true;
        }
    }
}
