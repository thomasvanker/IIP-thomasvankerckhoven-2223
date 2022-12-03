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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int MAXPOGINGEN = 3;
        int pogingNr = 1;
        int randomGetal;
        public MainWindow()
        {

            InitializeComponent();
            Random rdn = new Random();
            randomGetal = rdn.Next(1, 10);
        }

        private void txtRaad_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool bevatTekst = txtGok.Text != "";
            btnControleer.IsEnabled = bevatTekst;

        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            int gok = Convert.ToInt32(txtGok.Text);

            int pogingOver = MAXPOGINGEN - pogingNr;
            string pogingBericht;
            if (pogingOver > 1) {
                pogingBericht = $"Je hebt nog {pogingOver} pogingen over";
            } else if (pogingOver == 1) {
                pogingBericht = $"Je hebt nog 1 poging over";
            }
            else {
                pogingBericht = $"Je hebt geen pogingen meer over";
                btnControleer.IsEnabled = false;
            }
            lblPogingen.Content = pogingBericht;

            if (gok == randomGetal) 
            {
                lblPogingen.Content = "geraden!";
                btnControleer.IsEnabled = false;
            } 
            else if (gok < randomGetal) 
            {
                lblPogingen.Content = "te laag! " + pogingBericht;
            }
            else
            {
                lblPogingen.Content = "te hoog! " + pogingBericht;
            }
                
            pogingNr++;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rdn = new Random();
            randomGetal = rdn.Next(1, 10);
            lblPogingen.Content = "";
            txtGok.Text = "";

        }
    }
}
