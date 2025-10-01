using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie Breit soll der Baumstamm sein?");
            int breiteB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie hoch soll der Baumstamm sein?");
            int hoheB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wie hoch soll die Krone sein?");
            int hoheK = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int tool = hoheK - breiteB / 2;
            Random rnd = new Random();

            for (int lines = hoheK; lines >= 1; lines--)
            {
                for (int spaces = lines - 1; spaces >= 1; spaces--)
                {
                    Console.Write(" ");

                }
                for (int star = 1; star <= count; star++)
                {
                    if (rnd.Next(1, 101) <= 10)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
                count++;
                Console.WriteLine();
            }
            if (hoheB > 0 || breiteB > 0)
            {
                for (int hohe = 0; hohe < hoheB; hohe++)
                {
                    for (int center = 0; center < tool; center++)
                    {
                        Console.Write(" ");
                    }
                    for (int breite = 0; breite < breiteB; breite++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
