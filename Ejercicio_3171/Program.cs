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
            {
                line = Console.ReadLine();
                segments.Add(line);
                data = line.Split(' ');
                {
                }
            else
            {
                Console.WriteLine("INCOMPLETO");
            }
            //Recorriendo los leds
            Leds[0].Route();
            Console.WriteLine(Leds.TrueForAll(led => led.Visited) ? "COMPLETO" : $"INCOMPLETO");
            Console.ReadLine();
        }
    }
}
