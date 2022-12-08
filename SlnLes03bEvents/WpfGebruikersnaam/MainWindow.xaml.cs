﻿using System;
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

namespace WpfGebruikersnaam
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

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUsername.Text.Contains(" "))
            {
                lblSpaties.Content = "Mag geen spaties bevatten" ;
                txtUsername.Background = Brushes.Red;
            }
            else
            {
                lblSpaties.Content = "";
                txtUsername.Background = Brushes.LightGreen;
            }

            if (txtUsername.Text.Any(char.IsDigit))
            {
                lblCijfer.Content = "";
                txtUsername.Background = Brushes.LightGreen;
            }
            else
            {
                lblCijfer.Content = "Moet een cijfer bevatten" ;
                txtUsername.Background = Brushes.Red;
            }
        }
    }
}
