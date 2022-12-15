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

namespace WpfPriemgetal
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);
            bool priemGetal = true;

            if (getal < 2)
            {
                priemGetal = false; 
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(getal); i++) 
                {
                    if (getal % i == 0)
                    {
                        priemGetal = false;
                        break;
                    }
                }
            }

            if (priemGetal)
            {
                txtAntwoord.Text = $"{getal} is een priemgetal";
                txtAntwoord.Foreground = Brushes.Green;
            }
            else
            {
                txtAntwoord.Text = $"{getal} is geen priemgetal";
                txtAntwoord.Foreground = Brushes.Red;
            }
        }
    }
}
