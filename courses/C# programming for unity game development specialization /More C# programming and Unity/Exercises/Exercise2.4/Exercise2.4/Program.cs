using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //problem 1 - print numbers in user selected range
            Console.WriteLine("Enter the lower bound of integers to print");
            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper bound of integers to print");
            int max = int.Parse(Console.ReadLine());

            for(int i=min; i<=max; i++)
            {
                Console.WriteLine(i);

            }

            //problem 2 - create objects
            Console.WriteLine();

            Deck deck = new Deck();
            List<Card> sample = new List<Card>();
            deck.Shuffle();

            //problem 3 - deal and print the cards using for and foreach loops
            Console.WriteLine();

            for (int i=0; i<5; i++)
            {
                sample.Add(deck.TakeTopCard());
            }

            for(int i=0; i<=4; i++)
            {
                sample[i].FlipOver();
            }

            foreach(Card card in sample)
            {
                card.Print();
            }
        }
    }
}
