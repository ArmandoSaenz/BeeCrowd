using System;
using System.Collections.Generic;

namespace Ejercicio_1077
{
    internal class Program
    {
        static Dictionary<char, int> op;
        static void sieve()
        {
            op['+'] = 1;
            op['-'] = 1;
            op['/'] = 2;
            op['*'] = 2;
            op['^'] = 3;
            op['('] = 0;
            op[')'] = 0;
        }
        static void infixToPostfix(string str)
        {
            Stack<char> q = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetterOrDigit(str[i])) Console.Write(str[i]);
                else if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/' || str[i] == '^')
                {
                    if (q.Count > 0)
                    {
                        while (op[str[i]] <= op[q.Peek()])
                        {
                            Console.Write(q.Peek());
                            q.Pop();
                            if (q.Count == 0) break;
                        }
                    }
                    q.Push(str[i]);
                }
                else if (str[i] == '(')
                {
                    q.Push('(');
                }
                else if (str[i] == ')')
                {
                    while (q.Peek() != '(')
                    {
                        Console.Write(q.Peek());
                        q.Pop();
                    }
                    q.Pop();
                }
            }
            while (q.Count > 0)
            {
                Console.Write(q.Peek());
                q.Pop();
            }
            Console.WriteLine();
        }

        static void Main()
        {
            op = new Dictionary<char, int>();
            sieve();
            int t = int.Parse(Console.ReadLine());
            string str;
            for (int i = 0; i < t; i++)
            {
                str = Console.ReadLine();
                infixToPostfix(str);
            }
            //Console.ReadLine();
        }
    }
}
