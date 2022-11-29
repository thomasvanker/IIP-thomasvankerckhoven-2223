using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goofyahuncleprod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            String name = Console.ReadLine();

            Console.WriteLine("Lengte?");
            int height = Convert.ToInt32(Console.ReadLine());

            int first = height / 100;
            int second = height % 100;

            Console.WriteLine($"{name} you're {first} meter and {second} centimeters.");

            Console.ReadLine();
        }
    }
}
