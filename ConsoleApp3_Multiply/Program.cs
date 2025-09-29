using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine( "i ist " + i );
            while ( i < 10 )
            {
                i ++;
                Console.WriteLine( "i ist " + i );
            }
            if ( i <= 10 )
            {
                Console.WriteLine( "i ist " + i );
                Console.ReadKey();
            }
        }
    }
}
