using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1726
{
    internal class Program
    {
        static List<char> String2List(string data)
        {
            if (data.Length == 2)
            {
                return new List<char>();
            }
            else
            {
                string set = data.Substring(1, data.IndexOf('}'));
                return set.ToList();
            }
        }

        static List<char> Add(List<char> set1, List<char> set2)
        {
            List<char> set;
            set1.AddRange(set2);
            set = set1.Distinct().ToList();
            return set;
        }
        static List<char> Rest(List<char> set1, List<char> set2)
        {
            List<char> set = set1.Except(set2).ToList();
            return set;
        }
        static List<char> Intersection(List<char> set1, List<char> set2)
        {
            List<char> set = set1.FindAll(item => set2.Contains(item));
            return set;
        }
        static void Main(string[] args)
        {
            List<List<char[]>> sets;
            string data;
            while(String.IsNullOrEmpty((data = Console.ReadLine())))
            {
                
            }
    }
}
