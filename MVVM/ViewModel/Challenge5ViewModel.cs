using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge5ViewModel : ObservableObject
    {
        private FriendsNavigation _friendsNavigation;

        private List<int[]> _friendsSorted;
        private string _friendsString;
        public string friendsString
        {
            get 
            {
                return _friendsString;
            }
            set
            {
                _friendsString = value;
                OnPropertyChanged();
            }
        }
        public Challenge5ViewModel()
        {
            int[] startingPoint = [10,15];
            int[][] friendsLocations = [[10,20],[20,20],[10,10],[100,10]];
            _friendsNavigation = new FriendsNavigation();
            _friendsSorted = _friendsNavigation.sortFriendsLocation(startingPoint, friendsLocations);
            _friendsString = friendsResultToString();
            
        }

        private string friendsResultToString()
        {
            var result = "";
            foreach (var friend in _friendsSorted) 
            {
                var friendString = "[ " + friend[0].ToString() + " , "+friend[1].ToString() + " ]\n";
                result += friendString;
            }
            return result;
        }
    }
}
