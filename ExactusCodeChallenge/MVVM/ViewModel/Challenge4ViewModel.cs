using ExactusCodeChallenge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge4ViewModel : ObservableObject
    {
        private int _side;
        private string _stickersString;
        public string stickersString
        {
            get { return _stickersString; }
            set
            { 
                _stickersString = value;
                OnPropertyChanged();
            }
        }
        public int Side 
        {
            get { return _side; } 
            set 
            { 
                _side = value;
                OnPropertyChanged();
            }
        }
        private RubickCubeBuilder rubickCubeBuilder;
        public RelayCommand SubmitCommand {get; set;}
        public Challenge4ViewModel() 
        {
            _side = 0;
            _stickersString = "Waiting for Input";
            rubickCubeBuilder = new RubickCubeBuilder();

            setCommands();
        }

        private void setCommands()
        {
            SubmitCommand = new RelayCommand(o =>
            {
                Submit();
            });
        }
        private void Submit()
        {

            if (!float.IsNaN(_side) && _side != 0)
            {
                try
                {
                    var result = rubickCubeBuilder.StickerCalculator(_side);
                    stickersString = "You will need " + result.ToString() + " stickers";
                }
                catch (Exception)
                {

                    stickersString = "Something went wrong";
                }
            }
            else
            {
                stickersString = "Input cannot be null or 0";
            } 
        }
    }
}
