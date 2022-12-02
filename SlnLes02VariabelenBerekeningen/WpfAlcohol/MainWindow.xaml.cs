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

namespace WpfAlcohol
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

        private void sld1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSliderBeer.Content = sld1.Value + " glazen";
            myRectangle.Width = (sld1.Value * 25) + (sld2.Value * 25);
            if (myRectangle.Width > 150)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (myRectangle.Width < 200)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Green);
            }

        }

        private void sld2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSliderWine.Content = sld2.Value + " glazen";
            myRectangle.Width = (sld1.Value * 25) + (sld2.Value * 25) + (sld3.Value * 25);
            if (myRectangle.Width > 150)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (myRectangle.Width < 200)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Green);
            }
        }

        private void sld3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblSliderWhisk.Content = sld3.Value + " glazen";
            myRectangle.Width = (sld1.Value * 25) + (sld2.Value * 25) + (sld3.Value * 25);
            if (myRectangle.Width > 150)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Red);
            }
            else if (myRectangle.Width < 200)
            {
                myRectangle.Fill = new SolidColorBrush(Colors.Green);
            }
        }
        
    }
}
