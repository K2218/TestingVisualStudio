using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            double gas = 1.595;
            double carconsumption = 7.02;
            Console.WriteLine("Give a length of the travel: ");

            string line = Console.ReadLine();
            int distance = int.Parse(line);
            double consumption = carconsumption / 100 * distance;

            Console.WriteLine("Your fuel consumption is: " + consumption + "l");
            Console.WriteLine("Fuel costs: " + gas * consumption + "€");

            Console.ReadLine();

        }
    }
}
