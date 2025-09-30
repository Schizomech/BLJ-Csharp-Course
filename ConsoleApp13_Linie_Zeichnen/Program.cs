using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deine Eingabe: " + input);

        }
    }
}
