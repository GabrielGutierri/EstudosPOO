using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    public static class Auxiliares
    {
        public static bool VerificaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return false;
            return true;
        }

        public static bool VerificaCodigo(int codigo)
        {
            if (codigo < 0)
                return false;
            return true;
        }

        public static bool VerificaPreco(double preco)
        {
            if (preco <= 0)
                return false;
            return true;
        }
    }
}
