using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    class Fabricante
    {
        private int _codigo;
        public int Codigo
        {
            get => _codigo;
            set
            {
                if (value < 0)
                    throw new Exception("código deve ser maior que zero.");
                _codigo = value;
            }
        }

        private string _nome;
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

        public Fabricante(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

    }

}
