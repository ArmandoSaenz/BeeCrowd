using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio_2002
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Equals(Point point) => X == point.X && Y == point.Y;
        public bool Equals(int x, int y) => X == x && Y == y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Djkistra
    {
        long Comp (KeyValuePair<Point, long> item) => item.Value;
        public List<KeyValuePair<Point, long>> queue { get; set; } = new List<KeyValuePair<Point, long>>();
        public bool Empty => queue.Count == 0;
        public KeyValuePair<Point, long> Top() => queue.First();
        public void Pop()
        {
            queue.RemoveAt(0);
        }
        public void Push(Point point, long cost)
        {
            if (Empty)
            {
                queue.Add(new KeyValuePair<Point, long>(point, cost));
            }
            else
            {
                if (queue[0].Value > cost)
                    queue.Insert(0, new KeyValuePair<Point, long>(point, cost));
                else
                {
                    int id = queue.FindIndex(item => item.Value >= cost);
                    if(id == -1)
                        queue.Add(new KeyValuePair<Point, long>(point, cost));
                    else
                        queue.Insert(id, new KeyValuePair<Point, long>(point, cost));
                }

            }   
        }
    }
    internal class Program
    {
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
            long[,] board;
            bool[,] procesado;
            Djkistra dijkstra;
            KeyValuePair<Point, long> current;
            string data;
            string[] values;
            int n, m, x, y;
            long cost;
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
                procesado = new bool[n, m];
                //Get the cells cost
                for (int i = 0; i < n; i++)
                {
                    data = Console.ReadLine();
                    values = data.Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        board[i, j] = long.Parse(values[j]);
                    }
                }
                dijkstra = new Djkistra();
                dijkstra.Push(new Point(0, 0), 0);
                //Dikjistra algorithm
                while (!dijkstra.Empty)
                {
                    current = dijkstra.Top();
                    dijkstra.Pop();
                    (cost, x, y) = (current.Value, current.Key.X, current.Key.Y);
                    if (procesado[x, y])
                        continue;
                    procesado[x, y] = true;
                    if (x == n - 1 & y == m - 1)
                    {
                        Console.WriteLine(cost);
                        break;
                    }
                    if (x - 1 >= 0 && !procesado[x - 1, y])
                        dijkstra.Push(new Point(x - 1, y), cost + C(board[x - 1, y], board[x, y]));
                    if (x +1 < n && !procesado[x + 1, y])
                        dijkstra.Push(new Point(x + 1, y), cost + C(board[x + 1, y], board[x, y]));
                    if (y - 1 >= 0 && !procesado[x, y - 1])
                        dijkstra.Push(new Point(x, y - 1), cost + C(board[x, y - 1], board[x, y]));
                    if (y + 1 < m && !procesado[x, y + 1])
                        dijkstra.Push(new Point(x, y+1), cost + C(board[x, y + 1], board[x, y]));

                }
            }
        }
    }
}
