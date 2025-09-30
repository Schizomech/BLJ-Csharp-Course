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
            Console.WriteLine("Wie lang soll die Diagnoale sein?:");
            int dist = Convert.ToInt32(Console.ReadLine());
            for (int zeile = 0; zeile < dist; zeile++)
            {
                for (int split = 0; split < dist; split++)
                {
                    if (split == zeile)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}