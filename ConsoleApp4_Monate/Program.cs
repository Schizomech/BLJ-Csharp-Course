using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 12 ein:");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int month))
            {
                Console.WriteLine("Diese Eingabe nicht gültig.");
                return;
            }

            if (month >= 1 && month <= 12)
            {
                string[] monate = {
                    "Januar", "Februar", "März", "April", "Mai", "Juni",
                    "Juli", "August", "September", "Oktober", "November", "Dezember"
                };
                Console.WriteLine("Der Monat ist " + monate[month - 1]);
            }
            else
            {
                Console.WriteLine("Die Zahl ist ungültig");
            }
            Console.ReadKey();
        }
    }
}
