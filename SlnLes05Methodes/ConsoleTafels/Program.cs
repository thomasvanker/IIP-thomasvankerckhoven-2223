using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTafels
{
    internal class Program
    {
        static private void DrukTafel(int get, int len)
        {
            for (int i = 1; i <= len; i++)
            {
                Console.WriteLine($"{get} x {i} = {i * get}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("4x8 tafel");
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine($"4 x {i} = {i * 4}");
            }

            Console.WriteLine("");
            Console.WriteLine("2x5 tafel");
            for(int i = 1; i <=5; i++)
            {
                Console.WriteLine($"2 x {i} = {i * 2}");
            }

            Console.WriteLine();
            Console.Write("Geef een getal: ");
            int get = int.Parse(Console.ReadLine());

            if (get < 0)
            {
                Console.Write("Het getal moet positief zijn! ");
                Console.Write("Geef een getal: ");
                get = int.Parse(Console.ReadLine());
            }

            Console.Write("Geef een getal: ");
            int len = int.Parse(Console.ReadLine());

            for (int i = 1; i <= len; i++)
            { 
                Console.WriteLine($"{get} x {i} = {i * get}");
            }

            Console.ReadKey();
        }
    }
}   

