using System;
using System.Collections;
using System.Collections.Generic;

class URI
{
    static void Main()
    {
        int fs, ts, index, w;
        List<string> signaturesori, signatures;
        string line;
        string[] data;
        while (true)
        {
            line = Console.ReadLine();
            if (line == "0")
                break;
            ts = int.Parse(line);
            signaturesori = new List<string>();
            signatures = new List<string>();
            for (int i = 0; i < ts; ++i)
            {
                line = Console.ReadLine();
                data = line.Split(' ');
                signaturesori.Add(data[0]);
                signatures.Add(data[1]);
            }
            line = Console.ReadLine();
            ts = int.Parse(line);
            fs = 0;
            for (int i = 0; i < ts; ++i)
            {
                line = Console.ReadLine();
                data = line.Split(' ');
                index = signaturesori.IndexOf(data[0]);
                w = 0;
                for (int j = 0; j < data[1].Length; ++j)
                {
                    w += data[1][j] == signatures[index][j] ? 0 : 1;
                    if (w > 1) break;
                }
                fs += w > 1 ? 1 : 0;
            }
            Console.WriteLine(fs);
        }
    }
}