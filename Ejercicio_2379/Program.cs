using System;
using System.Collections;
class URI
{
    static void PrintArray(BitArray bits)
    {
        foreach (bool b in bits)
        {
            Console.Write(b ? 1 : 0);
        }
    }

    static void Main(string[] args)
    {
        BitArray logs1 = new BitArray(6);
        PrintArray(logs1);
        Console.WriteLine();
        PrintArray(logs1.Not().LeftShift(3));
        Console.ReadLine();
    }
}