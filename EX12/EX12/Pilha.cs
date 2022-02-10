using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    class Pilha
    {
        public readonly int capacidade;
        private string[] vetor;
        private int topo = -1;

        public Pilha()
        {
            capacidade = 10;
            vetor = new string[capacidade];
        }

        public Pilha(int capacidade)
        {
            this.capacidade = capacidade;
            vetor = new string[this.capacidade];
        }

        public int Tamanho()
        {
            return topo + 1;
        }

        public bool Vazia()
        {
            return Tamanho() == 0;
        }

        public void Empilha(string param)
        {
            if (Tamanho() != capacidade)
            {
                topo++;
                vetor[topo] = param;
            }
            else
            {
                throw new Exception("Pilha já está na sua capacidade total");
            }
        }

        public void Empilha(string valor, int posicao)
        {
            if (Tamanho() == capacidade)
                throw new Exception("A pilha está cheia!!!\n\n");
            else if (posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else
            {
                topo++;
                for (int i = Tamanho() - 1; i > posicao; i--)
                {
                    vetor[i] = vetor[i - 1];
                }
                vetor[posicao] = valor;
            }
        }

        public string Desempilha()
        {
            if (Vazia() == true)
            {
                throw new Exception("A pilha está vazia");
            }
            else
            {
                string textoTopo = vetor[topo];
                vetor[topo] = null;
                topo--;
                return textoTopo;
            }
        }

        public string Desempilha(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!!!");
            else
            {
                string aux = vetor[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    vetor[i] = vetor[i + 1];
                }
                topo--;
                return aux;
            }
        }

        public string Topo()
        {
            if (!Vazia())
                return vetor[topo];
            else
                throw new Exception("A pilha está vazia!");
        }

        public void MostraVetor()
        {
            foreach (var elemento in vetor)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
