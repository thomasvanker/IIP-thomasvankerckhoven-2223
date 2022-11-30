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
            lstBox.Items.Add("2,20 - 1 tros bananen");
            int less = Convert.ToInt32(lblBanaan.Content) - 1;
            lblBanaan.Content = less;
        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add("3,05 - 1 pak boter");
            int less2 = Convert.ToInt32(lblBoter.Content) - 1;
            lblBoter.Content = less2;
        }

        private void btnEggs_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Add("2,75 - 1 doos eieren");
            int less3 = Convert.ToInt32(lblEggs.Content) - 1;
            lblEggs.Content = less3;
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Clear();

        }
    }
}
