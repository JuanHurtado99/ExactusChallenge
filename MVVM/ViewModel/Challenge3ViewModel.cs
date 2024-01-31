using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.Subroutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge3ViewModel : ObservableObject
    {
        private FiveSecondsOfWork _fiveSecondsOfWork;
        private string _time;
        private int _timeCalculated;
        private string _outputString;
        public string OutputString
        {
            get { return _outputString; }
            set 
            {
                _outputString = value;
                OnPropertyChanged();
            }
        }
        public string Time
        {
            get { return _time; }
            set 
            { 
                _time = value; 
                OnPropertyChanged();
            }
        }
        public RelayCommand SubmitCommand { get; set; }

        public Challenge3ViewModel() 
        {
            _fiveSecondsOfWork = new FiveSecondsOfWork();
            _time = string.Empty;
            _timeCalculated = new int();
            _outputString = "Submit input to calculate the time chuncks";
            setCommands();
        }

        private void setCommands()
        {
            SubmitCommand = new RelayCommand(o =>
            {
                submit();
            });
        }

        private void submit() 
        {
            try
            {
                _timeCalculated = _fiveSecondsOfWork.ConvertTimeToSeconds(_time);
                OutputString =  _timeCalculated + " chunks of 5 seconds";
            }catch (Exception ex)
            {
                OutputString = "Something went wrong  \n Please check your input";
            }
        }

    }
}
