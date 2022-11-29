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

namespace WpfBmi
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double lengte1;
            double lengte2;
            double lengte3;
            double gewicht;
            double bmi;
            lengte1 = Convert.ToDouble(txtLengte.Text);
            lengte2 = lengte1 / 100;
            lengte3 = lengte2 * lengte2;
            gewicht = Convert.ToDouble(txtGewicht.Text);
            bmi = gewicht / lengte3;
            lblAntw.Content = Math.Round(bmi,1);     
        }
    }
}
