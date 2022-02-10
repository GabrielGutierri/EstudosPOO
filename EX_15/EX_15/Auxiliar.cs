using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_15
{
    class Auxiliar
    {
        public static bool VerificaTexto(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }
            return true;
        }

        public static bool VerificaCodigo(string texto)
        {
            try
            {
                int codigo = Convert.ToInt32(texto);
                if (codigo < 0)
                    return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
