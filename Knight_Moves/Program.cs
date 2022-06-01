using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knight_Moves
{
    internal class Program
    {
        static int GetUnidad(int value)
        {
            return value % 10;
        }
        static int GetDecena(int value)
        {
            return (value / 10) % 10;
        }

        static bool ValidPos(int pos)
        {
            return pos > 10 && GetUnidad(pos) <= 8 && GetUnidad(pos) >0 && GetDecena(pos) <= 8;
        }
        static int Coord2Pos(string coord)
        {
            int pos = 0;
            coord = coord.ToLower();
            pos = ((int)coord[0] - 96) * 10 + (int)coord[1] - 48;
            return pos;
        }
        static void PushList(List<int> ori, List<int> dest)
        {
            foreach (int v in ori)
                dest.Add(v);
        }
        static void Main(string[] args)
        {
            int[] moves = { 21, 19, 8, -12, -21, -19, -8, 12 };
            List<int> anterior = new List<int>();
            List<int> actual = new List<int>();
            List<int> siguiente = new List<int>();
            int nmoves = 0, fin = 0, pos;
            string reg;
            string[] data;
            while (true)
            {
                reg = Console.ReadLine();
                if (String.IsNullOrEmpty(reg) || String.IsNullOrWhiteSpace(reg))
                {
                    break;
                }
                data = reg.Split(' ');
                siguiente.Clear();
                siguiente.Add(Coord2Pos(data[0]));
                fin = Coord2Pos(data[1]);
                anterior.Clear();
                actual.Clear();
                nmoves = 0;
                do
                {
                    PushList(siguiente, actual);
                    siguiente.Clear();
                    nmoves++;
                    foreach (int v in actual)
                        foreach (int mv in moves)
                        {
                            pos = v + mv;
                            if (ValidPos(pos) && !actual.Contains(pos) && !anterior.Contains(pos))
                                siguiente.Add(pos);
                        }
                    PushList(actual, anterior);
                    actual.Clear();
                }
                while (!siguiente.Contains(fin));
                Console.WriteLine("El numero de movimientos es {0}", nmoves);
            }
        }
    }
}
