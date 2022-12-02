using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.ExceptionServices;
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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int first;
        int second;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "8";
          
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + "0";
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = "";
            txtCijfer.Text = "";
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            Random rdn = new Random();
            int randomNumber = rdn.Next(0,100);
            txtTotaal.Text = randomNumber.ToString();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtTotaal.Text);
            string op = "-";
            txtCijfer.Text = txtTotaal.Text;
            txtTotaal.Text = "";

        }

        private void btnMaal_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtTotaal.Text);
            string op = "*";
            txtCijfer.Text = txtTotaal.Text;
            txtTotaal.Text = "";
        }

        private void btnDeel_Click(object sender, RoutedEventArgs e)
        {
            first = Int32.Parse(txtTotaal.Text);
            string op = "/";
            txtCijfer.Text = txtTotaal.Text;
            txtTotaal.Text = "";
        }

        private void btnKomma_Click(object sender, RoutedEventArgs e)
        {
            txtTotaal.Text = txtTotaal.Text + ".";
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
