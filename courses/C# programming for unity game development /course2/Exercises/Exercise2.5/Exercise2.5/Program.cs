using System;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Problem 1 - creating user menu
            Console.WriteLine("Welcome to the Italian Restaurant...");
            Console.WriteLine();
            Console.WriteLine("**********************");
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Pasta");
            Console.WriteLine("3. Rissoto");
            Console.WriteLine("4. Quit");
            Console.WriteLine("**********************");
            Console.WriteLine("Kindly pick your choice");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //problem 2 - Implement input validation
            while (choice != 4)
            {
                Console.WriteLine("Processing  your choice");
                if(choice == 1)
                {
                    Console.WriteLine("One pizza costs 500 Indian Rupee");
                    break;
                }
                else if(choice == 2)
                {
                    Console.WriteLine("One pasta costs 300 Indian Rupee");
                    break;
                }
                else
                {
                    Console.WriteLine("One Rissoto cossts 250 Indian Rupee");
                    break;
                }
            }
            
            
        }
    }
}
