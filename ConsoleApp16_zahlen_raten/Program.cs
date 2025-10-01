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
            bool Restart = true;
            while (Restart == true)
            {
                Random rnd = new Random();
                int RandomNmbr = rnd.Next(1, 101);
                int versuchZahl = 0;
                int schluss = 1;
                while (schluss != RandomNmbr)
                {
                    versuchZahl++;
                    Console.WriteLine("Enter a Number from 1 to 100: ");
                    int versuch = Convert.ToInt32(Console.ReadLine());
                    if (versuch == RandomNmbr)
                    {
                        Console.WriteLine("Richtig! Das ist die gesuchte Zahl, du hast " + versuchZahl + " Versuche benötigt.");
                        bool y = false;

                        while (y == false)
                        {
                            Console.WriteLine("Play again? Y/N");
                            string input = Console.ReadLine();
                            if (input == "y")
                            {
                                Console.WriteLine("Sie haben das Spiel neugestartet. ");
                                schluss = RandomNmbr;
                                y = true;
                                Restart = true;
                            }
                            else if (input == "n")
                            {
                                Console.WriteLine("Das Spiel wurde Beendet.");
                                schluss = RandomNmbr;
                                y = true;
                                Restart = false;
                            }
                        }
                    }
                    else if (versuch > RandomNmbr)
                    {
                        Console.WriteLine("zu gross! Nächster Versuch:");
                    }
                    else if (versuch < RandomNmbr)
                    {
                        Console.WriteLine("Zu klein! Nächster Versuch:");
                    }
                }
            }
        }
    }
}
