using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX16
{
    class Jogo
    {
        private int _codigo;
        public int Codigo 
        { 
            get => _codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("código deve ser maior que zero.");
                _codigo = value;
            } 
        }

        private string _descricao;
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("descrição obrigatória.");
                _descricao = value;
            }
        }

        public EnumDificuldade Dificuldade { get; set; }

        public Fabricante FabricanteJogo { get; private set; }

        private double _valor;
        public double Valor
        {
            get => _valor;
            set
            {
                if (value < 1)
                    throw new Exception("valor deve ser maior que 1,00.");
                _valor = value;
            }
        }

        public Jogo(int codigo, string descricao, EnumDificuldade dificuldade, Fabricante fabricante, double valor)
        {
            Codigo = codigo;
            Descricao = descricao;
            Dificuldade = dificuldade;
            FabricanteJogo = fabricante;
            Valor = valor;
        }

        public void AtualizarPreco(int percentual)
        {
            Valor += Valor * ((double)percentual/100);
        }

        public void AtualizarPreco(double aumento)
        {
            Valor += aumento;
        }

    }
}
