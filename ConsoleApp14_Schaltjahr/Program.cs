using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welches Jahr wollen sie Prüfen?          Press q to quit");
            string input = Console.ReadLine();
            if (input == "q")
            {
                Environment.Exit(0);
            }
            int Jahr = Convert.ToInt32(input);
            if (Jahr % 400 == 0 && (Jahr / 100) % 1 == 0)
            {
                Console.WriteLine(input + " ist kein Schaltjahr");
            }
            else if (Jahr % 4 == 0)
            {
                Console.WriteLine(input + " ist ein Schaltjahr");
            }
            Console.WriteLine("Press anything to Quit");
            Console.ReadKey();
        }
    }
}