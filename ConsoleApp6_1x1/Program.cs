using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(
                      i + "\t"
                    + 2 * i + "\t"
                    + 3 * i + "\t"
                    + 4 * i + "\t"
                    + 5 * i + "\t"
                    + 6 * i + "\t"
                    + 7 * i + "\t"
                    + 8 * i + "\t"
                    + 9 * i + "\t"
                    + 10 * i + "\t"
                );
            }
            Console.ReadKey();
        }
    }
}

