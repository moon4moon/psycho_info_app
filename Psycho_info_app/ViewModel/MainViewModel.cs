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
        public RelayCommand HomeVC { get; set; }
        public RelayCommand DiseasesListVC { get; set; }
        public RelayCommand TherapyVC { get; set; }
        public RelayCommand SpecialistsVC { get; set; }
        public RelayCommand HealthLifeVC { get; set; }
        public RelayCommand TestsVC { get; set; }
        public RelayCommand AboutUsVC { get; set; }


        public HomeVM Home { get; set; }
        public DiseasesListVM DiseasesList { get; set; }
        public TherapyVM Therapy { get; set; }
        public SpecialistsVM Specialists { get; set; }
        public HealthLifeVM HealthLife { get; set; }
        public TestsVM Tests { get; set; }
        public AboutUsVM AboutUs { get; set; }


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
            DiseasesList = new DiseasesListVM();
            Therapy = new TherapyVM();
            Specialists = new SpecialistsVM();
            HealthLife = new HealthLifeVM();
            Tests = new TestsVM();
            AboutUs = new AboutUsVM();


            CurrentView = Home;


            HomeVC = new RelayCommand(o =>
            {
                CurrentView = Home;
            });

            DiseasesListVC = new RelayCommand(o =>
            {
                CurrentView = DiseasesList;
            });

            TherapyVC = new RelayCommand(o =>
            {
                CurrentView = Therapy;
            });

            SpecialistsVC = new RelayCommand(o =>
            {
                CurrentView = Specialists;
            });

            HealthLifeVC = new RelayCommand(o =>
            {
                CurrentView = HealthLife;
            });

            TestsVC = new RelayCommand(o =>
            {
                CurrentView = Tests;
            });

            AboutUsVC = new RelayCommand(o =>
            {
                CurrentView = AboutUs;
            });
        }
    }
}
