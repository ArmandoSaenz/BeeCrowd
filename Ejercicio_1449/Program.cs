using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1449
{
    internal class Program
    { 
        static string[] Translate(string[] words, Dictionary<string, string> trans)
        {
            int can = words.Length;
            if (can == 0)
                return null;

            for(int i = 0; i <can; ++i)
            {
                words[i] = trans.ContainsKey(words[i]) ? trans[words[i]] : words[i];
            }
            return words;
        }
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string line;
            string[] data;
            int n, m;
            for(int test = 0; test<cases; ++test )
            {
                line = Console.ReadLine();
                data = line.Split(' ');
                n = int.Parse((string)data[0]);
                m = int.Parse((string)data[1]);
                Dictionary<string, string> map = Enumerable.Repeat("",n).ToDictionary(x => Console.ReadLine(), x => Console.ReadLine());
                List<string> lyrics = Enumerable.Repeat("",m).Select(x => Console.ReadLine()).ToList();
                List<string[]> words = lyrics.Select(x => String.IsNullOrEmpty(x) ? null :x.Split()).ToList();
                List<string[]> translates = words.Select(word => Translate(word, map)).ToList();
                translates.ForEach(x => Console.WriteLine(String.Join(" ",x)));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
