using System;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          
            Apple apple = new Apple(false, 10);
            Console.WriteLine("The organic state of the apple - " + apple.Organic);
            Console.WriteLine("The remaining portion of the apple left - " + apple.Amountleft);

            const float bitesize = 2;
            int numberofbites = 0;

            while(apple.Amountleft > 0)
            {
                apple.TakeBite(bitesize);
                numberofbites += 1;
            }

            Console.WriteLine();
            Console.WriteLine("No of bites of a apple with bite size " + bitesize + " is " + numberofbites);

        }
    }
}
