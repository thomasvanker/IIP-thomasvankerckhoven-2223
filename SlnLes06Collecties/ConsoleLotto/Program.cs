using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;    
            Console.WriteLine("WELKOM OP DE LOTTOREKKING");
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int[] gegevenGetallen = { 4, 8, 17, 22, 31, 39, 41 };
            int[] nul = new int[6];

            Console.Write("Geef 6 getallen tussen 1 en 42 gescheiden door spaties: ");
            string getallen = Console.ReadLine();

            nul = getallen.Split().Select(int.Parse).ToArray();

            List<int> userGetallen = new List<int>();

            for (int i = 0; i < nul.Length; i++)
            {
                if (gegevenGetallen.Contains(nul[i])) 
                {
                    userGetallen.Add(nul[i]);
                }
            }

            Console.WriteLine("Trekking: " + String.Join(", ", gegevenGetallen));
            Console.WriteLine($"Je hebt {userGetallen.Count} juist: ");
            Console.ReadKey();
            
        }
    }
}
