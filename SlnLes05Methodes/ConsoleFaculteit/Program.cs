using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFaculteit
{
    internal class Program
    {
      
        
        static void Main(string[] args)
        {
            Console.WriteLine("FACULITEIT BEREKENEN");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Geef een geheel getal: ");
            int gegevenGetal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De faculiteit is " + Faculiteit(gegevenGetal));
            Console.ReadKey();    
        }

        private static int Faculiteit(int n)
        {

            int getal = 1;

            for (int i = 0; i < n; i++) 
            {
                getal += getal * i;
            }


            return getal;

        }

        
    }
}
