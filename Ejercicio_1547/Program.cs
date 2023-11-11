using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1547
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int QT, S;
            List<int> answers;
            string data;
            string[] datas;
            int index;
            int distance;
            while((data = Console.ReadLine())!= null)
            {
                datas = data.Split(' ');
                QT = int.Parse(datas[0]);
                S = int.Parse(datas[1]);
                data = Console.ReadLine();
                datas = data.Split(' ');
                answers = Array.ConvertAll<string, int>(datas, int.Parse).ToList();
                index = answers.FindIndex(x => x == S);
                if (index != -1)
                    Console.WriteLine($"{index + 1}");
                else
                {
                    answers = answers.Select(x => Math.Abs(x - S)).ToList();
                    distance = answers.Min();
                    index = answers.FindIndex(item => item == distance);
                    Console.WriteLine($"{index+1}");
                }

            }
        }
    }
}
