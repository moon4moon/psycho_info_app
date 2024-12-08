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

                foreach (XmlNode informations in InformationList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = informations.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Informations.Children.Add(textBlock);
                }

                XmlNodeList ReasonsList = xml.DocumentElement.SelectNodes(element + "/Reasons/Subpoint");

                foreach (XmlNode reasons in ReasonsList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = reasons.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Reasons.Children.Add(textBlock);
                }

                XmlNodeList SymptomsList = xml.DocumentElement.SelectNodes(element + "/Symptoms/Subpoint");

                foreach (XmlNode symptoms in SymptomsList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = symptoms.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Symptoms.Children.Add(textBlock);
                }

                XmlNodeList ResultsList = xml.DocumentElement.SelectNodes(element + "/Results/Subpoint");

                foreach (XmlNode results in ResultsList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = results.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Results.Children.Add(textBlock);
                }

                XmlNodeList CounteractionsList = xml.DocumentElement.SelectNodes(element + "/Counteractions/Subpoint");

                foreach (XmlNode counteractions in CounteractionsList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = counteractions.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Counteractions.Children.Add(textBlock);
                }

                XmlNodeList ExamplesList = xml.DocumentElement.SelectNodes(element + "/Examples/Subpoint");

                foreach (XmlNode examples in ExamplesList)
                {
                    TextBlock textBlock = new TextBlock();

                    textBlock.Text = examples.InnerText;
                    textBlock.Style = (Style)FindResource("Text_Info");

                    Examples.Children.Add(textBlock);
                }

                XmlNodeList BehaviorList = xml.DocumentElement.SelectNodes(element + "/Behavior/Subpoint");

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
                DiseaseName.Text = "Brak danych";
            }
        }
    }
}
