using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSchrikkeljaar
{
    internal class Program
    {
        static private int SchrikkelJaar (int jaar)
        {
            if (jaar % 4 == 0 && jaar % 100 != 0 || jaar % 400 == 0)
            {
                Console.WriteLine(jaar + " is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine(jaar + " is geen schrikkeljaar");
            }
            
            

            return jaar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SCHRIKKELJAAR");
            Console.WriteLine("=============");
            while (true)
            {
                Console.Write("Geef een jaartal: ");
                int jaar = Convert.ToInt32(Console.ReadLine());
                SchrikkelJaar(jaar);
                Console.WriteLine("");
                if (jaar == 0 || jaar < 0)
                {
                    Console.WriteLine("Bedankt en tot ziens");
                    break;
                }

            }
            Console.ReadKey();
        }
    }
}

    

