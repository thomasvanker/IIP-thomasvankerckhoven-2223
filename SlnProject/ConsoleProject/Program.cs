using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<string> geluiden = new List<string>();
            {
                SoundPlayer cello = new SoundPlayer("cello.wav");
                SoundPlayer clarinet = new SoundPlayer("clarinet.wav");
                SoundPlayer drums = new SoundPlayer("drums.wav");
                SoundPlayer flute = new SoundPlayer("flute.wav");
                SoundPlayer guitar = new SoundPlayer("guitar.wav");
                SoundPlayer harp = new SoundPlayer("harp.wav");
                SoundPlayer piano = new SoundPlayer("piano.wav");
                SoundPlayer saxophone = new SoundPlayer("saxophone.wav");
                SoundPlayer trumpet = new SoundPlayer("trumpet.wav");
                SoundPlayer violin = new SoundPlayer("violin (1).wav");
            };

            List<string> songs = new List<string>()
            {
                "cello.wav",
                "clarinetWAV.wav",
                "drums.wav",
                "flute.wav",
                "guitar.wav",
                "harp.wav",
                "piano.wav",
                "saxophone.wav",
                "trumpet.wav",
                "violin.wav"
            };

            Dictionary<string, string> songNames = new Dictionary<string, string>()
            {
                { "cello.wav", "cello" },
                { "clarinetWAV.wav", "clarinet" },
                { "drums.wav", "drums" },
                { "flute.wav", "flute" },
                { "guitar.wav", "guitar" },
                { "harp.wav", "harp" },
                { "piano.wav", "piano" },
                { "saxophone.wav", "saxophone" },
                { "trumpet.wav","trumpet" },
                { "violin.wav", "violin" }
            };


            Console.WriteLine("_______________________¶¶¶¶¶¶¶¶___________________\r\n_______________________¶¶¶¶¶¶¶¶¶¶¶¶¶______________\r\n___________¶¶__________¶¶¶¶¶____¶¶¶¶______________\r\n_________¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶______________\r\n________¶¶¶¶¶¶¶________¶¶¶___¶¶¶¶¶¶¶____¶¶¶_______\r\n_______¶¶¶__¶¶¶________¶¶¶________¶¶¶___¶¶¶_______\r\n_______¶¶___¶¶¶_________¶¶________¶¶¶____¶¶¶______\r\n______¶¶¶__¶¶¶¶_________¶¶_________¶¶_____¶¶¶_____\r\n______¶¶¶_¶¶¶¶______¶¶__¶¶¶________¶¶¶_____¶¶¶____\r\n_______¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶¶________¶¶¶______¶¶¶___\r\n______¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶_______¶¶¶__\r\n____¶¶¶¶¶¶_______¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶________¶¶¶_\r\n___¶¶¶¶¶¶¶________¶¶¶¶¶¶¶___¶¶¶¶¶¶¶¶¶¶_________¶¶_\r\n__¶¶¶¶__¶¶¶¶¶¶¶¶_____¶¶______¶¶¶¶¶¶¶¶______¶¶¶¶¶¶¶\r\n_¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶_____¶¶¶________¶¶¶¶¶¶¶¶\r\n¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶____________¶¶¶¶¶¶¶¶¶\r\n¶¶¶¶_¶¶¶¶¶¶¶___¶¶¶¶___¶¶¶¶¶¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶\r\n¶¶¶__¶¶¶__¶¶____¶¶¶____¶¶¶_¶¶¶¶¶¶¶________¶¶¶¶¶¶¶¶\r\n¶¶¶¶__¶¶__¶¶¶___¶¶¶____¶¶¶____¶¶¶¶¶__________¶¶___\r\n_¶¶¶¶_____¶¶¶__¶¶¶¶_____¶¶¶_____¶¶¶¶______________\r\n_¶¶¶¶¶¶¶___¶¶¶¶¶¶¶_______¶¶¶_____¶¶¶______________\r\n___¶¶¶¶¶¶¶¶¶¶¶¶¶_________¶¶¶______¶¶______________\r\n_______¶¶¶¶¶¶¶____________¶¶¶_____¶_______________\r\n____________¶¶¶____________¶¶¶____________________\r\n____¶¶¶¶¶¶__¶¶¶________¶¶¶¶¶¶¶____________________\r\n____¶¶¶¶¶¶¶_¶¶¶______¶¶¶¶¶¶¶¶¶¶___________________\r\n____¶¶¶¶¶¶_¶¶¶______¶¶¶¶¶¶¶¶¶¶¶¶__________________\r\n_____¶¶¶¶¶¶¶¶¶______¶¶¶¶¶¶¶¶¶¶¶___________________\r\n_______¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶____________________\r\n______________________¶¶¶¶¶¶______________________");
            Console.Write("\r\n  _____    __  __  _____  __                 __    __  _____     ___  __    ___ __    __  ___  _____ \r\n  \\_   \\/\\ \\ \\/ _\\/__   \\/__\\/\\ /\\  /\\/\\    /__\\/\\ \\ \\/__   \\   / _ \\/__\\  /___\\\\ \\  /__\\/ __\\/__   \\\r\n   / /\\/  \\/ /\\ \\   / /\\/ \\// / \\ \\/    \\  /_\\ /  \\/ /  / /\\/  / /_)/ \\// //  // \\ \\/_\\ / /     / /\\/\r\n/\\/ /_/ /\\  / _\\ \\ / / / _  \\ \\_/ / /\\/\\ \\//__/ /\\  /  / /    / ___/ _  \\/ \\_//\\_/ //__/ /___  / /   \r\n\\____/\\_\\ \\/  \\__/ \\/  \\/ \\_/\\___/\\/    \\/\\__/\\_\\ \\/   \\/     \\/   \\/ \\_/\\___/\\___/\\__/\\____/  \\/    \r\n                                                                                                     \r\n");
            Console.WriteLine();
            Console.Write("Welcome to the Instrument Sequence Game! What is your name? ");
            string naam = Console.ReadLine();
            Console.Write($"Hey {naam}, How many sounds should be played? (8-10) ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            bool yesNoLoop = true;
            while (yesNoLoop)
            {
                Console.Write($"Are you sure you want to play with {aantal} sounds (y/n): ");
                string yesNo = Console.ReadLine();
                Console.Clear();
                if (yesNo == "y")
                {
                    yesNoLoop = false;
                    Console.Clear();
                    Console.WriteLine($"All hail Goofenlord {naam}, that has chosen {aantal} sounds to be played!");
                }

                else if (yesNo == "n") 
                {
                    Console.Write($"Hey {naam}, How many sounds should be played? (8-10) ");
                    aantal = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Clear();

            Console.WriteLine("Are You Ready? y/n: ");
            string Ready = Console.ReadLine();
            if (Ready == "y")
            {
                for (int i = 1; i <= aantal; i++)
                {
                    Console.Clear();
                    Console.WriteLine("You have the choice between: \r\ncello, clarinet, drums, flute, guitar, harp, piano, saxophone, trumpet, violin. ");
                    Console.WriteLine();
                    Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~._");
                    Console.WriteLine();
                    Console.WriteLine("\r\n  ___ _  _ ___ _____ ___ _   _ __  __ ___ _  _ _____   ___ _      ___   _____ _  _  ___ \r\n |_ _| \\| / __|_   _| _ \\ | | |  \\/  | __| \\| |_   _| | _ \\ |    /_\\ \\ / /_ _| \\| |/ __|\r\n  | || .` \\__ \\ | | |   / |_| | |\\/| | _|| .` | | |   |  _/ |__ / _ \\ V / | || .` | (_ |\r\n |___|_|\\_|___/ |_| |_|_\\\\___/|_|  |_|___|_|\\_| |_|   |_| |____/_/ \\_\\_| |___|_|\\_|\\___|\r\n                                                                                        \r\n");
                    Console.WriteLine();
                    Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~._");
                    foreach (string song in songs)
                    {
                        SoundPlayer player = new SoundPlayer(song);
                        player.PlaySync();
                    }
                    Console.WriteLine();
                    Console.Write($"What is your guess for instrument {i}: ");
                    string antwoord = Console.ReadLine();
                }
                
            }

            else if (Ready == "n") 
            { 
                Console.Clear() ;
                Console.WriteLine("\r\n.____    ________    ______________________________ \r\n|    |   \\_____  \\  /   _____/\\_   _____/\\______   \\\r\n|    |    /   |   \\ \\_____  \\  |    __)_  |       _/\r\n|    |___/    |    \\/        \\ |        \\ |    |   \\\r\n|_______ \\_______  /_______  //_______  / |____|_  /\r\n        \\/       \\/        \\/         \\/         \\/ \r\n");
            }
            Console.ReadKey();
        }
    }
}
