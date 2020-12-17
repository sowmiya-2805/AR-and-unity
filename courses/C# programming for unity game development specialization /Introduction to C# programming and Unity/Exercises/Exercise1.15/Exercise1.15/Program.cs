using System;

namespace Exercise1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
          
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Pasta");
            Console.WriteLine("3. Risotto");
            Console.WriteLine("4. Lasagna");
            Console.WriteLine();
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("Your choice is......????");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Your choice is " + choice + " and the cost for the choice is loading.....");

            //Problem 1 - to use if statement
            //if(choice == 1)
            //{
            //    Console.WriteLine("Pizza costs 500 Indian Rupee");
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine("Pasta costs 300 Indian Rupee");
            //}
            //else if (choice == 3)
            //{
            //    Console.WriteLine("Risotto costs 250 Indian Rupee");
            //}
            //else
            //{
            //    Console.WriteLine("Lasagna costs 250 Indian Rupee");
            //}

            //Problem 2 - to use switch statement
            switch (choice)
            {
                case 1: Console.WriteLine("Pizza costs 500 Indian Rupee");
                    break;

                case 2:
                    Console.WriteLine("Pasta costs 300 Indian Rupee");
                    break;

                case 3:
                    Console.WriteLine("Risotto costs 250 Indian Rupee");
                    break;

                case 4:
                    Console.WriteLine("Lasagna costs 250 Indian Rupee");
                    break;

                default: Console.WriteLine("Sorry sir/mam..choice is invalid......");
                    break;

            }

        }
    }
}
