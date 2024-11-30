using System;
using System.Collections.Generic;
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
using Psycho_info_app.Model;

namespace Psycho_info_app
{
    public partial class TESTOWE : Window
    {

        public TESTOWE()
        {
            InitializeComponent();

            InfoSend infoSend = new InfoSend();

            Opis.Text = infoSend.Info;
        }
    }
}
