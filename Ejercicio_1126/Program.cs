using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1126
{
    class Vector
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public double Norm => Math.Sqrt(x * x + y * y + z * z);
        public Vector(string line)
        {
            string[] data = line.Split(' ');
            x = int.Parse(data[0]);
            y = int.Parse(data[1]);
            z = int.Parse(data[2]);

        }
    }
    class Tetrahedra
    {
        public Vector Vertex1 { get; set; }
        public Vector Vertex2 { get; set; }
        public Vector Vertex3 { get; set; }
        public Vector Vertex4 { get; set; }

        public Tetrahedra(Vector vertex1, Vector vertex2, Vector vertex3, Vector vertex4)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Vertex3 = vertex3;
            Vertex4 = vertex4;
        }
    }
    class Program
    {
        static double NormL2(int[] vector )
        {
            double norm = 0;
            foreach(int item in vector)
            {
                norm += item * item;
            }
            return Math.Sqrt(norm);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; ++i)
            {

            }
        }
    }
}
