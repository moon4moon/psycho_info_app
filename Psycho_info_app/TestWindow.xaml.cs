using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Psycho_info_app
{
    /// <summary>
    /// Logika interakcji dla klasy TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow(string test)
        {
            InitializeComponent();

            string Info = test;

            XmlDocument xml = new XmlDocument();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\TestsDB.xml";

            xml.Load(path);

            string element = "/Tests/List[Number='" + Info + "']";

            var Tests = xml.DocumentElement.SelectSingleNode(element);

            if (Tests != null)
            {
                Title = Tests.SelectSingleNode("Name").InnerText;
                TestName.Text = Tests.SelectSingleNode("Name").InnerText;

                XmlNodeList QuestionsList = xml.DocumentElement.SelectNodes(element + "/Question");

                if (QuestionsList.Count > 0)
                {
                    foreach (XmlNode question in QuestionsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = question.SelectSingleNode("Text").InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Questions.Children.Add(textBlock);

                        string[] answerNumber = new string[5] { "one", "two", "three", "four", "five"};
                        int value = 0;

                        string questionNumber = question.SelectSingleNode("QuestionNumber").InnerText.ToString();

                        XmlNodeList AnswersList = xml.DocumentElement.SelectNodes(element + "/Question[QuestionNumber='" + questionNumber + "']/Answer");

                        foreach (XmlNode answer in AnswersList)
                        {
                            RadioButton radioButton = new RadioButton();

                            radioButton.Content = answer.InnerText;
                            radioButton.GroupName = questionNumber;
                            radioButton.Name = answerNumber[value];
                            radioButton.Style = (Style)FindResource("Radio_Info");

                            Questions.Children.Add(radioButton);

                            value++;
                        }
                    }
                }
                else
                {
                    Questions_Border.Visibility = Visibility.Collapsed;
                    Buttons_Border.Visibility = Visibility.Collapsed;

                    TestName.Text = "Test nie zawiera pytań. Jest w trakcie tworzenia.";
                    
                }

                XmlNodeList CriteriaList = xml.DocumentElement.SelectNodes(element + "/Summary/Criteria/Subpoint");

                if (CriteriaList.Count > 0)
                {
                    foreach (XmlNode criteria in CriteriaList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = criteria.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Criterias.Children.Add(textBlock);
                    }

                }

                Border border = new Border();
                border.Height = 10;

                Criterias.Children.Add(border);

                XmlNodeList CommentsList = xml.DocumentElement.SelectNodes(element + "/Summary/Comments/Subpoint");

                if (CommentsList.Count > 0)
                {
                    foreach (XmlNode comment in CommentsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = comment.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Criterias.Children.Add(textBlock);
                    }
                }

            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var children = VisualTreeHelperExtensions.GetAllChildren(Questions);

            int counting = 0;

            HashSet<string> groupNames = new HashSet<string>();

            foreach (var child in children)
            {
                if (child is RadioButton radioButton)
                {
                    if (!string.IsNullOrEmpty(radioButton.GroupName))
                    {
                        groupNames.Add(radioButton.GroupName);
                    }

                    if (radioButton.IsChecked == true)
                    {
                        counting++;
                    }
                }
            }

            if (counting == groupNames.Count)
            {
                int points = 0;

                foreach (var child in children)
                {
                    if (child is RadioButton radioButton)
                    {

                        radioButton.IsEnabled = false;

                        string Name = radioButton.Name;

                        if (radioButton.IsChecked == true)
                        {
                            switch (Name)
                            {
                                case "one":
                                    points += 0;
                                    break;

                                case "two":
                                    points += 1;
                                    break;

                                case "three":
                                    points += 2;
                                    break;

                                case "four":
                                    points += 3;
                                    break;

                                case "five":
                                    points += 4;
                                    break;

                                default:
                                    break;
                            }
                        }
                    
                    }
                }

                Points.Text = points.ToString() + " pkt";

                Buttons_Border.Visibility = Visibility.Collapsed;
                Summary_Border.Visibility = Visibility.Visible;
            }
            else
            {
                Button button = sender as Button;

                button.Content = button.Tag + " (Nie zostały podane odpowiedzi we wszystkich pytaniach)";
            }
        }
    }
}
