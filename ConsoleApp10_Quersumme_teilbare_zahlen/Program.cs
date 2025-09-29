using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Number");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a second Number");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            while (zahl1 != 0)
            {
                sum1 += zahl1 % 10;
                zahl1 /= 10;
            }
            while (zahl2 != 0)
            {
                sum2 += zahl2 % 10;
                zahl2 /= 10;
            }
            
        }
    }
}
