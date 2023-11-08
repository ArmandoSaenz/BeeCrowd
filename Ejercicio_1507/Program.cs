using System;

namespace Ejercicio_1507
{
    internal class Program
    {
        static bool isSubsequence(string origin, string seed, int init)
        {
            int index = origin.IndexOf(seed[0], init);
            if (index == -1)
                return false;
            else
                return seed.Length == 1 ? true : isSubsequence(origin, seed.Remove(0, 1), index+1);
        }
        static void Main(string[] args)
        {
            int tc, total;
            string origin, seed;
            tc = int.Parse(Console.ReadLine());
            for(int i = 0; i < tc; ++i)
            {
                origin = Console.ReadLine();
                total = int.Parse(Console.ReadLine());
                for(int j = 0; j < total; ++j)
                {
                    seed = Console.ReadLine();
                    if (seed.Length > origin.Length)
                        Console.WriteLine("No");
                    else if (seed.Length == origin.Length)
                        Console.WriteLine(seed == origin ? "Yes" : "No");
                    else
                        Console.WriteLine(isSubsequence(origin, seed, 0) ? "Yes" : "No");
                }
            }
        }
    }
}
