using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{

    class Program
    {
        /// Practising the arrays
        static void Main(string[] args)
        {

            Console.WriteLine();
            Deck deck = new Deck();
            Card[] holdcards = new Card[5];
            deck.Shuffle();

            //problem 1
            Card topcardone = deck.TakeTopCard();
            holdcards[0] = topcardone;
            holdcards[0].FlipOver();
            holdcards[0].Print();
            Console.WriteLine();

            //problem 2
            Card topcardtwo = deck.TakeTopCard();
            holdcards[1] = topcardtwo;
            holdcards[1].FlipOver();
            holdcards[0].Print();
            holdcards[1].Print();
            Console.WriteLine();
        }
    }
}
