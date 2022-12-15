using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraOef1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startWaarde = 1;
            int endWaarde = 100;
            int temp = startWaarde;

            while (temp <= endWaarde)
            {
                if (temp % 2 == 0)
                {
                    Console.WriteLine(temp);
                }
                temp = temp + 1;
            }

            Console.ReadKey();
        }
    }
}
