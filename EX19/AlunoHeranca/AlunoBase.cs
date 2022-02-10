using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoHeranca
{
    class AlunoBase : Object
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public double N1 { get; set; }
        public int Faltas { get; set;}

        public virtual double CalcularMedia() // virtual significa que um método *pode* ser modificado nas classes descendentes
        {
            return N1;
        }

        protected virtual double CalculaFaltas()
        {
            return (Faltas * 100) / 80;
        }

        protected double MediaDoCursos()
        {
            double media = 0;
            if (this is AlunoEM)
                media = 6;
            if (this is AlunoFTT)
                media = 5;
            if (this is AlunoPos)
                media = 7;
            return media;
        }
        public virtual EnumeradorSituacao VerificaSituacao()
        {
            double media = MediaDoCursos();
            if (100-CalculaFaltas() >= 75 && CalcularMedia() >= MediaDoCursos())
            {
                return EnumeradorSituacao.Aprovado;
            }
            return EnumeradorSituacao.Reprovado;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("RA: " + RA);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("N1: " + N1.ToString("0.0"));
            sb.AppendLine("Média: " + CalcularMedia().ToString("0.0"));
            sb.AppendLine("% de frequência: " + (100 - CalculaFaltas()) + "%");
            sb.AppendLine("Situação: " + VerificaSituacao().ToString());
            return sb.ToString();
        }

    }
}
