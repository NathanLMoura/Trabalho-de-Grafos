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

                    else

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

                    else

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

                    else

                    if (op2 == 4)
                    {
                        Console.Write("Digite o vértice que deseja verificar o grau: ");
                        v1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(grafoMA.Grau(v1));
                    }

                    else

                    if (op2 == 5)
                    {
                        if (grafoMA.Completo())
                        {
                            Console.WriteLine("Grafo é completo.");
                        }
                        else
                        {
                             Console.WriteLine("Grafo não é completo.");
                        }
                    }

                    else

                    if (op2 == 6)
                    {
                        if (grafoMA.Regular())
                        {
                            Console.WriteLine("Grafo é regular.");
                        }
                        else
                        {
                            Console.WriteLine("Grafo não é regular.");
                        }
                    }

                    else

                    if (op2 == 7)
                    {
                        grafoMA.ShowMA();
                    }

                    else

                    if (op2 == 8)
                    {
                        grafoMA.ShowLA();
                    }

                    else

                    if (op2 == 9)
                    {
                        grafoMA.SequenciaGraus();
                    }

                    else

                    if (op2 == 10)
                    {
                        Console.Write("Digite o vértice que deseja verificar os vértices adjacentes: ");
                        v1 = int.Parse(Console.ReadLine());
                        grafoMA.VerticesAdjacentes(v1);
                    }

                    else

                    if (op2 == 11)
                    {
                        Console.Write("Digite o vértice que deseja verificar se é isolado: ");
                        v1 = int.Parse(Console.ReadLine());
                        if(grafoMA.Isolado(v1))
                        {
                            Console.WriteLine("Vértices é isolado");
                        }
                        else
                        {
                            Console.WriteLine("Vértices não é isolado");
                        }
                    }

                    else

                    if (op2 == 12)
                    {
                        Console.Write("Digite o vértice que deseja verificar se é impar: ");
                        v1 = int.Parse(Console.ReadLine());
                        if(grafoMA.Impar(v1))
                        {
                            Console.WriteLine("Vértices é impar");
                        }
                        else
                        {
                            Console.WriteLine("Vértices não é impar");
                        }
                    }

                    else

                    if (op2 == 13)
                    {
                        Console.Write("Digite o vértice que deseja verificar se é par: ");
                        v1 = int.Parse(Console.ReadLine());
                        if (grafoMA.Par(v1))
                        {
                            Console.WriteLine("Vértices é par");
                        }
                        else
                        {
                            Console.WriteLine("Vértices não é par");
                        }
                    }

                    else

                    if (op2 == 14)
                    {
                        Console.Write("Digite o primeiro vértice que deseja verificar: ");
                        v1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo vértice que deseja verificar: ");
                        v2 = int.Parse(Console.ReadLine());
                        if (grafoMA.InserirAresta(v1, v2))
                            Console.WriteLine("Vértices são adjacentes");
                        else
                            Console.WriteLine("Vértices não são adjacentes");
                    }
                        
                }

                else

                if (op == 2)
                {
                    do
                    {
                        Console.Clear();
                        menu.MenuGrafoLA();
                        op2 = int.Parse(Console.ReadLine());
                    } while (op2 < 0 || op2 > 16);

                    if (op2 == 1)
                    {

                    }
                    else
                    if(op2 == 2)
                    {

                    }
                    else
                    if (op2 == 3)
                    {

                    }
                    else
                    if (op2 == 4)
                    {

                    }
                    else
                    if (op2 == 5)
                    {

                    }
                    else
                    if (op2 == 6)
                    {

                    }
                    else
                    if (op2 == 7)
                    {

                    }
                    else
                    if (op2 == 8)
                    {

                    }
                    else
                    if (op2 == 9)
                    {

                    }
                    else
                    if (op2 == 10)
                    {

                    }
                    else
                    if (op2 == 11)
                    {

                    }
                    else
                    if (op2 == 12)
                    {

                    }
                    else
                    if (op2 == 13)
                    {

                    }
                    else
                    if (op2 == 14)
                    {

                    }
                    else
                    if (op2 == 15)
                    {

                    }
                    else
                    if (op2 == 16)
                    {

                    }

                }

            } while (op !=0);

           
        }
    }
}
