using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel Fibonacci getallen wil je afdrukken: ");
            int n = int.Parse(Console.ReadLine());

            int[] calc = fibonacciCalc(n);
            Console.Write($"Eerste {n} getallen: ", calc);
            for (int i = 0; i < calc.Length; i++)
            {
                Console.Write(calc[i] + " ");
            }

            Console.ReadKey();

        }

        static int[] fibonacciCalc(int n)
        {
            int[] fibonacci = new int[n];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            return fibonacci;
        }
    }
}
