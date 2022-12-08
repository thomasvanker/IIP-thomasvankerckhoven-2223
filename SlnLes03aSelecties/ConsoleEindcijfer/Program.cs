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
            double cijferDagelijks2;
            double cijferProject2;
            double cijferExamen2;
            double cijferDagelijks3;
            double cijferProject3;
            double cijferExamen3;


            cijferDagelijks2 = ((cijferDagelijks * 100)/60);
            cijferProject2 = ((cijferProject * 100)/60);
            cijferExamen2 = ((cijferExamen * 100) / 60);

            cijferDagelijks3 = ((cijferDagelijks2 * 30/100));
            cijferProject3 = ((cijferProject2 * 20 / 100));
            cijferExamen3 = ((cijferExamen2 * 50 / 100));

            Console.WriteLine(cijferDagelijks2);
            Console.WriteLine(cijferProject2);
            Console.WriteLine(cijferExamen2);

            Console.WriteLine(cijferDagelijks3);
            Console.WriteLine(cijferProject3);
            Console.WriteLine(cijferExamen3);


            double cijfertotaal = cijferDagelijks3 + cijferProject3 + cijferExamen3;

            Console.WriteLine("Je eindcijfer is " + Math.Round(cijfertotaal, 1) + "%");
            



            Console.ReadKey();
        }
    }
}
