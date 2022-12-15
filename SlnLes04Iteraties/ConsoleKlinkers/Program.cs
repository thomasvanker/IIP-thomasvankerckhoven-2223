using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKlinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een tekst: ");
            string tekst = Console.ReadLine();

            int aantalKlinkers = 0;
            int aantalNummers = 0;

            foreach (char c in tekst)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    aantalKlinkers++;
                }
            }

            foreach (char c in tekst)
            {
                if (char.IsDigit(c))
                {
                    aantalNummers++;
                }
            }

            string geheimSchrift = new string(tekst.Select(ch =>
            {
                if (!char.IsLetter(ch)) return ch;
                return Convert.ToChar(ch + 1);
            }).ToArray());



            Console.WriteLine($"deze tekst bevat {aantalKlinkers} klinkers");
            Console.WriteLine($"deze tekst bevat {aantalNummers} nummers");
            Console.WriteLine($"in geheimschrift: {geheimSchrift}");

            Console.ReadKey();
        }
    }
}
