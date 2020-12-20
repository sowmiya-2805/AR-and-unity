using System;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the input in the form <pyramid slot number>,<block letter>,<whether or not the block should be lit>");
            String input = Console.ReadLine();

            int commaLocation = input.IndexOf(','); //location of the first comma
            int commaLocation2 = input.LastIndexOf(','); //location of  the second comma

            //extracting pyramid slot number
            int pyramidslot = int.Parse(input.Substring(0, commaLocation));
            Console.WriteLine("The pyramid slot number - " + pyramidslot);

            //extracting block number
            char blockletter = input.Substring(commaLocation + 1)[0];
            Console.WriteLine("The block letter - " + blockletter);

            //extracting the lit status of the block
            bool litStatus = bool.Parse(input.Substring(commaLocation2 + 1));
            Console.WriteLine("The lit status of the pyramid block - " + litStatus);
        }
    }
}
