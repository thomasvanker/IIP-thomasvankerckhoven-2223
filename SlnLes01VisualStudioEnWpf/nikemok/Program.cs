using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikemok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantalKolommen = 3;
            int aantalRijen = 2;
            int[,] values = new int[aantalKolommen, aantalRijen];

            values[0, 0] = 10;
            values[0, 0] = 10;
            values[0, 0] = 10;
            values[0, 0] = 10;
            values[0, 0] = 10;
            values[0, 0] = 10;

            for (int i = 0; i < aantalKolommen; i++)
            {
                Console.WriteLine(values[0, 1] + "");
            }
            
            

            Console.ReadKey();
            
        }
    }
}
