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

namespace WpfInterest
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
            lblSliderValue.Content = sld1.Value;
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double startBedrag;
            double interestPercent;
            double interestKomma;
            double periode;
            double endbedrag;
            startBedrag = Convert.ToDouble(txtBedrag.Text);
            interestPercent = Convert.ToDouble(txtJaarlijkse.Text);
            periode = Convert.ToDouble(lblSliderValue.Content);
            interestKomma = interestPercent / 100;
            endbedrag = startBedrag * Math.Pow(1 + interestKomma, periode);
            lblJaar.Content = " De waarde na " + lblSliderValue.Content + " jaar bedraagt " + "€" + Math.Round(endbedrag, 2);

        }
    }
}
