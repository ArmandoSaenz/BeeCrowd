using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int g, p, s, points;
            List<int>[] arrives;
            List<int> scoring;
            Dictionary<int, int> score;
            List<KeyValuePair<int, int>> winners;
            while (true)
            {
                if ((data = Console.ReadLine()) == "0 0")
                    break;
                values = data.Split(' ');
                g = int.Parse(values[0]);
                p = int.Parse(values[1]);
                arrives = new List<int>[g];
                for (int i = 0; i < g; ++i)
                {
                    data = Console.ReadLine();
                    values = data.Split(' ');
                    arrives[i] = new List<int>(Array.ConvertAll<string, int>(values, int.Parse));
                }
                data = Console.ReadLine();
                s = int.Parse(data);
                for (int i = 0; i < s; ++i)
                {
                    data = Console.ReadLine();
                    values = data.Split(' ');
                    scoring = new List<int>(Array.ConvertAll<string, int>(values, int.Parse));
                    score = new Dictionary<int, int>();
                    for (int j = 0; j < p; ++j)
                    {
                        points = arrives.Sum(item => item[j] > scoring[0] ? 0 : scoring[item[j]]);
                        score.Add(j + 1, points);
                    }
                    winners = score.ToList();
                    points = score.Values.Max();
                    winners = winners.FindAll(item => item.Value == points);
                    Console.WriteLine(String.Join(" ", Array.ConvertAll<KeyValuePair<int, int>, string>(winners.ToArray(), item => item.Key.ToString())));
                }
            }
            Console.ReadLine();
        }
    }
}