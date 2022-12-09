using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
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

namespace WpfOpties
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

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            imgCheck.Visibility = Visibility.Visible;
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            imgCheck.Visibility = Visibility.Visible;
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            txtNamelijk.Visibility = Visibility.Visible;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            imgCheck.Visibility = Visibility.Hidden;
        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            imgCheck.Visibility = Visibility.Hidden;
        }

        private void checkBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            txtNamelijk.Visibility = Visibility.Hidden;
        }

        private void txtNamelijk_TextChanged(object sender, TextChangedEventArgs e)
        {
            imgCheck.Visibility = Visibility.Visible;
            if (txtNamelijk.Text == "")
            {   
                imgCheck.Visibility = Visibility.Hidden;
            }
        }
    }
}
