using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1357
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Data;
            string[] L1, L2, L3;
            string L1tmp, L2tmp;
            string encrypt;
            int D;
            do
            {
                D = int.Parse(Console.ReadLine());
                if (D == 0)
                    break;
                encrypt = Console.ReadLine();
                if (encrypt == "S")
                {
                    Data = Console.ReadLine();
                    L1 = new string[D];
                    L2 = new string[D];
                    L3 = new string[D];
                    for (int i = 0; i < D; i++)
                    {
                        (L1tmp, L2tmp) = S2B(Data[i]);
                        L1[i] = L1tmp;
                        L2[i] = L2tmp;
                        L3[i] = "..";
                    }
                    Console.WriteLine(String.Join(" ", L1));
                    Console.WriteLine(String.Join(" ", L2));
                    Console.WriteLine(String.Join(" ", L3));
                }
                else
                {
                    Data = "";
                    L1tmp = Console.ReadLine();
                    L2tmp = Console.ReadLine();
                    Console.ReadLine();
                    L1 = L1tmp.Split(' ');
                    L2 = L2tmp.Split(' ');
                    for (int i = 0; i < D; i++)
                        Data += B2S(L1[i], L2[i]);
                    Console.WriteLine(Data);
                }
            } while (true);
        }
        static string B2S(string L1, string L2)
        {
            if (L1[0] == '*' && L1[1] == '.' && L2[0] == '.' && L2[1] == '.')
                return "1";
            else if (L1[0] == '*' && L1[1] == '.' && L2[0] == '*' && L2[1] == '.')
                return "2";
            else if (L1[0] == '*' && L1[1] == '*' && L2[0] == '.' && L2[1] == '.')
                return "3";
            else if (L1[0] == '*' && L1[1] == '*' && L2[0] == '.' && L2[1] == '*')
                return "4";
            else if (L1[0] == '*' && L1[1] == '.' && L2[0] == '.' && L2[1] == '*')
                return "5";
            else if (L1[0] == '*' && L1[1] == '*' && L2[0] == '*' && L2[1] == '.')
                return "6";
            else if (L1[0] == '*' && L1[1] == '*' && L2[0] == '*' && L2[1] == '*')
                return "7";
            else if (L1[0] == '*' && L1[1] == '.' && L2[0] == '*' && L2[1] == '*')
                return "8";
            else if (L1[0] == '.' && L1[1] == '*' && L2[0] == '*' && L2[1] == '.')
                return "9";
            else return "0";
        }
        static (string, string) S2B(char d)
        {
            switch (d)
            {
                case '1':
                    return ("*.", "..");
                case '2':
                    return ("*.", "*.");
                case '3':
                    return ("**", "..");
                case '4':
                    return ("**", ".*");
                case '5':
                    return ("*.", ".*");
                case '6':
                    return ("**", "*.");
                case '7':
                    return ("**", "**");
                case '8':
                    return ("*.", "**");
                case '9':
                    return (".*", "*.");
                case '0':
                    return (".*", "**");
                default:
                    return ("", "");
            }
        }
    }
}
