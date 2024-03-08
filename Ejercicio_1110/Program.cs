using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1110
{
    internal class Program
    {
        static void Play(Queue<int> deck, Queue<int> deckdiscard)
        {
            deckdiscard.Enqueue(deck.Dequeue());
            if (deck.Count() > 1)
            { 
                deck.Enqueue(deck.Dequeue());
                Play(deck, deckdiscard);
            }
        }
        static void Main(string[] args)
        {
            string data;
            int numcards;
            Queue<int> deck;
            Queue<int> discarding;
            while((data = Console.ReadLine()) != "0")
            {
                numcards = int.Parse(data);
                deck = new Queue<int>((new int[numcards]).Select((value, key) => key+1));
                discarding = new Queue<int>();
                Play(deck, discarding);
                Console.WriteLine($"Discarded cards: {String.Join(", ", discarding.ToArray())}");
                Console.WriteLine($"Remaining card: {deck.Peek()}");
            }
        }
    }
}
