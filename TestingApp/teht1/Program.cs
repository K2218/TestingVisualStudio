using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Anna luku");
            luku = int.Parse(Console.ReadLine());
            switch (luku)
            {
                case 1: Console.WriteLine("Annoit luvun 1."); break;
                case 2: Console.WriteLine("Annoit luvun 2."); break;
                case 3: Console.WriteLine("Annoit luvun 3."); break;
                default: Console.WriteLine("Joku muu luku."); break;
            }
            Console.ReadLine();
        }
    }
}