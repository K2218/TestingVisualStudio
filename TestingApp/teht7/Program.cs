using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a year");
            string line = Console.ReadLine();
            int year = int.Parse(line);

            bool b1 = true;
            bool b2 = false;
            bool b3 = true;
            b1 = (year % 4 == 0);
            b2 = (year % 100 == 0);
            b3 = (year % 400 == 0);

            if (b1)
            {
                if (b2)
                {
                    if (b3)
                    {
                        Console.WriteLine("The year is a leap year");
                    }
                    else {
                        Console.WriteLine("The year isn't a leap year");
                    }
                }
                else {
                    Console.WriteLine("The year isn't a leap year");
                }
            }
                
            
            else {
                Console.WriteLine("The year isn't a leap year");
            }


        }
    }
}
