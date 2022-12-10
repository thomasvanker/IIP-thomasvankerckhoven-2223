using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnderBoven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een ondergrends: ");
            int onder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef een bovengrens: ");
            int boven = Convert.ToInt32(Console.ReadLine());
            while (boven <= onder)
            {
                if (boven < onder)
                {
                    Console.Write("Bovengrens mag niet kleiner zijn dan ondergrens. Geef een bovengrens: ");
                    boven = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Bovengrens mag niet gelijk zijn dan ondergrens. Geef een bovengrens: ");
                    boven = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"Bereik: van {onder} tot {boven}");

            Console.ReadKey();
        }
    }
}
