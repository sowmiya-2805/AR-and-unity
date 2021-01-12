using System;

namespace Exercise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter an integer ");
                int integer = int.Parse(Console.ReadLine());
            }

            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            finally
            {
                Console.WriteLine("I am going to be printed no matter whhhatt....");
            }
        }
    }
}
