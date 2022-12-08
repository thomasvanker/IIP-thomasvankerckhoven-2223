using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace WpfOxo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool turn = true;
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Content  = "x";
                turn = !turn;
            }
            else
            {
                b.Content = "O";
                turn = !turn;
            }
            b.IsEnabled = false;

            checkforwinner();
        }
        
        private void checkforwinner()
        {
            bool there_is_a_winner = false;
            if ((button1.Content == button2.Content) && (button2.Content == button3.Content) && (!button1.IsEnabled))
                there_is_a_winner = true; 
            else if ((button4.Content == button5.Content) && (button5.Content == button6.Content) && (button4.IsEnabled))
                there_is_a_winner = true;
            else if ((button7.Content == button8.Content) && (button8.Content == button9.Content) && (button7.IsEnabled))
                there_is_a_winner = true;

            if(there_is_a_winner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                lblWinner.Content = $"{winner} wins heeft gewonnen";
            }
        }
    }
}
