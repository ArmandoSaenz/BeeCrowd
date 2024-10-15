using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
namespace Ejercicio_1785
{
    internal class Program
    {
        static int[] invalids = new int[] { 0, 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999 };
        static int[] sol = new int[10000];
        static int krapekar(int X)
        {
            if (invalids.Contains(X))
            {
                return -1;
            }
            int cnt = 0;
            int hi, lo;
            while (X != 6174)
            {
                (lo, hi) = Combinacion(X);
                X = hi - lo;
                cnt = cnt + 1;
            }
            return cnt;
        }

        static (int, int) Combinacion(int X)
        {
            var digits = X.ToString().PadLeft(4, '0').Select(digit => int.Parse(digit.ToString())).ToArray();
            return (digits.OrderBy(x => x).Aggregate((acc, d) => acc * 10 + d), digits.OrderByDescending(x => x).Aggregate((acc, d) => acc * 10 + d));
        }

        [STAThreadAttribute]
        static void Main()
        {
            for (int i = 0; i <= 9999; i++)
            {
                sol[i] = krapekar(i);
                Console.WriteLine($"Case {i}: {sol[i]}");
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Texto plano|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, "int[] Solutions = new int[]{"+ String.Join(",", sol) +"}; ");
            }
        }
    }
}