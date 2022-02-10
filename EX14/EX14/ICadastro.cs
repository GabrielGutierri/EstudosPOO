using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14
{
    interface ICadastro
    {
        int Codigo { get; set; }
        string Nome { get; set; }

        void Salvar();
        bool Pesquisar(string valor);
    }
}
