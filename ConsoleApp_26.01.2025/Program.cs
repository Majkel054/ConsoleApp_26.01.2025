using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp_26._01._2025
{
    internal class Program
    {
        static string checkKlasyf(string tekst)
        {
            string pattern = @"\bklasyfikacja\b"; //b- granica słowa
            Match match = Regex.Match(tekst, pattern, RegexOptions.IgnoreCase);

            if (match.Success) 
            {
                return "ostatnie zajecia!";
            }
            else
            {
                return "kontynuuj nauke";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz tekst do sprawdzenia: ");
            string tekst = Console.ReadLine();

            string wynik = checkKlasyf(tekst);
            Console.WriteLine(wynik);

            Console.WriteLine("Wciśnij dowolny klawisz aby zamknąć program");
            Console.ReadKey();
        }
    }
}
