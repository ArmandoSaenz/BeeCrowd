using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            int n = 2;
            n1 = float.Parse(Console.ReadLine());
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("{0}", (n1 + n2) / n);
            Console.ReadLine();

        }
    }
}
