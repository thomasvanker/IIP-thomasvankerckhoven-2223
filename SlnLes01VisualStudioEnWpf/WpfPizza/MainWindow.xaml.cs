using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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

namespace WpfPizza
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

        private void rbn1_Checked(object sender, RoutedEventArgs e)
        {
            txtblkBestel.Text = "Tomatensaus, mozzarella & oregano";
            imgPhoto.Source = new BitmapImage(new Uri("images/hot & spicy.jpg", UriKind.Relative));

        }

        private void rbn2_Checked(object sender, RoutedEventArgs e)
        {
            txtblkBestel.Text = "4 seizoenen";
            imgPhoto.Source = new BitmapImage(new Uri("images/4 szns.jpg", UriKind.Relative));
        }

        private void rbn3_Checked(object sender, RoutedEventArgs e)
        {
            txtblkBestel.Text = "Tomatensaus, mozzarella, rode ui, kip" + Environment.NewLine + "paprika, pepperoni & spaanse pepers";
            imgPhoto.Source = new BitmapImage(new Uri("images/hawai.jpeg", UriKind.Relative));
        }
    }
}
