using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3162
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            int n;
            List<int[]> Coordinates = new List<int[]>();
            List<int[]> tmp;
            List<double> distance;
            int[] current;
            data = Console.ReadLine();
            n = int.Parse(data);
            for (int i = 0; i < n; ++i)
            {
                data = Console.ReadLine();
                Coordinates.Add(Array.ConvertAll<string, int>(data.Split(' '), int.Parse));
            }
            for (int i = 0; i < n; ++i)
            {
                current = Coordinates[i];
                tmp = Coordinates.Select (item => item).ToList();
                tmp.RemoveAt(i);
                distance = tmp.Select<int[], double>(item => Math.Sqrt(Math.Pow(current[0] - item[0], 2) + Math.Pow(current[1] - item[1], 2) + Math.Pow(current[2] - item[2], 2))).ToList();
                distance.Sort();
                if (distance[0] <= 20)
                    Console.WriteLine("A");
                else if (distance[0] <= 50)
                    Console.WriteLine("M");
                else
                    Console.WriteLine("B");
            }
            Console.ReadLine();
        }
    }
}
