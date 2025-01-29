using System;
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
using System.Xml;

namespace Psycho_info_app.View
{
    /// <summary>
    /// Logika interakcji dla klasy Tests.xaml
    /// </summary>
    public partial class Tests : UserControl
    {
        public Tests()
        {
            InitializeComponent();

            XmlDocument xml = new XmlDocument();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\TestsDB.xml";

            xml.Load(path);

            XmlNodeList testsList = xml.DocumentElement.SelectNodes("/Tests/List");
            int i = 0;

            foreach (XmlNode list in testsList)
            {
                if (testsList.Count - 1 != i)
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

            string test = button.Name;

            TestWindow testWindow = new TestWindow(test);

            testWindow.Show();
        }
    }
}
