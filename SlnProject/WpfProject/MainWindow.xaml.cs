﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer("C:\\Users\\thoma\\OneDrive\\Documents\\GitHub\\IIP-thomasvankerckhoven-2223\\SlnProject\\WpfProject\\sounds\\drums.mp3");
            player.Load();
            player.Play();  
            
        }
    }
}
