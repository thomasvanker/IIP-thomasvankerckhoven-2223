using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WMPLib;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using System.Xml.Linq;

namespace WpfProject
{
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private SoundPlayer soundplayer = new SoundPlayer();
        private int score;
        private string naamSpeler;
        private int aantalInstru;
        string[] songNames = { "violin", "clarinet", "cello", "guitar", "flute", "harp", "drums", "piano", "trumpet", "saxophone" };
        private SoundPlayer player;
        private string[] instruments = new string[] { "violin.wav", "clarinetWAV.wav", "cello.wav", "guitar.wav", "flute.wav", "harp.wav", "drums.wav", "piano.wav", "trumpet.wav", "saxophone.wav" };
        private WindowsMediaPlayer afspelen = new WindowsMediaPlayer();
        private int currentIndex = 0;

        List<string> imageList = new List<string>()
            {
                "cello.png",
                "clarinet.png",
                "drums.png",
                "flute.png",
                "guitar.png",
                "harp.png",
                "piano.png",
                "saxophone.png",
                "trumpet.png",
                "violin.png"
            };

        public MainWindow()
        {
            InitializeComponent();
            player = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\WpfProject\\sounds\\backgroundmusic.wav");
            player.Play();
            btnReset.IsEnabled = false;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnReset.IsEnabled = true;
            afspelen.currentPlaylist.clear();
            for (int i = 0; i < aantalInstru; i++)
            {
                afspelen.currentPlaylist.appendItem(afspelen.newMedia(instruments[i]));
            }
            afspelen.controls.play();
        }

        private void naamBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            naamSpeler = naamBox.Text;
           
        }

        private void soundsBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            aantalInstru = Convert.ToInt32(soundsBox.Text);
            LaagOfHoog(aantalInstru);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == songNames[currentIndex])
            {
                score++;
                scoreLabel.Content = $"{score} instruments correct!";
                SoundPlayer correct = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\ConsoleProject\\sounds\\correct.wav");
                correct.Play();
                currentIndex++;
                if (currentIndex == aantalInstru)
                {
                    btnStart.IsEnabled = false;
                    afspelen.controls.pause();
                    listBox.Items.Add($"{naamSpeler} - {points(score, 100)} pts.");
                    scoreLabel.Content = $"All {aantalInstru} instruments correct!";
                    SoundPlayer win = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\WpfProject\\sounds\\announcement.wav");
                    win.Play();
                    MessageBox.Show($"Congratulations {naamSpeler}, You guessed all of them right!");
                }

            }
            else
            {
                afspelen.controls.pause();
                btnStart.IsEnabled = false;
                listBox.Items.Add($"{naamSpeler} - {points(score, 100)} pts.");
                SoundPlayer lose = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\ConsoleProject\\sounds\\chipmunksLose.wav");
                lose.Play();
                MessageBox.Show("You got it wrong, STOOPID!");
                currentIndex = 0;
            }

        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
            score = 0;
            currentIndex = 0;
            scoreLabel.Content = "";
            naamBox.Text = "";
            afspelen.currentPlaylist.clear();

        }

        private void LaagOfHoog (int getal)
        {
            if (getal < 8 || getal > 10)
            {
                soundsBox.Background = Brushes.Red;
                MessageBox.Show($"Hey {naamSpeler}, you need to choose between 8 - 10! ");
            }
            else
            {
                soundsBox.Background = Brushes.Green;
            }
        }
        public int points(int num1, int num2)
        {
            int resultaat = num1 * num2;
            return resultaat;
        }

    }
}
