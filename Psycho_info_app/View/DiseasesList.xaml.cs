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
using System.Xml;
using Microsoft.Win32;
using Psycho_info_app.ViewModel;

namespace Psycho_info_app.View
{
    public partial class DiseasesList : UserControl
    {
        public DiseasesList()
        {
            InitializeComponent();

            XmlDocument xml = new XmlDocument();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\DiseasesDB.xml";

            xml.Load(path);

            XmlNodeList diseasesList = xml.DocumentElement.SelectNodes("/Diseases/List");
            int i = 0;

            foreach (XmlNode list in diseasesList)
            {
                if ( diseasesList.Count - 1 != i)
                {
                    Button button = new Button();

                    button.Content = list.SelectSingleNode("Name").InnerText.ToString();
                    button.Name = list.SelectSingleNode("Number").InnerText.ToString();
                    button.Style = (Style)FindResource("Disease_Button");
                    button.Click += Button_Click;

                    Buttons.Children.Add(button);
                    i++;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            string info = button.Name;

            DiseaseInfo diseaseInfo = new DiseaseInfo(info);

            diseaseInfo.Show();
        }

    }
}
