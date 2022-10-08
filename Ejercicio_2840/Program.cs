using System;
public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string[] resultado = s.Split(' ');
        int R = int.Parse(resultado[0]);
        int L = int.Parse(resultado[1]);
        float pi = 3.1415f;
        double V = (4d / 3d) * (pi * R * R * R);
        Console.WriteLine(L / (int)V);
        Console.ReadLine();
    }
}