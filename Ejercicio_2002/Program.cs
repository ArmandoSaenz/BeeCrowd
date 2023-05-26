using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2002
{
    internal class Program
    {
        static long[,] board;
        static List<long> costs;
        static List<int> next;
        static (int, int) Id2Pos(int id, int ncols)
        {
            int i = id / ncols;
            int j = id % ncols;
            return (i, j);
        }
        static int Pos2Id(int i, int j, int ncols)
        {
            int id = i * ncols + j;
            return id;
        }
        static (bool, long) MoveUp(int x, int y, int N)
        {
            if (x + 1 >= N)
                return (false, 0);
            return (true, C(board[x, y], board[x + 1, y]));
        }
        static (bool, long) MoveDown(int x, int y)
        {
            if (x - 1 < 0)
                return (false, 0);
            return (true, C(board[x, y], board[x - 1, y]));

        }
        static (bool, long) MoveLeft(int x, int y)
        {
            if (y - 1 < 0)
                return (false, 0);
            return (true, C(board[x, y], board[x, y - 1]));

        }
        static (bool, long) MoveRight(int x, int y, int M)
        {
            if (y + 1 >= M)
                return (false, 0);
            return (true, C(board[x, y], board[x, y + 1]));
        }
        static long Complement(long x)
        {
            switch (x % 4)
            {
                case 0:
                    return x;
                case 1:
                    return 1L;
                case 2:
                    return x + 1;
                default:
                    return 0L;
            }
        }
        static long C(long x, long y)
        {
            long min = Math.Min(x, y);
            long max = Math.Max(x, y);
            return Complement(max) ^ Complement(min - 1);
        }
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int n, m, x, y, id, idnext, lastId;
            long cost;
            bool valido;
            while (true)
            {
                //Read first line
                if (String.IsNullOrEmpty(data = Console.ReadLine()))
                    break;
                //get the dimension
                values = data.Split(' ');
                n = int.Parse(values[0]);
                m = int.Parse(values[1]);
                //Create the board
                board = new long[n, m];
                costs = new List<long>(new long[n*m]);
                lastId = n * m - 1;
                next = new List<int>();
                //Get the cells cost
                for (int i = 0; i < n; i++)
                {
                    data = Console.ReadLine();
                    values = data.Split(' ');
                    for (int j = 0; j < m; j++)
                        board[i, j] = long.Parse(values[j]);
                }
                next.Add(0);
                //Dikjistra algorithm
                while (next.Count > 0)
                {
                    id = next.First();
                    (x, y) = Id2Pos(id, m);
                    {
                        idnext = Pos2Id(x + 1, y, m);
                        (valido, cost) = MoveUp(x, y, n);
                        cost += costs[id];
                        if (valido && idnext != 0 && (costs[idnext] == 0 || cost < costs[idnext]))
                        {
                            costs[idnext] = cost;
                            if(!next.Contains(idnext))
                                next.Add(idnext);
                        }

                        idnext = Pos2Id(x - 1, y, m);
                        (valido, cost) = MoveDown(x, y);
                        cost += costs[id];
                        if (valido && idnext != 0 && (costs[idnext] == 0 || cost < costs[idnext]))
                        {
                            costs[idnext] = cost;
                            if (!next.Contains(idnext))
                                next.Add(idnext);
                        }

                        idnext = Pos2Id(x, y + 1, m);
                        (valido, cost) = MoveRight(x, y, m);
                        cost += costs[id];
                        if (valido && idnext != 0 && (costs[idnext] == 0 || cost < costs[idnext]))
                        {
                            costs[idnext] = cost;
                            if (!next.Contains(idnext))
                                next.Add(idnext);
                        }
                        idnext = Pos2Id(x, y - 1, m);
                        (valido, cost) = MoveLeft(x, y);
                        cost += costs[id];
                        if (valido && idnext != 0 && (costs[idnext] == 0 || cost < costs[idnext]))
                        {
                            costs[idnext] = cost;
                            if (!next.Contains(idnext))
                                next.Add(idnext);
                        }
                        next.RemoveAt(0);
                    }
                }
                Console.WriteLine("{0}", costs[lastId]);
            }
        }
    }
}
