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
            int geheimGetal = 4;
            int gok;
            int gokAantal = 0;

            Console.WriteLine("Raad een getal tussen 1 en 10");

            do
            {
                Console.Write("Poging 1: ");
                gok = Convert.ToInt32(Console.ReadLine());
                gokAantal++;

                if (gok == geheimGetal)
                {
                    Console.WriteLine("Geraden");break;
                }

                Console.Write("Poging 2: ");
                gok = Convert.ToInt32(Console.ReadLine());
                gokAantal++;

                if (gok == geheimGetal)
                {
                    Console.WriteLine("Geraden");break;
                }

                Console.Write("Poging 3: ");
                gok = Convert.ToInt32(Console.ReadLine());
                gokAantal++;

                if (gok == geheimGetal)
                {
                    Console.WriteLine("Geraden");break;
                }

                else if (gok != geheimGetal)
                {
                    Console.WriteLine("Volgende keer beter");
                }
            }
            while (gokAantal < 3);

            Console.ReadKey();
                
            
        }
    }
}
