using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// implementation of classes and objects
    class Program
    {
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck1 = new Deck();
            deck1.Print();

            // tell the deck to shuffle and print itself
            deck1.Shuffle();
            deck1.Print();

            // take the top card from the deck and print the card rank and suit
            Card card1 = deck1.TakeTopCard();
            Console.WriteLine();
            Console.WriteLine("The top most card of the deck - " + card1.Rank + " of " + card1.Suit);

            // take the top card from the deck and print the card rank and suit
            Card card2 = deck1.TakeTopCard();
            Console.WriteLine();
            Console.WriteLine("The top most card of the deck - " + card2.Rank + " of " + card2.Suit);
        }
    }
}
