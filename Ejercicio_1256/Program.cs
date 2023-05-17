using System;
using System.Collections;
using System.Collections.Generic;
class URI
{
    static void Main()
    {
        List<List<int>> Hash = new List<List<int>>();
        int N, M, C;
        int[] values;
        string line;
        string[] data;
        line = Console.ReadLine();
        N = int.Parse(line);
        while (N > 0)
        {
            line = Console.ReadLine();
            data = line.Split(' ');
            M = int.Parse(data[0]);
            Hash.Clear();
            for (int i = 0; i < M; ++i)
                Hash.Add(new List<int>());
            line = Console.ReadLine();
            data = line.Split(' ');
            values = Array.ConvertAll(data, s => int.Parse(s));
            foreach (int item in values)
                Hash[item % M].Add(item);
            C = 0;
            foreach (List<int> list in Hash)
            {
                line = String.Join(" -> ", list.ToArray());
                Console.WriteLine("{0} -> {1}{2}", C, line, line == "" ? "\\" : " -> \\");
                ++C;
            }
            if (N > 1)
                Console.WriteLine();
            --N;
        }
    }
}