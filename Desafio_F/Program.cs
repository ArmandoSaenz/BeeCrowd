using System;

namespace Desafio_F
{
    class URI
    {
        int[] SubArray(int[] array, int index)
        {
            int c = array.Length;
            int[] newArray = new int[c-1];
            for (int i = 0; i < c; ++i)
                if (i < c)
                    newArray[i] = array[i];
                else if(i > c)
                    newArray[i-1] = array[i];
            return newArray;
        }

        int Costo(int[] cost, int[] key,int i, int j)
        {
            return cost[i] + cost[j] + Math.Abs(key[i] - key[j]);
        }
        
        bool Premios(int time, int limit,int[] cost, int[] key)
        {
            int nitem = cost.Length;
            int costo;
            if(nitem == 2)
            {
                costo = time + Costo(cost, key, 0, 1);
                return costo <= limit ? true : false;
            }
        }
    }
    /*
    class Path
    {
        public int TimeLimit { get; private set; }
        public int NumBox { get; private set; }
        public Box[] Boxes { get; set; }
        public int Cost(int i, int j)
        {
            return Boxes[i].Time + Boxes[j].Time + Math.Abs(i - j);
        }

        public int[] Draw(int move)
        {
            int[] draws;
            int countDraws = 0;
            int history = MinHistory(move);
            int i = 0;
            foreach (Box box in Boxes)
            { 
                if(box.Moves == move && box.History == history)
                {
                    countDraws++;
                }
            }
            draws = new int[countDraws];
            
            foreach (Box box in Boxes)
            {
                if (box.Moves == move && box.History == history)
                {
                    draws[i] = box.Index;
                    i++;
                }
            }
            return draws;
        }
        public int NextNode(int move)
        {
            int iNode = -1;
            int cost = int.MaxValue;
            for(int i = 0; i<this.NumBox;i++)
            {
                if(this.Boxes[i].Moves == move && this.Boxes[i].History < TimeLimit && this.Boxes[i].History < cost)
                {
                    iNode = i;
                    cost = this.Boxes[i].History;
                }
            }
            return iNode;
        }
        static public Path Analyse(Path graph, int iNode, int move)
        {
            int cost1 = 0;
            Path graphtmp1 = null, graphtmp2 = null;
            graph.Boxes[iNode].Review = true;
            for(int i = 0; i < graph.NumBox; ++i)
            {
                if (graph.Boxes[i].Review)
                    continue;
                cost1 = graph.Cost(iNode, i) + graph.Boxes[iNode].History;
                graph.Boxes[i].Moves = move;
                graph.Boxes[i].History = cost1;
                graph.Boxes[i].PreviusNode = graph.Boxes[iNode];
            }
            if (graph.NextNode(move) >= 0)
            {
                int[] draws = graph.Draw(move);
                int i = 1;
                graphtmp1 = Path.Analyse(graph.Clone(), draws[0], move + 1);
                while (i < draws.Length)
                {
                    graphtmp2 = Path.Analyse(graph.Clone(), draws[i], move + 1);
                    if (graphtmp2.GetMaxMoves() > graph.GetMaxMoves())
                        graphtmp1 = graphtmp2;
                    i++;
                }
                return graphtmp1.GetMaxMoves() > graph.GetMaxMoves() ? graphtmp1 : graph;
            }
            else
                return graph;
            
        }
        public Path(int numBox, int timeLimit)
        {
            TimeLimit = timeLimit;
            NumBox = numBox;
            Boxes = new Box[NumBox];
            for (int i = 0; i < numBox; i++)
                Boxes[i] = new Box() { Index = i};
        }
        public Path()
        { }
        public int MaxMove()
        {
            int maxMoves = 0;
            foreach (Box box in Boxes)
            {
                if (box.Moves > maxMoves)
                    maxMoves = box.Moves;
            }
            return maxMoves;
        }
        public int MinHistory(int move)
        {
            int minHistory = int.MaxValue;
            foreach (Box box in Boxes)
            {
                if (box.Moves == move && box.History < minHistory)
                {
                    minHistory = box.History;
                }
            }
            return minHistory;
        }
        public int GetMaxMoves()
        {
            int maxMoves = 0;
            foreach(Box box in Boxes)
            {
                if(box.History <= TimeLimit && box.Moves > maxMoves)
                    maxMoves = box.Moves;
            }
            return maxMoves;
        }

        public Path Clone()
        {
            Path tmp = new Path();
            tmp.Boxes = new Box[this.NumBox];
            tmp.NumBox = this.NumBox;
            tmp.TimeLimit = this.TimeLimit;
            foreach(Box box in this.Boxes)
            {
                tmp.Boxes[box.Index] = box.Clone() as Box;
            }
            return tmp;
        }
    }
    class Box : ICloneable
    {
        public int Time { get; set; } = 0;
        public int History { get; set; } = 0;
        public Box PreviusNode { get; set; } = null;
        public int Moves { get; set; } = 1;
        public bool Review { get; set; } = false;
        public int Index { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class URI
    {
        static void Main(string[] args)
        {
            Path path, tmppath;
            int n, numBox, seconds;
            string data;
            string[] datos;
            int move, nextNode, maxMove;
            int moves;
            n = int.Parse(Console.ReadLine());
            for (int rep = 0; rep < n; rep++)
            {
                data = Console.ReadLine();
                datos = data.Split(' ');
                numBox = int.Parse(datos[0]);
                seconds = int.Parse(datos[1]);
                path = new Path(numBox, seconds);
                data = Console.ReadLine();
                datos = data.Split(' ');
                for (int i = 0; i < path.NumBox; i++)
                {
                    path.Boxes[i].Time = path.Boxes[i].History = int.Parse(datos[i]);
                }
                tmppath = path.Clone();
                moves = 0;
                for (int i = 0; i < numBox; i++)
                {
                    path.Boxes[i].Review = true;
                    maxMove = Path.Analyse(path,i, 2).GetMaxMoves();
                    moves = maxMove > moves ? maxMove : moves;
                    path = tmppath.Clone();
                }
                Console.WriteLine(moves);
            }
            Console.ReadLine();
        }
    }
    */
}
