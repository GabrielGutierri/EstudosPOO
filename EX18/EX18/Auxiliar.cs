using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX18
{
    public class Auxiliar
    {
        public static List<ContaBancaria> contas = new List<ContaBancaria>();
        public static bool VerificaString(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return false;
            return true;
        }

        public static bool VerificaContaExistente(string numero)
        {
            ContaBancaria conta = contas.Find(c => c.NumeroConta == numero);
            if (conta == null) // se a conta não existir.
                return true;
            return false; // se a conta existir.
        }
        public static bool VerificaFormatoNumero(string numero)
        {
            Regex regex = new Regex(@"[0-9]{4}-[0-9]");
            if (regex.IsMatch(numero))
                return true;
            return false;
        }
        public static bool VerificaDiaAniversario(int dia)
        {
            if (dia > 31 || dia <0)
                return false;
            return true;
        }
        public static ContaBancaria PesquisaConta (string numero)
        {
            return contas.Find(c => c.NumeroConta == numero);
        }
    }
}
