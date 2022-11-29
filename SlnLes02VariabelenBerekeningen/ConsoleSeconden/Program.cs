using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSeconden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het aantal seconden: ");
            string seconden = Console.ReadLine();

            int dagen = Convert.ToInt32(seconden)/(24 * 60 * 60);
            int dagen2 = Convert.ToInt32(seconden) % (24 * 60 * 60);
            int uren = dagen2/(60 * 60);
            int uren2 = Convert.ToInt32(seconden) % (60 * 60);
            int minuten = uren2 / (60);
            int restseconden = Convert.ToInt32(seconden) % (60);

            Console.Write("Dit zijn: " + dagen + " dagen, " + uren + " uren, " + minuten + " minuten, " + restseconden + " seconden.");
            Console.ReadLine();
        }
    }
}
