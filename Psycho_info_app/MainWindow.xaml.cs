﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace Psycho_info_app
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string path = Directory.GetCurrentDirectory() + "\\Materials\\mainBackground1.png";

            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri(path));

            this.Background = imageBrush;

            InitializeComponent();
        }
    }
}
