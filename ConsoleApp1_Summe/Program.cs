using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dieses Programm berchnet die summe von zwei Zahlen");
            Console.WriteLine("Geben sie einen Zahl an:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie eine zweite Zahl an:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int summe = zahl1 + zahl2;
            Console.WriteLine("Die Summe der beiden Zahlen ist: " + summe);
            Console.ReadKey();

        }
    }
}
