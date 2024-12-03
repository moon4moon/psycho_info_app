using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Schema;
using Psycho_info_app.Model;

namespace Psycho_info_app
{
    public partial class TESTOWE : Window
    {

        public TESTOWE(string info)
        {
            InitializeComponent();

            string Info = info;

            Title = Info;


            XmlDocument xml = new XmlDocument();

            string path = Directory.GetCurrentDirectory() + "\\Materials\\test.xml";

            xml.Load(path);

            string element = "/Diseases/List[Number='" + Info + "']";

            var Disease = xml.DocumentElement.SelectSingleNode(element);

            
            if (Disease != null)
                {
                    Name.Text = Disease.SelectSingleNode("Name").InnerText;

                    XmlNodeList InformationList = xml.DocumentElement.SelectNodes(element + "/Information/Subpoint");

                    foreach (XmlNode informations in InformationList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = informations.InnerText;

                        Informations.Children.Add(textBlock);
                    }

                    XmlNodeList ReasonsList = xml.DocumentElement.SelectNodes(element +"/Reasons/Subpoint");

                    foreach (XmlNode reasons in ReasonsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = reasons.InnerText;

                        Reasons.Children.Add(textBlock);
                    }
                    
                    XmlNodeList SymptomsList = xml.DocumentElement.SelectNodes(element+"/Symptoms/Subpoint");

                    foreach (XmlNode symptoms in SymptomsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = symptoms.InnerText;

                        Symptoms.Children.Add(textBlock);
                    }

                    XmlNodeList ResultsList = xml.DocumentElement.SelectNodes(element + "/Results/Subpoint");

                    foreach (XmlNode results in ResultsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = results.InnerText;

                        Results.Children.Add(textBlock);
                    }
                    
                    XmlNodeList CounteractionsList = xml.DocumentElement.SelectNodes(element + "/Counteractions/Subpoint");

                    foreach (XmlNode counteractions in CounteractionsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = counteractions.InnerText;

                        Counteractions.Children.Add(textBlock);
                    }

                    XmlNodeList ExamplesList = xml.DocumentElement.SelectNodes(element + "/Examples/Subpoint");

                    foreach (XmlNode examples in ReasonsList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = examples.InnerText;

                        Examples.Children.Add(textBlock);
                    }
                    
                    XmlNodeList BehaviorList = xml.DocumentElement.SelectNodes(element + "/Behavior/Subpoint");

                    foreach (XmlNode behavior in BehaviorList)
                    {
                        TextBlock textBlock = new TextBlock();

                        textBlock.Text = behavior.InnerText;

                        Behavior.Children.Add(textBlock);
                    } 
                } else
                {
                Name.Text = element;
                }    
        }
    }
}
