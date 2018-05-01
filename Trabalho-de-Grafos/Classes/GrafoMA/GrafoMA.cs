using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_de_Grafos.Interfaces;

namespace Trabalho_de_Grafos.Classes.GrafoMA
{
    class GrafoMA : IGrafo
    {
        private int[,] MA;
        private int qtVertices;

        public GrafoMA(int qtVertices)
        {
            this.qtVertices = qtVertices;
            MA = new int[qtVertices, qtVertices];
            for (int i = 0; i < qtVertices; i++)
            {
                for (int j = 0; j < qtVertices; j++)
                {
                    MA[i, j] = 0;
                }
            }
        }

        public int Ordem()
        {
            return qtVertices;
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (v1 < qtVertices && (v2 < qtVertices))
            {
                MA[v1, v2] = 1;
                MA[v2, v1] = 1;
                return true;
            }
            else return false;
        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (v1 < qtVertices && (v2 < qtVertices))
            {
                MA[v1, v2] = 0;
                MA[v2, v1] = 0;
                return true;
            }
            else return false;
        }

        public int Grau(int vertice)
        {
            int contGrau = 0;
            for (int c = 0; c < qtVertices; c++)
            {
                contGrau += MA[c, vertice];
            }
            return contGrau;
        }

        public bool Completo()
        {
            int contAres = 0;
            int compVert = ((qtVertices * (qtVertices - 1)) / 2);
            for (int i = 0; i < qtVertices; i++)
            {
                for(int j = i; j < qtVertices; j++)
                {
                    contAres += MA[i, j];
                }
                
            }
            if (contAres == compVert)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Regular()
        {
            int grauAnterior = Grau(0);
            for (int c = 1; c < qtVertices; c++)
            {
                int grauAtual = Grau(c);

                if(grauAnterior != grauAtual)
                {
                    return false;
                }
                grauAnterior = grauAtual;

            }
            return true;
        }

        public void SequenciaGraus()
        {
            int[] sequenciaGraus = new int[qtVertices];
            for (int c = 0; c < qtVertices; c++)
            {
                sequenciaGraus[c] = Grau(c);
            }


            int auxInt=0;
            for(int i=0; i < qtVertices; i++)
            {
                for(int j = 0; j < qtVertices; j++)
                {
                    if (sequenciaGraus[i] < sequenciaGraus[j])
                    {
                        auxInt = sequenciaGraus[i];
                        sequenciaGraus[i] = sequenciaGraus[j];
                        sequenciaGraus[j] = auxInt;
                    }
                }
            }
        }

        public void VerticesAdjacentes(int vertice)
        {
            Console.Write(vertice + ":");
            for (int c = 0; c < qtVertices; c++)
            {
                if (MA[vertice, c] == 1)
                    Console.Write(" " + c + ",");
            }
        }

        public bool Isolado(int vertice)
        {
            for (int c = 0; c < qtVertices; c++)
            {
                if (Grau(c) == 0)
                    return true;
            }
            return false;
        }

        public bool Impar(int vertice)
        {
            if (Grau(vertice) % 2 != 0)
                return true;
            return false;
        }

        public bool Par(int vertice)
        {
            if (Grau(vertice) % 2 == 0)
                return true;
            return false;
        }

        public bool Adjacentes(int v1, int v2)
        {
            if (MA[v1, v2] == 1)
                return true;
            return false;

        }
        public void ShowMA()
        {
            for(int i = 0; i < qtVertices; i++)
            {
                Console.Write(i + ":");
                for (int j = 0; j < qtVertices; j++)
                {
                    Console.Write(" " + MA[i, j] + ",");
                }
                Console.Write("\n");
            }
        }
        public void ShowLA()
        {
            for(int c = 0; c < qtVertices; c++)
            {
                VerticesAdjacentes(c);
                Console.Write("\n");
            }
        }
    }
}
