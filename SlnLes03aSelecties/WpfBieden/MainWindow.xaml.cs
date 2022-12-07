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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogsteBod;
        string hoogstebieder;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBod_Click(object sender, RoutedEventArgs e)
        {
            string name = txtNaam.Text;
            string bodtext  = txtBod.Text;
            int bod = Convert.ToInt32(bodtext);

            if (bod > hoogsteBod)
            {
                txtHoogste.Text = $"{name} heeft met {bod} nu het hoogste bod!";
                hoogsteBod= bod;
                hoogstebieder = name;
            }
            else 
            {
                txtHoogste.Text = $"Sorry, {hoogstebieder} heeft momenteel het hoogste bod!";
                
            }
        }
    }
}
