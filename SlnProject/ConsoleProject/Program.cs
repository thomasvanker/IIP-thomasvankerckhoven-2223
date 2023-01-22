using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using System.Data;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

namespace ConsoleProject
{
    internal class Program
    {
        public static string FancyText(string text)
        {
            string fancyManier = "";
            fancyManier += "**********\n";
            fancyManier += "*  " + text + "  *\n";
            fancyManier += "**********\n";
            fancyManier += "Input: ";
            return fancyManier;
        }

        private static string naam;

        static void Main(string[] args)
        {
            SoundPlayer lose = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\ConsoleProject\\sounds\\chipmunksLose.wav");
            SoundPlayer win = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\ConsoleProject\\sounds\\correct.wav");
            

            while(true) {

                List<SoundPlayer> geluiden = new List<SoundPlayer>();
                {
                    geluiden.Add(new SoundPlayer(@"C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\ConsoleProject\\sounds\\cello.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\clarinetWAV.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\drums.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\flute.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\guitar.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\harp.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\piano.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\saxophone.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\trumpet.wav"));
                    geluiden.Add(new SoundPlayer(@"C:\Users\thoma\OneDrive\Documents\GitHub\IIP-thomasvankerckhoven-2223\SlnProject\ConsoleProject\sounds\violin.wav"));
                };

                string[] songNames = { "cello", "clarinet", "drums", "flute", "guitar", "harp", "piano", "saxophone", "trumpet", "violin" };

                int MAXINSTRUMENTS = 10;
                int MININSTRUMENTS = 8;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("_______________________¶¶¶¶¶¶¶¶___________________\r\n_______________________¶¶¶¶¶¶¶¶¶¶¶¶¶______________\r\n___________¶¶__________¶¶¶¶¶____¶¶¶¶______________\r\n_________¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶______________\r\n________¶¶¶¶¶¶¶________¶¶¶___¶¶¶¶¶¶¶____¶¶¶_______\r\n_______¶¶¶__¶¶¶________¶¶¶________¶¶¶___¶¶¶_______\r\n_______¶¶___¶¶¶_________¶¶________¶¶¶____¶¶¶______\r\n______¶¶¶__¶¶¶¶_________¶¶_________¶¶_____¶¶¶_____\r\n______¶¶¶_¶¶¶¶______¶¶__¶¶¶________¶¶¶_____¶¶¶____\r\n_______¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶¶________¶¶¶______¶¶¶___\r\n______¶¶¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶¶_______¶¶¶__\r\n____¶¶¶¶¶¶_______¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶¶¶¶________¶¶¶_\r\n___¶¶¶¶¶¶¶________¶¶¶¶¶¶¶___¶¶¶¶¶¶¶¶¶¶_________¶¶_\r\n__¶¶¶¶__¶¶¶¶¶¶¶¶_____¶¶______¶¶¶¶¶¶¶¶______¶¶¶¶¶¶¶\r\n_¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶¶_____¶¶¶________¶¶¶¶¶¶¶¶\r\n¶¶¶¶__¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶¶¶¶¶¶____________¶¶¶¶¶¶¶¶¶\r\n¶¶¶¶_¶¶¶¶¶¶¶___¶¶¶¶___¶¶¶¶¶¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶\r\n¶¶¶__¶¶¶__¶¶____¶¶¶____¶¶¶_¶¶¶¶¶¶¶________¶¶¶¶¶¶¶¶\r\n¶¶¶¶__¶¶__¶¶¶___¶¶¶____¶¶¶____¶¶¶¶¶__________¶¶___\r\n_¶¶¶¶_____¶¶¶__¶¶¶¶_____¶¶¶_____¶¶¶¶______________\r\n_¶¶¶¶¶¶¶___¶¶¶¶¶¶¶_______¶¶¶_____¶¶¶______________\r\n___¶¶¶¶¶¶¶¶¶¶¶¶¶_________¶¶¶______¶¶______________\r\n_______¶¶¶¶¶¶¶____________¶¶¶_____¶_______________\r\n____________¶¶¶____________¶¶¶____________________\r\n____¶¶¶¶¶¶__¶¶¶________¶¶¶¶¶¶¶____________________\r\n____¶¶¶¶¶¶¶_¶¶¶______¶¶¶¶¶¶¶¶¶¶___________________\r\n____¶¶¶¶¶¶_¶¶¶______¶¶¶¶¶¶¶¶¶¶¶¶__________________\r\n_____¶¶¶¶¶¶¶¶¶______¶¶¶¶¶¶¶¶¶¶¶___________________\r\n_______¶¶¶¶¶_________¶¶¶¶¶¶¶¶¶____________________\r\n______________________¶¶¶¶¶¶______________________");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\r\n  _____    __  __  _____  __                 __    __  _____     ___  __    ___ __    __  ___  _____ \r\n  \\_   \\/\\ \\ \\/ _\\/__   \\/__\\/\\ /\\  /\\/\\    /__\\/\\ \\ \\/__   \\   / _ \\/__\\  /___\\\\ \\  /__\\/ __\\/__   \\\r\n   / /\\/  \\/ /\\ \\   / /\\/ \\// / \\ \\/    \\  /_\\ /  \\/ /  / /\\/  / /_)/ \\// //  // \\ \\/_\\ / /     / /\\/\r\n/\\/ /_/ /\\  / _\\ \\ / / / _  \\ \\_/ / /\\/\\ \\//__/ /\\  /  / /    / ___/ _  \\/ \\_//\\_/ //__/ /___  / /   \r\n\\____/\\_\\ \\/  \\__/ \\/  \\/ \\_/\\___/\\/    \\/\\__/\\_\\ \\/   \\/     \\/   \\/ \\_/\\___/\\___/\\__/\\____/  \\/    \r\n                                                                                                     \r\n");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                string text = "Welcome to the Instrument Sequence Game! What is your name? ";
                string veranderdeText = FancyText(text);
                Console.Write(veranderdeText);
                naam = Console.ReadLine();
                Console.WriteLine("");
                string text2 = $"Hey {naam}, How many sounds should be played? (8-10) ";
                string veranderdeText2 = FancyText(text2);
                Console.Write(veranderdeText2);
                int aantal = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                while (aantal < MININSTRUMENTS || aantal > MAXINSTRUMENTS)
                {
                    Console.Clear();
                    Console.Write("Invalid input. Please enter a number between (8-10): ");
                    aantal = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                bool yesNoLoop = true;
                while (yesNoLoop)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
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
                        while (aantal < MININSTRUMENTS || aantal > MAXINSTRUMENTS)
                        {
                            Console.WriteLine("Invalid input. Please enter a number between (8-10): ");
                            aantal = int.Parse(Console.ReadLine());
                        }
                    }
                }

                Console.Clear();

                int juisteAnwtoord = 0;
                int instru = 0;
                int b = 0;

                Console.Write("Are You Ready? y/n: ");
                string Ready = Console.ReadLine();
                if (Ready == "y")
                {
                    for (int i = 0; i <= aantal; i++)
                    {
                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have the choice between: \r\nclarinet, cello, flute, drums, harp, guitar, saxophone, piano, violin, trumpet. ");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~    \"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~._");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\r\n  ___ _  _ ___ _____ ___ _   _ __  __ ___ _  _ _____   ___ _      ___   _____ _  _  ___ \r\n |_ _| \\| / __|_   _| _ \\ | | |  \\/  | __| \\| |_   _| | _ \\ |    /_\\ \\ / /_ _| \\| |/ __|\r\n  | || .` \\__ \\ | | |   / |_| | |\\/| | _|| .` | | |   |  _/ |__ / _ \\ V / | || .` | (_ |\r\n |___|_|\\_|___/ |_| |_|_\\\\___/|_|  |_|___|_|\\_| |_|   |_| |____/_/ \\_\\_| |___|_|\\_|\\___|\r\n                                                                                        \r\n");
                        Console.WriteLine();
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine("_.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~.__.~\"~._.~\"~._.~\"~._.~\"~._");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        geluiden[i].Play();
                        Console.Write($"What is your guess for instrument {b}: ");
                        string antwoord = Console.ReadLine();
                        
                        if (antwoord == songNames[i])
                        {
                            
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            geluiden[i].Stop();
                            Console.Clear();
                            Console.WriteLine("\r\n __    __     _ _     ___ _                      _ \r\n/ / /\\ \\ \\___| | |   / _ \\ | __ _ _   _  ___  __| |\r\n\\ \\/  \\/ / _ \\ | |  / /_)/ |/ _` | | | |/ _ \\/ _` |\r\n \\  /\\  /  __/ | | / ___/| | (_| | |_| |  __/ (_| |\r\n  \\/  \\/ \\___|_|_| \\/    |_|\\__,_|\\__, |\\___|\\__,_|\r\n                                  |___/            \r\n");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Congratulations, you guessed all {aantal} instruments! "); 
                            win.Load();
                            win.Play();
                            Console.WriteLine("");
                            int multiplier = 100;
                            scoreBoard(juisteAnwtoord, multiplier);
                            Console.WriteLine("");
                            juisteAnwtoord++;
                            instru++;
                            b++;
                        }
                        else
                        {
                            
                            lose.Load();
                            lose.Play();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine("\r\n  ____     _   _   __  __     ____      _      ____    ____        \r\n |  _\"\\ U |\"|u| |U|' \\/ '|uU | __\")uU  /\"\\  u / __\"| u/ __\"| u     \r\n/| | | | \\| |\\| |\\| |\\/| |/ \\|  _ \\/ \\/ _ \\/ <\\___ \\/<\\___ \\/      \r\nU| |_| |\\ | |_| | | |  | |   | |_) | / ___ \\  u___) | u___) |      \r\n |____/ u<<\\___/  |_|  |_|   |____/ /_/   \\_\\ |____/>>|____/>>     \r\n  |||_  (__) )(  <<,-,,-.   _|| \\\\_  \\\\    >>  )(  (__))(  (__)    \r\n (__)_)     (__)  (./  \\.) (__) (__)(__)  (__)(__)    (__)         \r\n");
                            i--;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("");
                            int multiplier = 100;
                            scoreBoard(juisteAnwtoord, multiplier);
                            Console.WriteLine("");
                            Console.WriteLine($"Nice try {naam} you got {juisteAnwtoord} correct! ");
                            break;
                        }
                    }
                }

                else if (Ready == "n")
                {
                    Console.Clear();
                    Console.WriteLine("\r\n.____    ________    ______________________________ \r\n|    |   \\_____  \\  /   _____/\\_   _____/\\______   \\\r\n|    |    /   |   \\ \\_____  \\  |    __)_  |       _/\r\n|    |___/    |    \\/        \\ |        \\ |    |   \\\r\n|_______ \\_______  /_______  //_______  / |____|_  /\r\n        \\/       \\/        \\/         \\/         \\/ \r\n");
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Do you want to play again (y/n): ");
                string antwoord2 = Console.ReadLine();

                if (antwoord2 == "n")
                {
                    break;
                }

                Console.Clear();

                continue;
            }
        }
        static void scoreBoard(int punten, int score)
        {
            int scoreboard = punten * score;
            Console.WriteLine($"{naam} - {scoreboard}");
        }


    }
}
