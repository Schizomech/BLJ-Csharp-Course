using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_Quersumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Von welche Zahl möchtest du die Quersumme berechnen?");
            int zahl = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (zahl != 0)
            {
                sum += zahl % 10;
                zahl /= 10;
            }
            Console.WriteLine("Die Quersumme ist " + sum);
            Console.ReadLine();
        }
    }
}
