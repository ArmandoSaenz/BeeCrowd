using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1238
{
    internal class Program
    {
        static void Combine(Queue<char> word1, Queue<char> word2, Queue<char> word3)
        {
            if (word1.Count > 0)
                word3.Enqueue(word1.Dequeue());
            if (word2.Count > 0)
                word3.Enqueue(word2.Dequeue());
            if (word1.Count == 0 && word2.Count == 0)
                return;
            else
                Combine(word1, word2, word3);

        }
        static void Main(string[] args)
        {
            int totalcases = int.Parse(Console.ReadLine());
            Queue<char> word1, word2, newword;
            for(int ncase = 0; ncase < totalcases; ++ncase)
            {
                string data = Console.ReadLine();
                string[] words = data.Split(' ');
                word1 = new Queue<char>(words[0]);
                word2 = new Queue<char>(words[1]);
                newword = new Queue<char>();
                Combine(word1, word2, newword);
                Console.WriteLine(String.Concat(newword));
            }
        }
    }
}
