using ExactusCodeChallenge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge1ViewModel : ObservableObject
    {

        private RandomGift _randomGift;
        private string _resultList;
        private string _resultUnique;
        private int _newGift;
        private string _waitingForList = "Waiting for gifts :)";
        private string _initText = "want to see you gift? click the input button";
        private string _clearedOutputText = "Cleared Output";
        public string ResultUnique
        {
            get { return _resultUnique; }
            set 
            { 
                _resultUnique = value;
                OnPropertyChanged();
            }
        }
        public string resultList
        {
            get { return _resultList; }
            set
            {
                _resultList = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand SubmitCommand { get; set; }
        public RelayCommand ClearCommand { get; set; }
        
        public Challenge1ViewModel() 
        {
            _randomGift = new RandomGift();
            _resultList = _initText;
            _resultUnique = _waitingForList;
            _newGift = new int();

            setCommands();
        }

        private void setCommands()
        {
            SubmitCommand = new RelayCommand(o => {
                Submit();
            });

            ClearCommand = new RelayCommand(o =>
            {
                Clear();
            });
        }

        private void Submit()
        {
            _newGift = _randomGift.generateGift();
            // pasar lista al string 
            formatListToString(_randomGift.getGifts());
            // guardar bool 
            ResultUnique = areTheyUniqueMessage();

        }
        private void Clear() 
        {
            _randomGift.clearGifts();
            resultList = _clearedOutputText;
            ResultUnique = _waitingForList;
        }

        private void formatListToString(List<int> giftList)
        {

            if(_resultList == _initText || _resultList == _clearedOutputText)
            {
                resultList = "[ " + giftList.Last().ToString() + " ] \n";

            }
            else
            {

                resultList = "[ " + giftList.Last().ToString() + " ] \n" + resultList;
            }
            
        }

        private string areTheyUniqueMessage()
        {
            if(_randomGift.areGiftsUnique() == true)
            {
                return "This is your new gift "+ _newGift + "\nWuwuwuw all yout gifts are unique :)";

            }
            else
            {
                return "This is your new gift " + _newGift + "\nbut you have a repetead gift :(";
            }
        }
    }
}
