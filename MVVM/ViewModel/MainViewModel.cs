using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        private object _currentView;

        public HomeViewModel HomeVM { get; set; }

        public Challenge1ViewModel Challenge1VM { get; set; }
        
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand Challenge1ViewCommand { get; set; }

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
            HomeVM = new HomeViewModel();
            Challenge1VM = new Challenge1ViewModel();
            
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            Challenge1ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge1VM;
            });
        }

    }
}
