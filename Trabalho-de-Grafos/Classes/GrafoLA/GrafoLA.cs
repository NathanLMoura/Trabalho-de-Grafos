using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_de_Grafos.Interfaces;

namespace Trabalho_de_Grafos.Classes.GrafoLA
{
    public class GrafoLA : IGrafo
    {
        private List<List<int>> LA;
        public GrafoLA()
        {
            LA = new List<List<int>>();
        }
        public int Ordem()
        {
            return LA.Count;
        }

        public bool InserirVertice(int vertice)
        {
            if (vertice> LA.Count)
            {
                LA.Add(new List<int>());
                return true;
            }

            return false;
        }

        public bool RemoverVertice(int vertice)
        {
            if (vertice < LA.Count)
            {
                LA.RemoveAt(vertice);
                return true;
            }

            return false;
        }

        public bool InserirAresta(int v1, int v2)
        {
            if (!LA[v1].Contains(v2) && !LA[v2].Contains(v1))
            {
                LA[v1].Add(v2);
                LA[v2].Add(v1);
                return true;
            }

            return false;
        }

        public bool RemoverAresta(int v1, int v2)
        {
            if (LA[v1].Exists(c => c == v2) && LA[v2].Exists(c => c == v1))
            {
                LA[v1].Remove(v2);
                LA[v2].Remove(v1);
                return true;
            }

            return false;
        }

        public int Grau(int vertice)
        {
            return LA[vertice].Count;
        }

        public bool Completo()
        {
            int quantidadeArestas = 0;
            foreach (var vertices in LA)
            {
                quantidadeArestas += vertices.Count;
            }

            return ((LA.Count * (LA.Count - 1)) / 2) == quantidadeArestas/2;
        }

        public bool Regular()
        {
            int grauAnterior = Grau(0);
            for (int i = 1; i < LA.Count; i++)
            {
                if (grauAnterior != Grau(i))
                {
                    return false;
                }
            }

            return true;
        }

        public void SequenciaGraus()
        {
            for (int i = 0; i < LA.Count; i++)
            {
                Console.Write(Grau(i) + " ");
            }
        }

        public void VerticesAdjacentes(int vertice)
        {
            foreach (var vertices in LA[vertice])
            {
                Console.Write(vertices + " ");
            }
        }

        public bool Isolado(int vertice)
        {
            return LA[vertice].Count == 0;
        }

        public bool Impar(int vertice)
        {
            return Grau(vertice) % 2 != 0;
        }

        public bool Par(int vertice)
        {
            return Grau(vertice) % 2 == 0;
        }

        public bool Adjacentes(int v1, int v2)
        {
            return LA[v1].Exists(c=> c==v2) && LA[v2].Exists(c=> c==v1);
        }

        public void ShowMA()
        {
            
            var mat = new int[LA.Count, LA.Count];
            for (int i = 0; i < LA.Count; i++)
            {
                for (int j = 0; j < LA.Count; j++)
                {
                    if (j < mat.GetLength(1) - 1)
                    {
                        Console.Write(LA[i].Exists(c => c == j)?" 1 ":" 0 ");
                    }
                    else
                    {
                        Console.Write(LA[i].Exists(c => c == j) ? " 1" : " 0");
                    }
                }
                Console.Write("\n");
            }
        }

        public void ShowLA()
        {
            for (int i = 0; i < LA.Count; i++)
            {
                Console.Write(i+":");
                foreach (var vertices in LA[i])
                {
                    Console.Write(vertices+" ");
                }
                Console.Write("\n");
            }
        }
    }
}
