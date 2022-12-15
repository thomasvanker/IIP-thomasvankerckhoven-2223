using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankautomaat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer je pincode in: ");
            int pincode = Convert.ToInt32(Console.ReadLine());
            if (pincode == 1234 ) 
            {
                Console.WriteLine("Welkom in de bank");
                Console.WriteLine();
                double saldo = 500;
                Console.WriteLine("Bankautomaat");
                Console.WriteLine("============");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("a. afhaling");
                    Console.WriteLine("b. storting");
                    Console.WriteLine("c. stoppen");
                    Console.Write("je keuze: ");
                    string keuze = Console.ReadLine();
                    Console.WriteLine();

                    if (keuze == "a")
                    {
                        Console.Write("Welk bedrag wil je afhalen: ");
                        double bedrag = Convert.ToDouble(Console.ReadLine());
                        saldo -= bedrag;
                        Console.WriteLine($"afhaling ok - het nieuwe saldo is {saldo}");
                    }
                    else if (keuze == "b")
                    {
                        Console.Write("Welke bedrag wil je storten: ");
                        double bedrag = Convert.ToDouble(Console.ReadLine());
                        saldo += bedrag;
                        Console.WriteLine($"storting ok - het nieuwe saldo is {saldo}");
                    }
                    else if (keuze == "c")
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }

                Console.WriteLine("Bedankt en tot ziens.");
            }
            else
            {
                Console.WriteLine("Ongeldige pincode. Toegang geweigerd.");
            }
            Console.ReadKey();
        }
    }
}
