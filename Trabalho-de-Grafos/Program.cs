using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_de_Grafos.Classes.Menu;
using Trabalho_de_Grafos.Classes.GrafoMA;

namespace Trabalho_de_Grafos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op, op2;
            Menu menu = new Menu();
            GrafoMA grafoMA= new GrafoMA(0);
            bool grafoMAInstanciado = false;
            do
            {
                menu.MenuPrincipal();
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {

                    int v1, v2;
                    //Instaciação do grafo com a quantidade de vertices desejados
                    if (!grafoMAInstanciado)
                    {
                        Console.Write("Digite a quantidade vértices desejado: ");
                        int qtVertices = int.Parse(Console.ReadLine());
                        grafoMA = new GrafoMA(qtVertices);
                        grafoMAInstanciado = true;
                    }

                    do
                    {
                        Console.Clear();
                        menu.MenuGrafoMA();
                        op2 = int.Parse(Console.ReadLine());
                    } while (op2 < 0 || op2 > 14);


                    if (op2 == 1) {
                        Console.WriteLine(grafoMA.Ordem());
                    }
                    if (op2 == 2)
                    {
                        Console.Write("Digite o primeiro vértice adjacente a aresta que deseja inserir: ");
                        v1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo vértice adjacente a aresta que deseja inserir: ");
                        v2 = int.Parse(Console.ReadLine());
                        if (grafoMA.InserirAresta(v1, v2))
                            Console.WriteLine("Aresta inserida com sucesso");
                        else
                            Console.WriteLine("Aresta não foi inserida com sucesso pois vértices são inexistentes ou já existe aresta");
                    }
                    if (op2 == 3)
                    {
                        Console.Write("Digite o primeiro vértice adjacente a aresta que deseja inserir: ");
                        v1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo vértice adjacente a aresta que deseja inserir: ");
                        v2 = int.Parse(Console.ReadLine());
                        if (grafoMA.RemoverAresta(v1, v2))
                            Console.WriteLine("Aresta removida com sucesso");
                        else
                            Console.WriteLine("Aresta não foi removida com sucesso pois vértices são inexistentes ou não existe aresta");

                    }
                    if (op2 == 4)
                    {
                        Console.Write("Digite o primeiro vértice que deseja verificar o grau: ");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(grafoMA.Grau(v1));
                    }
                    if (op2 == 5)
                    {
                        if (grafoMA.Completo())
                        {
                            Console.WriteLine("Grafo é completo");
                        }
                        else
                        {
                             Console.WriteLine("Grafo não é completo");
                        }
                    }
                    if (op2 == 6)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 7)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 8)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 9)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 10)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 11)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 12)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 13)
                    {
                        grafoMA.Ordem();
                    }
                    if (op2 == 14)
                    {
                        grafoMA.Ordem();
                    }
                        
                }
            } while (op !=0);


            Console.ReadKey();
        }
    }
}
