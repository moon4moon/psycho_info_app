using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using Microsoft.Win32;
using Psycho_info_app.Model;
using Psycho_info_app.ViewModel;

namespace Psycho_info_app.View
{
    public partial class DiseasesList : UserControl
    {
        public DiseasesList()
        {
            InitializeComponent();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\cos.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string cosiek = sr.ReadLine();

                    Button button = new Button();

                    button.Content = cosiek;
                    button.Name = cosiek.ToString();
                    button.Click += Button_Click;

                    Buttons.Children.Add(button);

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TESTOWE objTestowe = new TESTOWE();
            InfoSend infoSend = new InfoSend();

            Button button = sender as Button;

            infoSend.infoSend(button.Name);

            objTestowe.Show();
        }

    }
}
