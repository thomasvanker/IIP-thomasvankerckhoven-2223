﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLancering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel seconden tot lancering? ");
            int seconden = Convert.ToInt32(Console.ReadLine());
            for (int i = seconden; i >= 0 ; i--)
            {
                Console.WriteLine(i + "...");
            }

            Console.WriteLine("Lift off!");
            Console.ReadKey();
        }
    }
}
