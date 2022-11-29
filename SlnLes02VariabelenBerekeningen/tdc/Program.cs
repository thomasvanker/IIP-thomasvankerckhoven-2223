using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef Eerste Nummer: ");
            int nummer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef Tweede Nummer: ");
            int nummer2 = Convert.ToInt32(Console.ReadLine());

            int som = nummer1+ nummer2;
            int product = nummer1* nummer2;
            double deling = Convert.ToDouble(nummer1) / Convert.ToDouble(nummer2);

            Console.Write($"Som: {som} Prodcut: {product} Deling: {deling}");
            Console.ReadLine();
        }
    }
}
