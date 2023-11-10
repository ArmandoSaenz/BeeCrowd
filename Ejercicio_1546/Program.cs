using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "", "Rolien", "Naej", "Elehcim", "Odranoel" };
            string data;
            int n;
            while ((data = Console.ReadLine()) != null)
            {
                n = int.Parse(data);
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine(names[int.Parse(Console.ReadLine())]);
                }
            }
        }
    }
}
