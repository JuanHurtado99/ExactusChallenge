﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ExactusCodeChallenge.Core;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeChallenge.MVVM.ViewModel
{
    class Challenge5ViewModel : ObservableObject
    {
        private FriendsNavigation _friendsNavigation;

        private List<int[]> _friendsSorted;
        private string _friendsString;
        private List<int[]> _friendsLocations;
        private int _xStartingPoint;
        private int _yStartingPoint;
        private int _xFriendPoint;
        private int _yFriendPoint;
        private int[] _startingPoint;
        public int xStartingPoint
        {
            get
            {
                return _xStartingPoint;
            }
            set
            {
                _xStartingPoint = value;
                _startingPoint[0] = _xStartingPoint;
                OnPropertyChanged();
            }
        }
        public int yStartingPoint
        {
            get
            {
                return _yStartingPoint;
            }
            set
            {
                _yStartingPoint = value;
                _startingPoint[1] = _yStartingPoint;
                OnPropertyChanged();
            }

        }
        public int xFriendPoint
        {
            get
            {
                return _xFriendPoint;
            }
            set
            {
                _xFriendPoint = value;
                OnPropertyChanged();
            }
        }
        public int yFriendPoint
        {
            get
            {
                return _yFriendPoint;
            }
            set
            {
                _yFriendPoint = value;
                OnPropertyChanged();
            }
        }
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
        public RelayCommand AddToListCommand { get; set; }
        public RelayCommand UdpateStartingPositionCommand { get; set; }
        public RelayCommand ClearOutputCommand { get; set; }

        public Challenge5ViewModel()
        {
            xFriendPoint = new int();
            _xStartingPoint = new int();
            _yStartingPoint = new int();

            _startingPoint = new int[2];

            _friendsLocations = new List<int[]>();

            _friendsNavigation = new FriendsNavigation();
            friendsString = "No friend has been added";

            setCommands();
        }

        private void setCommands()
        {
            AddToListCommand = new RelayCommand(o =>
            {
                AddToList();
            });

            UdpateStartingPositionCommand = new RelayCommand(o =>
            {
                UdpateStartingPosition();
            });

            ClearOutputCommand = new RelayCommand(o =>
            {
                ClearOutput();
            });
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

        private void AddToList()
        {

                _friendsLocations.Add([_xFriendPoint, yFriendPoint]);
                CallSortList();
        }

        private void UdpateStartingPosition()
        {
                _startingPoint = [_xStartingPoint, _yStartingPoint];

                if(_friendsString != "No friend has been added" && _friendsString != "Output cleared :)") 
                { 
                    CallSortList();
                }
        }

        private void ClearOutput()
        {
            friendsString = "Output cleared :)";
            _friendsLocations.Clear();


        }
        private void CallSortList()
        {
            try
            {
                _friendsSorted = _friendsNavigation.sortFriendsLocation(_startingPoint, _friendsLocations);
                friendsString = friendsResultToString();
            } catch (Exception ex)
            {
                friendsString = "Ups something whent wrong check your input";
            }
        }

    }
}
