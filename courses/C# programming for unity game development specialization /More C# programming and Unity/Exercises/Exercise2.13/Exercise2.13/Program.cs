using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Problem 1 - Birthday fun
            Console.WriteLine("Enter your birth year");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of your birthday");
            string month = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the day of your birthday");
            int date = int.Parse(Console.ReadLine());

            //Problem 2 - Reminders
            Dictionary<string, int> monthsmap = new Dictionary<string, int>();
            monthsmap.Add("january", 1);
            monthsmap.Add("february", 2);
            monthsmap.Add("march", 3);
            monthsmap.Add("april", 4);
            monthsmap.Add("may", 5);
            monthsmap.Add("june", 6);
            monthsmap.Add("july", 7);
            monthsmap.Add("august", 8);
            monthsmap.Add("september", 9);
            monthsmap.Add("october", 10);
            monthsmap.Add("november", 11);
            monthsmap.Add("december", 12);

            bool leapyear(int year2)
            {
                if(year2 % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool datevalidation()
            {

                while(string.Equals(month, "january") || string.Equals(month, "march") || string.Equals(month, "may") || string.Equals(month, "july") || string.Equals(month, "august") || string.Equals(month, "october") || string.Equals(month, "december"))
                {
                    if (date > 31)
                    {
                            return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                while(string.Equals(month, "april") || string.Equals(month, "june") || string.Equals(month, "september") || string.Equals(month, "november"))
                {
                    if (date > 30)
                    {
                         return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                while(string.Equals(month, "february"))
                {
                    if (leapyear(year) && date > 29)
                    {
                        return false;
                    }
                    else if(!leapyear(year) && date > 28)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
            
            }

            int remindermonth, reminderdate;
            Console.Write(" The reminder would be sent on ");

            while (datevalidation())
            {
                if (date == 1)
                {
                    if (string.Equals(month, "january") || string.Equals(month, "february") || string.Equals(month, "april") || string.Equals(month, "june") || string.Equals(month, "september") || string.Equals(month, "november"))
                    {
                        reminderdate = 31;
                        Console.Write(reminderdate + " " );
                        break;
                    }
                    else if (string.Equals(month, "march"))
                    {
                        int currentYear = DateTime.Now.Year;
                        if (leapyear(currentYear))
                        {
                            reminderdate = 29;
                        }
                        else
                        {
                            reminderdate = 28;
                        }
                        Console.Write(reminderdate + " " );
                        break;
                    }
                    else
                    {
                        reminderdate = 30;
                        Console.Write(reminderdate + " ");
                        break;
                    }
                }
                else
                {
                    reminderdate = date - 1;
                    Console.Write(reminderdate + " ");
                    break;
                }
            }

            if(monthsmap[month] == 1)
            {
                remindermonth = 12;
            }
            else
            {
                remindermonth = monthsmap[month] - 1;
            }
            Dictionary<int, string> monthsmap2 = new Dictionary<int, string>();
            monthsmap2.Add(1, "january");
            monthsmap2.Add(2, "february");
            monthsmap2.Add(3, "march");
            monthsmap2.Add(4, "april");
            monthsmap2.Add(5, "may");
            monthsmap2.Add(6, "june");
            monthsmap2.Add(7, "july");
            monthsmap2.Add(8, "august");
            monthsmap2.Add(9, "september");
            monthsmap2.Add(10, "october");
            monthsmap2.Add(11, "november");
            monthsmap2.Add(12, "december");
            Console.WriteLine(monthsmap2[remindermonth]);
        
        }
    }
}
