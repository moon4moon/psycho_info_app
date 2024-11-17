using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Psycho_info_app.Core;

namespace Psycho_info_app.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeVM Home { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Home = new HomeVM();
            CurrentView = Home;
        }
    }
}
