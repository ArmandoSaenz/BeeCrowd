using System;
using System.Collections.Generic;

namespace Ejercicio_1042
{
    class Node
    {
        public string Name { get; set; }
        public string Animal { get; set; }
        public Dictionary<string, Node> Nodes;

        public Node()
        {
            Nodes = new Dictionary<string, Node>();
        }
        public void AddNode(Node node)
        {
            Nodes.Add(node.Name, node);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Node Root = new Node() { Name = "root"};
            Node Vertebrado = new Node { Name = "vertebrado" };
            Node Invertebrado = new Node { Name = "invertebrado" };
            Node Ave = new Node { Name = "ave" };
            Node Mamifero = new Node { Name = "mamifero" };
            Node Inseto = new Node { Name = "inseto" };
            Node Anelideo = new Node { Name = "anelideo" };
            Root.AddNode(Vertebrado);
            Root.AddNode(Invertebrado);
            Vertebrado.AddNode(Ave);
            Vertebrado.AddNode(Mamifero);
            Invertebrado.AddNode(Inseto);
            Invertebrado.AddNode(Anelideo);
            Ave.AddNode(new Node() { Name = "carnivoro", Animal = "aguia" });
            Ave.AddNode(new Node() { Name = "onivoro", Animal = "pomba" });
            Mamifero.AddNode(new Node() { Name = "onivoro", Animal = "homem" });
            Mamifero.AddNode(new Node() { Name = "herbivoro", Animal = "vaca" });
            Inseto.AddNode(new Node() { Name = "hematofago", Animal = "pulga" });
            Inseto.AddNode(new Node() { Name = "herbivoro", Animal = "lagarta" });
            Anelideo.AddNode(new Node() { Name = "hematofago", Animal = "sanguessuga" });
            Anelideo.AddNode(new Node() { Name = "onivoro", Animal = "minhoca" });
            string[] Nodos = new string[] { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            Console.WriteLine(Root.Nodes[Nodos[0]].Nodes[Nodos[1]].Nodes[Nodos[2]].Animal);
            Console.ReadLine();
        }
    }
}
