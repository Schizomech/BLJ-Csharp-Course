using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomnmbr = rnd.Next(1,101);
            Console.WriteLine("Deine Zahl (1..100):")
            int input = Convert.ToInt32(Console.ReadLine());
            Printmessage();

            static void Printmessage()
            {
                if (input == randomnmbr)
                {
                    Console.WriteLine("Die Zahl stimmt du hast " + " Versuche benötigt");
                }
                else if (input >= randomnmbr)
                {
                    Console.WriteLine("Zahl ist zu gross! Nächster Versuch:");
                }
                else if (input <= randomnmbr)
                {
                    Console.WriteLine("Zahl ist zu klein! Nächster Versuch:"
                }
                Main();
            }
        }
    }
}
