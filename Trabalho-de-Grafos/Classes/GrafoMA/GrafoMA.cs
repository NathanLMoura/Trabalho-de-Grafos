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
                contGrau += MA[c, qtVertices];
            }
            return contGrau;
        }

        public bool Completo()
        {
            int contAres = 0;
            int compVert = ((qtVertices * (qtVertices - 1)) / 2);
            for (int c = 0; c < qtVertices; c++)
            {
                contAres = Grau(c);//Função não esta finalizada, precisa ser corrigida
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
            throw new System.NotImplementedException();
        }

        public void SequenciaGraus()
        {
            throw new System.NotImplementedException();
        }

        public void VerticesAdjacentes(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Isolado(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Impar(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Par(int vertice)
        {
            throw new System.NotImplementedException();
        }

        public bool Adjacentes(int v1, int v2)
        {
            throw new System.NotImplementedException();
        }
        public void ShowMA()
        {
            throw new System.NotImplementedException();
        }
        public void ShowLA()
        {
            throw new System.NotImplementedException();
        }
    }
}
