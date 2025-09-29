using System;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] forbiddenWords =
            {
                "viagra", "sex", "porno", "fick", "schlampe", "arsch", "fuck",
                "faggot", "fag", "tranny", "bitch", "hurensohn", "huso"
            };

            Console.WriteLine("Enter a comment (type /exit to quit):");
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input == null)
                    continue;

                if (input.Equals("/exit", StringComparison.OrdinalIgnoreCase))
                    break;

                string censored = Censor(input, forbiddenWords);
                Console.WriteLine("Comment: " + censored);
            }
        }

        private static string Censor(string input, string[] forbiddenWords)
        {
            if (string.IsNullOrEmpty(input)) return input;

            string result = input;

            foreach (var word in forbiddenWords)
            {
                if (string.IsNullOrWhiteSpace(word)) continue;

                
                string pattern = $@"\b{Regex.Escape(word)}\b";

                result = Regex.Replace(
                    result,
                    pattern,
                    m => new string('*', m.Length),
                    RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
                );
            }

            return result;
        }
    }
}
