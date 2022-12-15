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

namespace WpfEllipsen
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

        private void btnTekenen_Click(object sender, RoutedEventArgs e)
        {
            canvas1.Children.Clear();
            int numEllipses = (int)aantalSlider.Value;
            int maxEllipse = (int)maximumSlider.Value;
            int minEllipse = (int)minimumSlider.Value;
            int MAX_RADIUS = 0;
            int MIN_RADIUS = 0;
            Random random = new Random();
            for (int i = 0; i < numEllipses; i++)
            {
                Ellipse newEllipse = new Ellipse();

                if (minEllipse < maxEllipse)
                {
                    newEllipse.Width = random.Next(minEllipse, maxEllipse);
                    newEllipse.Height = random.Next(minEllipse, maxEllipse);

                    newEllipse.Fill = new SolidColorBrush(Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));

                    MIN_RADIUS = (int)canvas1.ActualWidth - (int)newEllipse.Width;
                    MAX_RADIUS = (int)canvas1.ActualHeight - (int)newEllipse.Height;
                    newEllipse.Margin = new Thickness(random.Next(0, MIN_RADIUS), random.Next(0, MAX_RADIUS), 0, 0);


                    canvas1.Children.Add(newEllipse);
                }
                else
                {
                    lblError.Content = "De minimum straal mag niet groter zijn dan de maximum straal!";
                    lblError.Foreground = Brushes.Red;
                }
            }
        }

        private void aantalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblAantal.Content = Math.Round(aantalSlider.Value, 0);
        }

        private void minimumSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMIN.Content = Math.Round(minimumSlider.Value, 0);
        }

        private void maximumSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblMax.Content = Math.Round(maximumSlider.Value, 0);
        }
    }
}
