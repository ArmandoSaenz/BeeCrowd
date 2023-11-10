using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1231
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int n1, n2;
            List<string> set1, set2;
            while (true)
            {
                //Revisando EOF
                if (String.IsNullOrEmpty((data = Console.ReadLine())))
                {
                    break;
                }
                //Obtiendo el tamaño de todos los dos conjuntos
                values = data.Split(' ');
                n1 = int.Parse(values[0]);
                n2 = int.Parse(values[1]);
                //Adquiriendo conjunto 1
                set1 = new List<string>();
                for(int i = 0; i < n1; ++i)
                    set1.Add(Console.ReadLine());
                //Adquiriendo conjunto 2
                set2 = new List<string>();
                for (int i = 0; i < n2; ++i)
                    set2.Add(Console.ReadLine());
                if(n2 == 0)
                {
                    Console.WriteLine("N");
                    continue;
                }
                if(set1.TrueForAll(item => item.Contains('0') && !item.Contains('1')) && set2.TrueForAll(item => item.Contains('0') && !item.Contains('1')))
                {
                    Console.WriteLine("S");
                    continue;
                }
                if (set1.TrueForAll(item => item.Contains('1') && !item.Contains('0')) && set2.TrueForAll(item => item.Contains('1') && !item.Contains('0')))
                {
                    Console.WriteLine("S");
                    continue;
                }

            }
            Console.ReadKey();
        }
    }
}