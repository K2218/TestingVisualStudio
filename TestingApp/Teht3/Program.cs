using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 3 numbers");
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            int num1 = int.Parse(line1);
            int num2 = int.Parse(line2);
            int num3 = int.Parse(line3);

            Console.WriteLine("Total value of your numbers is: " + (num1 + num2 + num3));
            Console.WriteLine("Average value of your numbers is: " + ((num1 + num2 + num3) / 3));

            Console.ReadLine();

        }
    }
}
