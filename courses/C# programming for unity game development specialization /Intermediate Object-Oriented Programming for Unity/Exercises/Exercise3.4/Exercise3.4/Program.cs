using System;

namespace Exercise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Kid kid = new Kid();
            Kid naughty = new Naughty();
            Kid artistic = new Artistic();

            kid.PrintMessage();
            naughty.PrintMessage();
            artistic.PrintMessage();
        }
    }
}
