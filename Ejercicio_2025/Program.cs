using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_2025
{
    class Program
    {
        static string ReplaceWord(string word)
        {
            string tmp=word;
            switch(word.Length)
            {
                case 11:
                    if (word.EndsWith(".") && word.Substring(1, 8) == "oulupukk")
                        tmp = "Joulupukki.";
                    break;
                case 10:
                    if (word.Substring(1,8)=="oulupukk")
                        tmp = "Joulupukki";
                    break;
                
            }
            return tmp;
        }
        static void Main(string[] args)
        {
            string line;
            int n;
            List<string> words;
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; ++i)
            {
                line = Console.ReadLine();
                words = line.Split(' ').ToList();
                words = words.Select(word => word.Length==10 || word.Length==11 ? ReplaceWord(word) : word).ToList();
                Console.WriteLine(String.Join(" ", words));
            }
        }
    }
}
