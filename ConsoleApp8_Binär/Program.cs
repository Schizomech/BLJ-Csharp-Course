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
            bool keypressed = false;
            while (keypressed == false)
            {
                int userNumber;
                int rest;
                int value;
                string bin = (" ");
                string input;

                Console.WriteLine("Enter Number          enter Q to Quit)");
                input = Console.ReadLine();
                if (input == "Q")
                {
                    keypressed = true;
                    Console.WriteLine("Stopping program");
                }
                else
                {
                    userNumber = Convert.ToInt32(input);
                    keypressed = false;
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
                Console.ReadKey();
            }
        }
    }
}
