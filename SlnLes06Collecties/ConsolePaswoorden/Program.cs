using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePaswoorden
{
    internal class Program
    {
        static string[] paswoorden = { "klepketoe", "test", "Azerty123", "rogier@work", "password", "MisterNasty12", "pwnzered" };
        static List<string> okPaswoorden = new List<string>();
        static List<string> nietOkPaswoorden = new List<string>();
        static bool IsCorrectPaswoord(string passwoord)
        {
            if (passwoord.Length < 8)
            {
                return false;
            }
            if (passwoord.Contains("@"))
            {
                return false;
            }
            if (passwoord == "123456789" || passwoord == "password" || passwoord == "Azerty123")
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Alle paswoorden:");
            for (int i = 0; i < paswoorden.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + paswoorden[i]);
            }

            Console.WriteLine();

            foreach (string passwoord in paswoorden)
            {
                if (IsCorrectPaswoord(passwoord))
                {
                    okPaswoorden.Add(passwoord);
                }
                else 
                {
                    nietOkPaswoorden.Add(passwoord);
                }
            }

            Console.WriteLine("Ok: " + string.Join(", ", okPaswoorden));
            Console.WriteLine("Niet ok: " + string.Join(", ", nietOkPaswoorden));

            Console.ReadKey();
        }
    }
}
