using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung von Sekunden eines Monats in Abhängigkeit seiner Anzahl Tage");
            Console.WriteLine("Bitte geben Sie die Anzahl der Tage des Monats ein:");
            Console.WriteLine("Bitte geben Sie eine Zahl ein.");
            string input = Console.ReadLine();
            int tage;
            if (int.TryParse(input, out tage) == true)
            {
                Console.WriteLine("Ihre Eingabe " + tage.ToString() + " ist gültig.");
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
            int sekunden = tage * 24 * 60 * 60;
            Console.WriteLine(tage + " Tage haben " + sekunden + " Sekunden.");
            Console.ReadKey();
        }
    }
}
