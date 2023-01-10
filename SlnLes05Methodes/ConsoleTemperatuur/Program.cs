using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTemperatuur
{
    internal class Program
    {
        static private double CelNaarFahr(double conversie)
        {
            conversie = conversie  * 9 / 5 + 32;
            Console.WriteLine("-> naar Fahrenheit: " + Math.Round(conversie,2) + "°F");
            return conversie;
        }

        static private double FahrNaarCel(double conversie)
        {
            conversie = (conversie - 32) * 5 / 9;
            Console.WriteLine("-> naar Celsius: " + Math.Round(conversie,2) + "°C");
            return conversie;
        }

        static private double CelNaarKel(double conversie)
        {
            conversie = conversie - 273.15;
            Console.WriteLine("-> naar Kelvin: " + Math.Round(conversie, 2) + "K");
            return conversie;
        }

        static private double KelNaarCel(double conversie)
        {
            conversie = conversie + 273.15;
            Console.WriteLine("-> naar Celsius: " + Math.Round(conversie, 2) + "°C");
            return conversie;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("TEMPERATUUR CONVERSIE");
            Console.WriteLine("=====================");
            Console.WriteLine("a. Celsius naar Fahrenheit");
            Console.WriteLine("b. Fahrenheit naar Celsius");
            Console.WriteLine("c. Celsius naar Kelvin");
            Console.WriteLine("d. Kelvin naar Celsius");
            Console.WriteLine("x. Afsluiten");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Maak je keuze: ");
                
                string antwoord = Console.ReadLine();

                if(antwoord == "a")
                {
                    Console.Write("Celsius: ");
                    double Celsius = Convert.ToDouble(Console.ReadLine());
                    CelNaarFahr(Celsius);

                }
                else if (antwoord == "b")
                {
                    Console.Write("Fahrenheit: ");
                    double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                    FahrNaarCel(Fahrenheit);

                }
                else if (antwoord == "c")
                {
                    Console.Write("Celsius: ");
                    double Celsius = Convert.ToDouble(Console.ReadLine());
                    CelNaarKel(Celsius);

                }
                else if (antwoord == "d")
                {
                    Console.Write("Kelvin: ");
                    double Kelvin = Convert.ToDouble(Console.ReadLine());
                    KelNaarCel(Kelvin);

                }

                else if (antwoord == "x") 
                {
                    Console.WriteLine();
                    Console.WriteLine("Bedankt en tot ziens");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
