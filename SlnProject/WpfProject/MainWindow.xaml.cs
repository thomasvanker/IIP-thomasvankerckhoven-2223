using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private string[] Instruments = { "cello.wav, clarinetWAV.wav, drums.wav", "flute.wav", "guitar.wav", "harp.wav", "piano.wav", "saxophone.wav", "trumpet.wav", "violin.wav" };
        private SoundPlayer soundplayer = new SoundPlayer();

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
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; //continue
        }
    }
}
