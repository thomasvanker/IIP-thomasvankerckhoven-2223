using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Xml.Schema;

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(5, 50);
            int randomNumber2 = rnd.Next(5, 50);
            int randomNumber3 = rnd.Next(5, 50);
            lblBanaan.Content = randomNumber;
            lblBoter.Content = randomNumber2;
            lblEggs.Content = randomNumber3;
            
     
        }

        private void btnBanaan_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add(Math.Round(2.20, 2));
            int less = Convert.ToInt32(lblBanaan.Content) - 1;
            lblBanaan.Content = less;
            
        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add(2.75);
            int less2 = Convert.ToInt32(lblBoter.Content) - 1;
            lblBoter.Content = less2;
        }

        private void btnEggs_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add(3.05);
            int less3 = Convert.ToInt32(lblEggs.Content) - 1;
            lblEggs.Content = less3;
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            lblTotaal.Content = lstBox.Items.OfType<double>().ToArray().Sum() + " euro";
            lstBox.Items.Clear();

        }

        private void btnHerstart_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(5, 50);
            int randomNumber2 = rnd.Next(5, 50);
            int randomNumber3 = rnd.Next(5, 50);
            lblBanaan.Content = randomNumber;
            lblBoter.Content = randomNumber2;
            lblEggs.Content = randomNumber3;
            lblTotaal.Content = "";
        }
    }
}
