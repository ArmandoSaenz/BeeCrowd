using System;

class URI
{
    static void Main()
    {
        int[] sol = new int[] { 1, 3, 7, 11, 17, 23, 31, 39, 49, 59, 71, 83, 97, 111, 127, 143, 161, 179, 199, 219, 241, 263, 287, 311, 337, 363, 391, 419, 449, 479, 511, 543, 577, 611, 647, 683, 721, 759, 799, 839, 881, 923, 967, 1011, 1057, 1103, 1151, 1199, 1249, 1299 };
        int T, N;
        string line;
        line = Console.ReadLine();
        T = int.Parse(line);
        while (T > 0)
        {
            line = Console.ReadLine();
            N = int.Parse(line);
            Console.WriteLine(sol[N - 1]);
            T--;
        }
    }
}
/*
using System;
using System.Collections;
using System.Collections.Generic;
class URI
{
    static void Main()
    {
        List<List<int>> towers = new List<List<int>>();
        List<int> tower;
        int T, N, max;
        string line;
        line = Console.ReadLine();
        T = int.Parse(line);
        while(T > 0)
        {
            line = Console.ReadLine();
            N = int.Parse(line);
            towers.Clear();
            for(int i = 0; i < N; ++i)
                towers.Add(new List<int>());
            for (max = 1; max < int.MaxValue; ++max)
            {
                tower = towers.Find(list => list.Count > 0 && Math.Sqrt(list[list.Count - 1] + max) == (int)Math.Sqrt(list[list.Count - 1] + max));
                if (tower == null)
                {
                    tower = towers.Find(list => list.Count == 0);
                    if (tower == null)
                        break;
                    else
                        tower.Add(max);
                }
                else
                    tower.Add(max);
            }
            Console.WriteLine(max - 1);
            T--;
        }
    }
}
*/