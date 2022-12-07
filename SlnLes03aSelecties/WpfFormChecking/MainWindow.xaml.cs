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
using System.Xml.Linq;

namespace WpfFormChecking
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
            int aantalfouten = 0;
            if (txtEmail1.Text == "")
            {
                lblEmail.Content =  "email moet ingevuld zijn";
                aantalfouten++;
            }

            if (txtNaam.Text == "")
            {
                lblNaam.Content = "naam moet ingevuld zijn";
                aantalfouten++;
            }

            if (txtPaswoord.Text == "")
            {
                lblPaswoord.Content = "kies een paswoord";
                aantalfouten++;
            }

            if (datePicker.Text == "")
            {
                lblGeboorte.Content = "datum moet ingevuld zijn";
                aantalfouten++;
            }

            if (comboBox.Text == "")
            {
                lblProfiel.Content = "maak een keuze";
                aantalfouten++;
            }





            lblBevat.Content = $"dit formulier bevat {aantalfouten} fouten";


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblEmail.Content = "";
            lblNaam.Content = "";
            lblGeboorte.Content = "";
            lblGeslacht.Content = "";
            lblnt.Content = "";
            lblPaswoord.Content = "";
            lblProfiel.Content = "";
            txtEmail1.Text = "";
            txtNaam.Text = "";
            txtPaswoord.Text = "";
            lblBevat.Content = "";
        }
    }
}
