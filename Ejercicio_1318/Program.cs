using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class URI
{
    static void Main()
    {
        int N, M;
        List<string> tickets, originales, duplicados;
        string line;
        string[] data;
        while (true)
        {
            line = Console.ReadLine();
            if (line == "0 0")
                break;
            data = line.Split(' ');
            N = int.Parse(data[0]);
            M = int.Parse(data[1]);
            line = Console.ReadLine();
            tickets = line.Split(' ').ToList();
            originales = tickets.Distinct().ToList();
            duplicados = originales.FindAll(ticket => tickets.Count(t => t == ticket) > 1);
            Console.WriteLine(duplicados.Count);
        }
    }
}