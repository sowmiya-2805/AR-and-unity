using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> lines = new List<string>();

            //problem 2 - reading input from a text file and print the lines in the consle
            StreamReader input = null;
            try
            {

                input = File.OpenText("sampletext.txt");
                String line = input.ReadLine();
                while(line != null)
                {
                    lines.Add(line); //to retrieve the even numbered lines
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (input != null)
                {
                    input.Close();
                }
            }

            //problem 3 - to write the even numbered lines into another text file
            StreamWriter output = null;
            try
            {
                output = File.CreateText("output.txt");
                for(int i=2; i<lines.Count; i += 2)
                {
                    output.WriteLine(lines[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                if(output!= null)
                {
                    output.Close();
                }
            }
        }
    }
}
