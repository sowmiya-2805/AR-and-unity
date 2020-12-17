using System;

namespace Exercise1
{
    class MainClass
    {
        //implementation of declaration of variables and using them in calculations in VisualStudio/Monodevelop
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the altitude of Location1 in km");
            int altitude1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the altitude of Location2 in km");
            int altitude2 = int.Parse(Console.ReadLine());
            int change = altitude2 - altitude1;

            // Console.WriteLine("The change in altitude as you move from 1st location to the next is " + altitude2-altitude1); This won't work.
            //Since we concateante the string with '+' operator the subtraction opeartion isn't possible. Hence declare a variable.

            Console.WriteLine("The change in altitude as you move from 1st location to the next is " + change + " km")
        }
    }
}
