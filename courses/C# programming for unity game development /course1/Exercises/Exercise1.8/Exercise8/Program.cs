using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    //implementation of classes and objects
    class Program
    {
        
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die();
            Die die2 = new Die();

            // tell the dice to roll themselves
            die1.Roll();
            die2.Roll();

            // print the top sides and the sum of the dice
            int top1, top2, sum;
            top1 = die1.TopSide;
            top2 = die2.TopSide;
            sum = top1 + top2;
            Console.WriteLine("The top face of die1 - " + top1);
            Console.WriteLine("The top face of die2 - " + top2);
            Console.WriteLine("The sum of the top faces - " + sum);
        }
    }
}
