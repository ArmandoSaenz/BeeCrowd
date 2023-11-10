using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2552
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            int[,] board;
            int[,] bread;
            int[] dimmension;
            int[] row;
            while (String.IsNullOrEmpty(data = Console.ReadLine()))
            {
                dimmension = Array.ConvertAll<string, int>(data.Split(' '), int.Parse);
                board = new int[dimmension[0] + 2, dimmension[1] + 2];
                for (int i = 1; i <= dimmension[0]; ++i)
                {
                    data = Console.ReadLine();
                    row = Array.ConvertAll<string, int>(data.Split(' '), int.Parse);
                    for (int j = 1; j <= dimmension[1]; ++j)
                        board[i, j] = row[j - 1];
                }
                bread = (int[,])board.Clone();
                for (int i = 0; i <= dimmension[0]; ++i)
                    for (int j = 0; j <= dimmension[1]; ++j)
                    {
                        switch (board[i, j])
                        {
                            case 0:
                                bread[i, j] = board[i + 1, j] + board[i - 1, j] + board[i, j + 1] + board[i, j - 1];
                                break;
                            case 1:
                                bread[i, j] = 9;
                                break;
                        }
                        if (j != dimmension[1])
                            Console.Write($"{bread[i,j]} ");
                        else
                            Console.WriteLine(bread[i,j]);
                    }
            }
            Console.ReadLine();
        }
    }
}