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

namespace _WpfIngredienten__vervolg__
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

            string aantalPersonen = comboBox1.SelectedItem.ToString();
            string hoeveelheid1 = txtBox1.Text;
            string hoeveelheid2 = txtBox2.Text;
            string hoeveelheid3 = txtBox3.Text;
            string hoeveelheid4 = txtBox4.Text;
            string eenheid2 = comboBox3.SelectedItem.ToString();
            string eenheid3 = comboBox4.SelectedItem.ToString();
            string eenheid4 = comboBox5.SelectedItem.ToString();
            string ingred1 = txtIngr1.Text;
            string ingred2 = txtIngr2.Text;
            string ingred3 = txtIngr3.Text;
            string ingred4 = txtIngr4.Text;
            int boodschappenlijn1 = Int32.Parse(aantalPersonen) * Int32.Parse(hoeveelheid1);
            int boodschappenlijn2 = Int32.Parse(aantalPersonen) * Int32.Parse(hoeveelheid2);
            int boodschappenlijn3 = Int32.Parse(aantalPersonen) * Int32.Parse(hoeveelheid3);
            int boodschappenlijn4 = Int32.Parse(aantalPersonen) * Int32.Parse(hoeveelheid4);
            txtBoodschappen.Text = "- " + boodschappenlijn1 + " " + ingred1 + Environment.NewLine
                + "- " + boodschappenlijn2 + " " + eenheid2 + " " + ingred2 + Environment.NewLine
                + "- " + boodschappenlijn3 + " " + eenheid3 + " " + ingred3 + Environment.NewLine
                + "- " + boodschappenlijn4 + " " + eenheid4 + " " + ingred4;
        }
    }
}
