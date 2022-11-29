using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("WELKOM IN HET BUFFETRESTAURANT");
            Console.WriteLine("==============================");
            Console.WriteLine();
            Console.WriteLine("Alles is à volonté en dranken zijn inbegrepen!");
            Console.WriteLine("!! Promotie!! Vandaag ronden we het totaalbedrag af naar beneden!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            Console.Write("Aantal seizoensbuffets (€18.5): ");
            int seizoensAantal = Convert.ToInt32(Console.ReadLine());
            double seizoensBuffet = seizoensAantal * 18.5;
            Console.Write("Aantal dessertenbuffets (€7.95): ");
            int dessertenAantal = Convert.ToInt32(Console.ReadLine());
            double dessertenBuffet = dessertenAantal * 7.95;
            Console.Write("Aantal kids menus (€8.95): ");
            int kidsAantal = Convert.ToInt32(Console.ReadLine());
            double kidsMenu = kidsAantal * 8.95;
            Console.WriteLine();
            Console.Write("Fooi (0 indien geen): ");
            double fooiBedrag = Convert.ToDouble(Console.ReadLine());
            double totaalBedrag = seizoensBuffet + dessertenBuffet + kidsMenu + fooiBedrag;
            double totaalFloor = Math.Floor(totaalBedrag);
            Console.WriteLine("Totaal te betalen: " + "€" + totaalBedrag);
            Console.WriteLine("Afgerond naar beneden: " + "€" + totaalFloor);
            Console.WriteLine();
            Console.Write("Cash betaald: ");
            int cashBetaald = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("U krijgt terug:");
            double terugGeld = (double)cashBetaald - totaalFloor;
            int vijftig = (int)terugGeld/50;
            int vijftigTweede = (int)terugGeld - (vijftig * 50);
            int twintig = vijftigTweede / 20;
            int twintigTweede = (int)vijftigTweede - (twintig * 20);
            int tien = (int)twintigTweede / 10;
            int tienTweede = (int)twintigTweede - (tien * 10);
            int vijf = (int)tienTweede/5;
            int vijfTweede = (int)tienTweede - (vijf * 5);
            int twee = (int) vijfTweede/2;
            int tweeTweede = (int)vijfTweede - (twee * 2);
            int een = (int)tweeTweede/1;
            Console.WriteLine("- " + vijftig + " briefje(s) van 50");
            Console.WriteLine("- " + twintig + " briefje(s) van 20");
            Console.WriteLine("- " + tien + " briefje(s) van 10");
            Console.WriteLine("- " + vijf + " briefje(s) van 5");
            Console.WriteLine("- " + twee + " stuk(ken) van 2");
            Console.WriteLine("- " + een+ " stuk(ken) van 1");

            Console.ReadLine();
        }
    }
}
