using System;
using System.Collections.Generic;

namespace Exercise2
{
    // For loops practice
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> sample = new List<int>();

            //problem 1 - populate and print the list
            for(int i=1; i<=10; i++)
            {
                sample.Add(i);
            }
            for(int i=0; i<sample.Count; i++)
            {
                Console.WriteLine(sample[i]);
            }

            //problem 2 - remove even numbers from the list
            Console.WriteLine();
            for(int i=sample.Count-1; i>=0; i--)
            {

                if (sample[i] % 2 == 0)
                {
                    sample.RemoveAt(i);
                }
            }
            for (int i = 0; i < sample.Count; i++)
            {
                Console.WriteLine(sample[i]);
            }

            //problem 3 - bad forward for loop removal
            Console.WriteLine();
            List<int> sample2 = new List<int>();
            for(int i=1; i<=5; i++)
            {
                sample2.Add(i);
            }

            for(int i = 0; i < sample2.Count; i++)
            {
                if(sample2[i] == 1 || sample2[i] == 2 || sample2[i] == 3)
                {
                    sample2.RemoveAt(i);
                }
            }

            for (int i = 0; i < sample2.Count; i++)
            {
                Console.WriteLine(sample2[i]);
            }
        }
    }
}
