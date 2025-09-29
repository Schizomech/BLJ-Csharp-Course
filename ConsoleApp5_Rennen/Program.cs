using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 42) 
            {
                Console.WriteLine("Das sind " + input * 1000 + " Meter.");
                Console.WriteLine("Du müsstest " + input * 1000 / 400 + " Runden rennen");
            }
            else if (input >= 42)
            {
                {
                    Console.WriteLine("Du schaffst das nicht");
                    return;
                }
            }
            Console.WriteLine("Das sind" input * 1000 / 400 " Runden, bist du ready für den Lauf?");
        }
    }
}
