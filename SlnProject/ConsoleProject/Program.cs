using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schrijf de juiste volgorde op waarin de geluiden zijn afgespeeld");
            SoundPlayer[] geluiden =
            {
                new SoundPlayer("cello.wav"),
                new SoundPlayer("drums.wav"),
                new SoundPlayer("piano.wav"),
                new SoundPlayer("harp.wav"),
                new SoundPlayer("flute.wav"),
                new SoundPlayer("saxophone.wav"),
                new SoundPlayer("guitar.wav"),
                new SoundPlayer("trumpet.wav"),
                new SoundPlayer("clarinet.wav"),
                new SoundPlayer("violin.wav"),
            };

            int[] juisteVolgorde = new int[10];
            Random randomGeluiden = new Random();
            for (int i = 0; i < 10; i++)
            {
                juisteVolgorde[i] = randomGeluiden.Next(geluiden.Length);
            }

            foreach (int afspelen in juisteVolgorde)
            {
                geluiden[afspelen].Play();
            }

            Console.ReadKey();
        }
    }
}
