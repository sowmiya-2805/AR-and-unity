using System;
namespace Exercise3
{
    public class Artistic:Kid
    {
        public Artistic():base()
        {
        }

        public override void PrintMessage()
        {
            Console.WriteLine("This message is from an artistic kid i.e., another child class");
        }
    }
}
