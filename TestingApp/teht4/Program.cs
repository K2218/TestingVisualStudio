using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give age:");
            string line = Console.ReadLine(); //"50"
            int age = int.Parse(line); //50
            if (age < 18)
            {
                Console.WriteLine("You are under-age");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a senior");
            }

            Console.ReadLine();
        }
    }
}
