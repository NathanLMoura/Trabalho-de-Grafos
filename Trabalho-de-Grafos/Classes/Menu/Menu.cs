using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_Grafos.Classes.Menu
{
    class Menu
    {

        public void MenuPrincipal()
        {
            Console.WriteLine("\n--------MENU PRINCIPAL--------");
            Console.WriteLine("Selecione a opção que deseja utilizar:");
            Console.WriteLine("1 - Classe Grafo por Matriz de Adjacência");
            Console.WriteLine("2 - Classe Grafo por Lista de Adjacência");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção escolhida: ");
        }

        public void MenuGrafoMA()
        {
            Console.WriteLine("\n--------MENU DE GRAFO POR MATRIZ DE ADJACÊNCIA--------");
            Console.WriteLine("Selecione a opção que deseja utilizar:");
            Console.WriteLine("1 - Verificar a ordem do grafo");
            Console.WriteLine("2 - Inserir Aresta");
            Console.WriteLine("3 - Remover Aresta");
            Console.WriteLine("4 - Verificar o grau do vértice");
            Console.WriteLine("5 - Verificar se grafo é completo");
            Console.WriteLine("6 - Verificar se grafo é regular");
            Console.WriteLine("7 - Imprimir Matriz de Adjacência");
            Console.WriteLine("8 - Imprimir Lista de Adjacência");
            Console.WriteLine("9 - Imprimir a sequência de graus");
            Console.WriteLine("10 - Imprimir os vértices que são adjacentes");
            Console.WriteLine("11 - Verificar se vértice é isolado");
            Console.WriteLine("12 - Verificar se vértice é impar");
            Console.WriteLine("13 - Verificar se vértice é par");
            Console.WriteLine("14 - Verificar se vértices são adjacentes");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção escolhida: ");
        }

        public void MenuGrafoLA()
        {
            Console.WriteLine("\n--------MENU DE GRAFO POR LISTA DE ADJACÊNCIA--------");
            Console.WriteLine("Selecione a opção que deseja utilizar:");
            Console.WriteLine("1 - Verificar a ordem do grafo");
            Console.WriteLine("2 - Inserir Vértice");
            Console.WriteLine("3 - Remover Vértice");
            Console.WriteLine("4 - Inserir Aresta");
            Console.WriteLine("5 - Remover Aresta");
            Console.WriteLine("6 - Verificar o grau do vértice");
            Console.WriteLine("7 - Verificar se grafo é completo");
            Console.WriteLine("8 - Verificar se grafo é regular");
            Console.WriteLine("9 - Imprimir Matriz de Adjacência");
            Console.WriteLine("10 - Imprimir Lista de Adjacência");
            Console.WriteLine("11 - Imprimir a sequência de graus");
            Console.WriteLine("12 - Imprimir os vértices que são adjacentes");
            Console.WriteLine("13 - Verificar se vértice é isolado");
            Console.WriteLine("14 - Verificar se vértice é impar");
            Console.WriteLine("15 - Verificar se vértice é par");
            Console.WriteLine("16 - Verificar se vértices são adjacentes");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite a opção escolhida: ");
        }
    }
}
