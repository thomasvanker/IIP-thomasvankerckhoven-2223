using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 10, 15, 16, 5, 19, 12, 18, 16, 7, 7 };
            Console.WriteLine("Scores: " + string.Join(", ", scores));

            int gemid = 0;
            int slechtste = scores[0];
            int beste = scores[0];
            for (int i = 0; i < scores.Length; i++)
            {
                gemid += scores[i];
                if (scores[i] < slechtste)
                {
                    slechtste = scores[i];
                }
                if (scores[i] > beste)
                {
                    beste = scores[i];
                }
            }
            double gemiddelde = (double)gemid / scores.Length;
            Console.WriteLine();
            Console.WriteLine("De gemiddelde score van de test was: " + gemiddelde);
            Console.WriteLine("De slechtste score op de test was: " + slechtste);
            Console.WriteLine("De beste score op de test was: " + beste);
            Console.ReadKey();

        }
    }
}
