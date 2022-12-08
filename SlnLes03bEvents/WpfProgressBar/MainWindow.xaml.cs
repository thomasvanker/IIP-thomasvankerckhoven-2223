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
using System.Windows.Threading;

namespace WpfProgressBar
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

        private void progressBar_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            lblProgress.Content = progressBar.Width + "%";

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            if (progressBar.Width < 1)
            {
                btnStart.IsEnabled= false;
            }

            if (progressBar.Width <= 5)
            {
                btnAnnul.IsEnabled = true;
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 5;
            if (progressBar.Width >= 100)
            {
                string message = "Voortgang voltooid!";
                string title = "";
                MessageBox.Show(message, title);
            }
        }

        private void btnAnnul_Click(object sender, RoutedEventArgs e)
        {
            if (progressBar.Width > 1 )
            {
                progressBar.Width = 0;

            } 
            
        }
        
    }
}
