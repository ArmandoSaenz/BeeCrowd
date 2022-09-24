using System;

namespace Ejercicio_2379
{
    class Trunk
    {
        Dancer[] OldDancers { get; set; } = new Dancer[0];
        Dancer[] NewDancers { get; set; } = new Dancer[0];
        public int Count { get => OldDancers.Length; }

        public bool IsCrash(Dancer NewDancer)
        {
            foreach (Dancer dancer in OldDancers)
            {
                if (NewDancer.CurDirection != dancer.CurDirection)
                {
                    dancer.IsChangeDir = true;
                    return true;
                }
            }
            return false;
        }
        private void Remove(Dancer oldDancer)
        {
            bool encontrado = false;
            int size = OldDancers.Length;
            Dancer[] tmpDancers = new Dancer[size - 1];
            for(int i = 0; i < size; i++)
            {
                if (OldDancers[i] == oldDancer)
                {
                    i++;
                    encontrado = true;
                }
                tmpDancers[i] = OldDancers[encontrado ? i-1:i];
            }
            OldDancers = tmpDancers;
        }
        public void AddDancer(Dancer newDancer)
        {
            if (this.Count > 0 && this.IsCrash(newDancer))
            {
                return;
            }
            int size = NewDancers.Length;
            Dancer[] tmpDancers = new Dancer[size + 1];
            tmpDancers[size] = newDancer;
            if (size > 0)
            {
                NewDancers.CopyTo(tmpDancers, 0);
                foreach (Dancer dancer in NewDancers)
                {
                    dancer.IsChangeDir = true;
                }
            }
            NewDancers = tmpDancers;
        }

        public void Bump()
        {
            if(this.NewDancers.Length>0)
            {
                OldDancers = NewDancers.Clone() as Dancer[];
            }
            foreach(Dancer dancer in OldDancers)
            {
                dancer.Bump();
            }
        }
    }
    class Dancer
    {
        public enum Direction { Clockwise, Anticlockwise };
        public Direction CurDirection { get; set; }
        public bool IsChangeDir { get; set; } = false;
        public void Bump()
        {
            if (IsChangeDir)
                ChangeDirection();
        }
        public void ChangeDirection()
        {
            this.CurDirection = this.CurDirection == Direction.Clockwise ? Direction.Anticlockwise : Direction.Clockwise;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Trunk[] logs;
            Dancer[] dancers;
            string data;
            string[] datos;
            int numLogs, numDancers, ilog, dir;
            int[] initialCondition;
            data = Console.ReadLine();
            datos = data.Split(' ');
            numLogs = int.Parse(datos[0]);
            numDancers = int.Parse(datos[1]);
            logs = new Trunk[numLogs];
            dancers = new Dancer[numLogs];
            initialCondition = new int[numDancers];
            for(int i = 0; i < numLogs; i++)
            {
                logs[i] = new Trunk();
            }
            for(int i = 0; i < numDancers; i++)
            {
                data = Console.ReadLine();
                datos = data.Split(' ');
                ilog = int.Parse(datos[0]);
                dir = int.Parse(datos[1]);
                initialCondition[i] = ilog;
                dancers[i] = new Dancer() { CurDirection = dir == 1 ? Dancer.Direction.Clockwise : Dancer.Direction.Anticlockwise };
                Dancer dancer = dancers[i];
            }

        }
    }
}
