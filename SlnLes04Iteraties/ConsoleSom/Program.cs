using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int som = 0;
            string stop = "";

            while (stop != "q")
            {
                Console.Write("Voer een getal in (q om te stoppen): ");
                stop = Console.ReadLine();
                if (stop == "q")
                {
                    break;
                }

                bool optellen = int.TryParse(stop, out int tweedeSom);

                if (optellen)
                {
                    som += tweedeSom;
                }
            }
            Console.WriteLine($"De som is: {som}");
            Console.ReadKey();
        }
    }
}
