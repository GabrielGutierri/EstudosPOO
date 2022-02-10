using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    class Auxiliar
    {

        public static List<Fabricante> listaFabricante = new List<Fabricante>() {
            new Fabricante(1,"Konami"),
            new Fabricante(2,"Capcom"),
            new Fabricante(3,"Nintendo"),
            new Fabricante(4,"Naughty Dog"),
            new Fabricante(5,"Blizzard"),
            new Fabricante(6,"Santa Monica Studios"),
            new Fabricante(7,"SEGA"),
        };

        public static bool VerificaInt(string valor)
        {
            try
            {
                int c = Convert.ToInt32(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool VerificaDouble(string valor)
        {
            try
            {
                double c = Convert.ToDouble(valor);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
