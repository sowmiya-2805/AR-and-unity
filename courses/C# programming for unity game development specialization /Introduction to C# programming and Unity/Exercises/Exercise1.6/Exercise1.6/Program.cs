using System;

namespace Exercise1
{
    class MainClass
    {
        //implementation of trigonometric functions from Math class and including typecasting wherever essential in VisualStudio/Monodevelop
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the angle in degrees");
            float angle = float.Parse(Console.ReadLine());

            //Conversion is mandatory because the trigonometric functions expect the angle in radians as input.

            float angle_radians = angle * (float)Math.PI / 180;//typecasted to float since Math.PI returns a value whose type is double

            Console.WriteLine("The cosine of the angle - " + Math.Cos(angle_radians));
            Console.WriteLine("The sin of the angle - " + Math.Sin(angle_radians));


        }
    }
}
