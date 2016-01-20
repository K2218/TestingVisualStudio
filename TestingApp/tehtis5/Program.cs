using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtis5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give time in seconds:");
            string line = Console.ReadLine();
            int seconds = int.Parse(line);
            int hour = seconds / 3600;
            int min = seconds / 60 - hour * 60;
            int second = seconds % 60;

            Console.WriteLine("Time {0}h {1}m {3}s", hour, min, second);

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
}
