using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRaden
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bool juist = false;
            while (!juist)
            {
                Console.Write("Raad een getal tussen 1 en 10: ");
                int gok = Convert.ToInt32(Console.ReadLine());
                if (gok > 8)
                {
                    Console.WriteLine("De gok was te hoog");
                }
                else if (gok < 8)
                {
                    Console.WriteLine("De gok was te laag");
                }
                else
                {
                    Console.WriteLine("Geraden");
                    juist = true;
                }
            }


            Console.ReadKey();
        }
    }
}
