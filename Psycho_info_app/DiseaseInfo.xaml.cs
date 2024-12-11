using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class DiseaseInfo : Window
    {
        public DiseaseInfo(string info)
        {
            InitializeComponent();

            string Info = info;

            XmlDocument xml = new XmlDocument();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\test.xml";

            xml.Load(path);

            string element = "/Diseases/List[Number='" + Info + "']";

            var Disease = xml.DocumentElement.SelectSingleNode(element);


            if (Disease != null)
            {
                Title = Disease.SelectSingleNode("Name").InnerText;
                DiseaseName.Text = Disease.SelectSingleNode("Name").InnerText;

                XmlNodeList InformationList = xml.DocumentElement.SelectNodes(element + "/Information/Subpoint");

                if (InformationList.Count > 0)
                {
                    foreach (XmlNode informations in InformationList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = informations.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Informations.Children.Add(textBlock);
                    }
                }
                else
                {
                    Informations_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList ReasonsList = xml.DocumentElement.SelectNodes(element + "/Reasons/Subpoint");

                if (ReasonsList.Count > 0)
                {
                    foreach (XmlNode reasons in ReasonsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = reasons.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Reasons.Children.Add(textBlock);
                    }
                }
                else
                {
                    Reasons_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList SymptomsList = xml.DocumentElement.SelectNodes(element + "/Symptoms/Subpoint");

                if (SymptomsList.Count > 0)
                {
                    foreach (XmlNode symptoms in SymptomsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = symptoms.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Symptoms.Children.Add(textBlock);
                    }
                }
                else
                {
                    Symptoms_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList ResultsList = xml.DocumentElement.SelectNodes(element + "/Results/Subpoint");

                if (ResultsList.Count > 0)
                {
                    foreach (XmlNode results in ResultsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = results.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Results.Children.Add(textBlock);
                    }
                }
                else
                {
                    Results_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList CounteractionsList = xml.DocumentElement.SelectNodes(element + "/Counteractions/Subpoint");

                if (CounteractionsList.Count > 0)
                {
                    foreach (XmlNode counteractions in CounteractionsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = counteractions.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Counteractions.Children.Add(textBlock);
                    }
                }
                else
                {
                    Counteractions_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList ExamplesList = xml.DocumentElement.SelectNodes(element + "/Examples/Subpoint");

                if (ExamplesList.Count > 0)
                {
                    foreach (XmlNode examples in ExamplesList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = examples.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Examples.Children.Add(textBlock);
                    }
                }
                else
                {
                    Examples_Border.Visibility = Visibility.Collapsed;
                }

                XmlNodeList BehaviorList = xml.DocumentElement.SelectNodes(element + "/Behavior/Subpoint");

                if (BehaviorList.Count > 0)
                {
                    foreach (XmlNode behavior in BehaviorList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = behavior.InnerText;
                        textBlock.Style = (Style)FindResource("Text_Info");

                        Behavior.Children.Add(textBlock);
                    }
                }
                else
                {
                    Behavior_Border.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                DiseaseName.Text = "Brak danych";
            }
        }
    }
}
