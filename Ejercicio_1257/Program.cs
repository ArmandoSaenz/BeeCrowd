using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1257
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int InitValue = (int)'A';
            int HashCode = 0;
            string data;
            Dictionary<int, char> Elements;
            int words;
            int cases = int.Parse(Console.ReadLine());
            for(int i = 0; i < cases; ++i)
            {
                words = int.Parse(Console.ReadLine());
                HashCode = 0;
                for(int j = 0; j < words; ++j)
                {
                    data = Console.ReadLine();
                    var Lista = data.ToList().Select((value, key) => new { Key = key, Value = value });
                    Elements = Lista.ToDictionary(item => item.Key, item => item.Value);
                    HashCode += Elements.Sum(item => item.Key + j + ((int)item.Value - InitValue));
                }
                Console.WriteLine(HashCode);
            }
            Console.ReadLine();
        }
    }
}
