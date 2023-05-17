using System;
using System.Collections;
class URI
{
    static void Main(string[] args)
    {
        BitArray logs1, logs2, initialState, currentState;
        int numLogs, numDancers, idLog, orientation, steps;
        bool[] word;
        bool extraBit;
        string line;
        string[] data;
        int i = 0;
        line = Console.ReadLine();
        data = line.Split(' ');
        numLogs = int.Parse(data[0]);
        numDancers = int.Parse(data[1]);
        logs1 = new BitArray(numLogs);
        logs2 = new BitArray(numLogs);
        word = new bool[numLogs];
        for (i = 0; i < numDancers; ++i)
        {
            line = Console.ReadLine();
            data = line.Split();
            idLog = int.Parse(data[0]);
            orientation = int.Parse(data[1]);
            if (orientation == 1)
                logs1[idLog-1] = true;
            else
                logs2[idLog-1] = true;
        }
        initialState = (logs1.Clone() as BitArray).Xor(logs2).Clone() as BitArray;
        steps = 0;
        do
        {
            extraBit = logs1[numLogs - 1];
            for(i = numLogs-1; i > 0 ; --i)
            {
                logs1[i] = logs1[i - 1];
            }
            logs1[0] = extraBit;
            extraBit = logs2[0];
            for (i = 0; i<numLogs-1; ++i)
            {
                logs2[i] = logs2[i + 1];
            }
            logs2[numLogs-1] = extraBit;
            currentState = (logs1.Clone() as BitArray).Xor(logs2);
            currentState.Xor(initialState).CopyTo(word, 0);
            ++steps;
        }
        while (Array.Exists(word, s => s));
        Console.WriteLine(steps);
    }
}
