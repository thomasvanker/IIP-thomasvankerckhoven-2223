using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEindcijfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berekening eindcijfer");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.Write("Geef het cijfer op het dagelijks werk (op 20): ");
            double cijferDagelijks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het project (op 20): ");
            double cijferProject = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het cijfer op het examen (op 20): ");
            double cijferExamen = Convert.ToDouble(Console.ReadLine());

            double percentage1 = (cijferDagelijks / 20.0) * 30;
            double percentage2 = (cijferProject/ 20.0) * 20;
            double percentage3 = (cijferExamen / 20.0) * 50;
            double result = (percentage1 + percentage2 + percentage3);
            Console.WriteLine();
            Console.WriteLine("Je eindcijfer is " + Math.Round(result, 1) + "%");
            string commentaar = "";
            if (result < 50)
            {
                commentaar = "-> onvoldoende";
            }
            else if (result > 82.5)
            {
                commentaar = "-> grootste onderscheiding";
            }
            else if (result > 75)
            {
                commentaar = "-> grote onderscheiding";
            }
            else if (result > 67.5)
            {
                commentaar = "-> onderscheiding";
            }
            else if (result > 50)
            {
                commentaar = "-> voldoende";
            }

            Console.WriteLine();
            Console.WriteLine(commentaar);
            Console.ReadKey();
        }
    }
}
