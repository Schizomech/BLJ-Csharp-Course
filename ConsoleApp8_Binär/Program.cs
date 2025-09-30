using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Binär
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int userNumber;
            int rest;
            int value;
            int bin = " ";

            Console.WriteLine("Write a number");
            input = Console.ReadLine();
            userNumber = Convert.ToInt32(input);
            while (Console.ReadKey(true))
            while (userNumber != 0)
            {
                rest = userNumber % 2;
                bin = rest + bin;
                value = userNumber / 2;
                userNumber = value;
            }

            if (userNumber == 0) ;
            {
                Console.WriteLine(bin);
                    
            }
            
        }


        
    }
}
