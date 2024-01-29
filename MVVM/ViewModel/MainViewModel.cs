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
        public Challenge2ViewModel Challenge2VM { get; set; }
        public Challenge3ViewModel Challenge3VM { get; set; }
        public Challenge4ViewModel Challenge4VM { get; set; }
        public Challenge5ViewModel Challenge5VM { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand Challenge1ViewCommand { get; set; }
        public RelayCommand Challenge2ViewCommand { get; set; }
        public RelayCommand Challenge3ViewCommand { get; set; }
        public RelayCommand Challenge4ViewCommand { get; set; }
        public RelayCommand Challenge5ViewCommand { get; set; }


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
            Challenge2VM = new Challenge2ViewModel();
            Challenge3VM = new Challenge3ViewModel();
            Challenge4VM = new Challenge4ViewModel();
            Challenge5VM = new Challenge5ViewModel();

            CurrentView = HomeVM;

            setRelayCommands();
        }

        private void setRelayCommands()
        {
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            Challenge1ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge1VM;
            });

            Challenge2ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge2VM;
            });

            Challenge3ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge3VM;
            });

            Challenge4ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge4VM;
            });

            Challenge5ViewCommand = new RelayCommand(o =>
            {
                CurrentView = Challenge5VM;
            });
        }

    }
}
