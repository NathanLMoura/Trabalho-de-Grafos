using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Grafos.Interfaces
{
    public interface IGrafo
    {

        int Ordem();
        bool InserirAresta(int v1, int v2);
        bool RemoverAresta(int v1, int v2);
        int Grau(int vertice);
        bool Completo();
        bool Regular();
        void SequenciaGraus();
        void VerticesAdjacentes(int vertice);
        bool Isolado(int vertice);
        bool Impar(int vertice);
        bool Par(int vertice);
        bool Adjacentes(int v1, int v2);
    }
}
