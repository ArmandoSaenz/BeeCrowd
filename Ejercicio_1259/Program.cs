using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1259
{
    internal class Program
    {
        static void ReadNumbers(int c, int t,List<int> even, List<int> odd)
        {
            if(c < t)
            {
                ++c;
                int number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                    even.Add(number);
                else 
                    odd.Add(number);
                ReadNumbers(c, t, even, odd);
            }
        }
        static void Main(string[] args)
        {
            List<int> even = new List<int>(), 
                      odd = new List<int>();
            int t = int.Parse(Console.ReadLine());
            ReadNumbers(0, t, even,odd);
            even.Sort();
            odd.Sort();
            odd.Reverse();
            Console.WriteLine(String.Join(Environment.NewLine, even));
            Console.WriteLine(String.Join(Environment.NewLine, odd));
            Console.ReadLine();
        }
    }

}
