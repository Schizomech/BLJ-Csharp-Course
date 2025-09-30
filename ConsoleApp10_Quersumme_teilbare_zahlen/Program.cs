using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int summe1 = CalcQuersumme1(Number1);
            Console.WriteLine("Zahl\tQuersumme\tZahl/Quersumme");
            if (Number1 > Number2)
            {
                int change = Number1;
                Number1 = Number2;
                Number2 = change;
            }
            for (int i = Number1; i < Number2 + 1; i++)
            {
                int summe2 = CalcQuersumme1(i);
                if (i % summe2 == 0)
                { 
                    Console.WriteLine($"{i}\t{summe2}\t\t{i / summe2}");
                }
            }
            Console.ReadKey();

        }
        static int CalcQuersumme1(int userNumber1)
        {
            int summe1 = 0;
            while (userNumber1 != 0)
            {   
                summe1 = summe1 + (userNumber1 % 10);
                userNumber1 = userNumber1 / 10;
            }

            return summe1;
            Console.ReadKey();
        }
    }
}