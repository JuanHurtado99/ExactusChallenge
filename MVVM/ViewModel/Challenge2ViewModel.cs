using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.Subroutines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge2ViewModel : ObservableObject
    {
        private AreTheyTheSameLetters _areTheyTheSameLetters;

        private int _similarityScore;
        private string _letter1;
        private string _letter2;
        private string _resultString;
        public string resultString 
        {
            get { return _resultString; } 
            set 
            { 
                _resultString = value;
                OnPropertyChanged();
            }
        }
        public string letter1
        {
            get { return _letter1; }
            set
            {
                _letter1 = value;
                OnPropertyChanged();
            }
        }
        public string letter2
        {
            get { return _letter2; }
            set
            {
                _letter2 = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand SubmitLettersCommand { get; set; }
        public Challenge2ViewModel()
        {
            _letter1 = string.Empty;
            _letter2 = string.Empty;
            _similarityScore = 0;
            _areTheyTheSameLetters = new AreTheyTheSameLetters();
            resultString = "Submit to show the result :)";
            setCommands();
        }

        private void setCommands()
        {
            SubmitLettersCommand = new RelayCommand(o =>
            {
                SubmitLetters();
            });
        }

        private void SubmitLetters()
        {
            if (_letter1 != string.Empty && _letter2 != string.Empty)
            {
                try
                {
                    _similarityScore = _areTheyTheSameLetters.calculateSimilarity(_letter1, _letter2);
                }catch (Exception ex)
                {
                    resultString = "Something went wrong please try again";
                }

                resultString = "The letters are " + _similarityScore.ToString() + "% similar";
            }
            else
            {
                resultString = "Please type the strings before submiting";
            }
        }
    }
}
