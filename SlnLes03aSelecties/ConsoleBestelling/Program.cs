using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBestelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PIZZA BESTELLING");
            Console.WriteLine("================");
            Console.WriteLine();

            Console.WriteLine("Kies je pizza:");
            Console.WriteLine("a) Margherita 8 euro");
            Console.WriteLine("b) Funghi 10 euro");
            Console.WriteLine("c) Diabolo 11 euro");
            Console.Write(">> wat is je keuze? ");
            string eersteKeuze = Console.ReadLine();
            int prijsPizza = 0;
            double prijsTotaal = 0;

            if (eersteKeuze == "c")
            {
                eersteKeuze = "Pizza Diabolo";
                prijsPizza = 11;
                
            }

            if (eersteKeuze == "a")
            {
                eersteKeuze = "Pizza Margherita";
                prijsPizza = 8;
            }

            if (eersteKeuze == "b")
            {
                eersteKeuze = "Pizza Funghi";
                prijsPizza = 10;

            }


            Console.WriteLine("");
            Console.WriteLine("Kies de groote");
            Console.WriteLine("a) 15 cm (klein; - 20%)");
            Console.WriteLine("b) 20 cm (normaal)");
            Console.WriteLine("c) 25 cm (groot; + 20%)");
            Console.Write(">> wat is je keuze? ");
            string tweedeKeuze = Console.ReadLine();
            double prijsGrootte = 0;

            if (tweedeKeuze == "c")
            {
                tweedeKeuze = "groot";
                prijsGrootte = prijsPizza + ((double)prijsPizza * 0.2);
            }

            if (tweedeKeuze == "a")
            {
                tweedeKeuze = "klein";
                prijsGrootte = prijsPizza - ((double)prijsPizza * 0.2);
            }

            if (tweedeKeuze == "b")
            {
                tweedeKeuze = "normaal";
                prijsGrootte = prijsPizza;
            }
  

            Console.Write("Thuis bezorgen (3 euro extra)? ja/nee: ");
            string jaNee = Console.ReadLine();
            int prijsJaNee = 0;

            if (jaNee == "ja")
            {
                jaNee = "thuis bezorgd";
                prijsJaNee = 3;
            }

            if (jaNee == "nee")
            {
                jaNee = "niet thuis bezorgd";
                prijsJaNee = 0;
            }

            prijsTotaal = (double)prijsGrootte +  prijsJaNee;
            

            Console.WriteLine($"1 {eersteKeuze} {tweedeKeuze}, voor {prijsTotaal} euro, {jaNee}");

            Console.ReadKey();
        }
    }
}
