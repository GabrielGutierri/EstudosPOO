using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_3
{
    class Funcionario
    {

        private int codigo;
        private string nome;
        private string rg;
        private double salario;

        public int GetCodigo() => codigo;
        public void SetCodigo(int valor)
        {
            if (valor <= 0)
                throw new Exception("Código inválido");
            else
                codigo = valor;
        }

        public string GetNome() => nome;
        public void SetNome(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                throw new Exception("Preencha o nome");
            else
                nome = valor;
        }

        public string GetRG() => rg;
        public void SetRG(string valor)
        {
            if (string.IsNullOrEmpty(valor))
                throw new Exception("Preencha o RG");
            else
                rg = valor;
        }

        public double GetSalario() => salario;
        public void SetSalario(double valor)
        {
            if (valor < 0)
                throw new Exception("Salário inválido");
            else
                salario = valor;
        }


        public double GetINSS()
        {
            return GetSalario() * 0.11;
        }


        public double GetSalarioFinal() => GetSalario() - GetINSS();


    }
}
