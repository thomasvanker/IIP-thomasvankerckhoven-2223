
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraOef2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int faculiteit = 6;
            int temp = faculiteit;
            int i = faculiteit - 1;

            while (i > 0)
            {
                i = i - 1;
                temp = temp * (i);
                Console.Write(temp);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(faculiteit + "! = * " + temp);

            Console.ReadKey();
        }
    }
}
