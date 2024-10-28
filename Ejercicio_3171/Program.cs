using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_3171
{
    class Node
    {
        public bool Visited { get; set; } = false;
        public List<Node> Nodes = new List<Node>();
        public void Route()
        {
            if (Visited)
                return;
            Visited = true;
            foreach(Node node in Nodes)
            {
                node.Route();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definición de variables
            string line;
            string[] data;
            List<string> segments = new List<string>();
            int N, L, x, y;
            //Estrayendo numeros de leds y numero de segmentos
            line = Console.ReadLine();
            data = line.Split(' ');
            N = int.Parse(data[0]);
            L = int.Parse(data[1]);
            //Creando nodos
            List<Node> Leds = Enumerable.Range(0, N).Select(_ => new Node()).ToList();
            //Construyendo grafo
            for (int i = 0; i < L; ++i)
            {
                line = Console.ReadLine();
                segments.Add(line);
                data = line.Split(' ');
                x = int.Parse(data[0]);
                y = int.Parse(data[1]);
                if (x <= N && y <= N)
                {
                    Leds[x - 1].Nodes.Add(Leds[y - 1]);
                    Leds[y - 1].Nodes.Add(Leds[x - 1]);
                }
            }
            //Recorriendo los leds
            Leds[0].Route();
            Console.WriteLine(Leds.TrueForAll(led => led.Visited) ? "COMPLETO" : $"INCOMPLETO");
            Console.ReadLine();
        }
    }
}
