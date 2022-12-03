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

namespace WpfSliderKleur
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblValueChanger.Content = Math.Round(sld1.Value, 0);

            if (sld1.Value <= 25)
            {
                lblValueChanger.Foreground = new SolidColorBrush((Color)Colors.Green);
            }
            else if (sld1.Value <= 50)
            {
                lblValueChanger.Foreground = new SolidColorBrush((Color)Colors.Yellow);
            }
            else if (sld1.Value <= 75)
            {
                lblValueChanger.Foreground = new SolidColorBrush((Color)Colors.Orange);
            }
            else if (sld1.Value <= 100)
            {
                lblValueChanger.Foreground = new SolidColorBrush((Color)Colors.Red);
            }
        }
    }
}
