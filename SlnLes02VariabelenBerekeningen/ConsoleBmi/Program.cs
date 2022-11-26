using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI CALCULATOR");
            Console.WriteLine("==============");

            Console.Write("Lengte (in cm): ");
            int lengte1 = Convert.ToInt32(Console.ReadLine());
            double lengte2 = Convert.ToDouble(lengte1) / Convert.ToDouble(100);
            double lengte3 = lengte2 * lengte2;

            Console.Write("Gewicht (in kg): ");
            int gewicht = Convert.ToInt32(Console.ReadLine());

            double bmi = Convert.ToDouble(gewicht) / Convert.ToDouble(lengte3);

            Console.WriteLine("Je BMI bedraagt: " + Math.Round(bmi, 1));
            Console.ReadLine();
        }
    }
}
