using System;
namespace Exercise3
{
    public class Naughty : Kid
    {
        public Naughty():base()
        {
        }

        public override void PrintMessage()
        {
            Console.WriteLine("This message is from a naughty kid i.e., the child class");
        }
    }
}
