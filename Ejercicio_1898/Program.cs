using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1898
{
    internal class Program
    {
        static (double,double) GetMount(string arg)
        {
            int numpoints = arg.Count(character => character == '.');
            double unities = 0l, decimals = 0l;
            string[] mounts;
            if (numpoints == 0)
            {
                unities = double.Parse(arg);
            }
            else
            {
                mounts = arg.Split('.');
                double.TryParse(mounts[0], out unities);
                switch (mounts[1].Length)
                {
                    case 0:
                        decimals = 0L;
                        break;
                    case 1:
                        decimals = double.Parse(mounts[1]+"0");
                        break;
                    case 2:
                        decimals = double.Parse(mounts[1]);
                        break;
                    default:
                        decimals = double.Parse($"{mounts[1][0]}{mounts[1][1]}");
                        break;
                }
            }
            return (unities, decimals);
        }
        static void Main(string[] args)
        {
            string data1, data2;
            string CPF;
            double mount1unities, mount1decimals, mount2unities, mount2decimals;
            double totalmountunities, totalmountdecimals;
            List<char> ValidCharacters = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
            data1 = Console.ReadLine();
            data2 = Console.ReadLine();
            List<char> data = data1.ToList();
            data.RemoveAll(item => !ValidCharacters.Contains(item));
            CPF = String.Concat(data.GetRange(0, 11));
            data.RemoveRange(0, 11);
            string tmp = String.Concat<char>(data);
            (mount1unities, mount1decimals) = GetMount(tmp);
            data = data2.ToList();
            data.RemoveAll(item => !ValidCharacters.Contains(item));
            tmp = String.Concat<char>(data);
            (mount2unities, mount2decimals) = GetMount(tmp);
            totalmountdecimals = mount1decimals + mount2decimals;
            totalmountunities = mount1unities + mount2unities + (int)(totalmountdecimals / 100.0);
            Console.WriteLine($"cpf {CPF}");
            Console.WriteLine($"{totalmountunities}.{(totalmountdecimals < 100 ? totalmountdecimals.ToString().PadLeft(2,'0'): totalmountdecimals.ToString().Remove(0,1))}");
        }
    }
}