using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExactusCodeChallenge.Subroutines
{
    public class FriendsNavigation
    {
        public FriendsNavigation() { }

        public List<int[]> sortFriendsLocation(int[] startingPoint, List<int[]> friendsLocations)
        {
            List<int[]> result = new List<int[]>();

            int startingX = startingPoint[0];
            int startingY = startingPoint[1];

            List<FriendsDistance> Distances = new List<FriendsDistance>();


            for (int i = 0; i < friendsLocations.Count; i++)
            {
                var distance = Math.Sqrt(Math.Pow(startingX - friendsLocations[i][0], 2) + Math.Pow(startingY - friendsLocations[i][1], 2));
                Distances.Add(new FriendsDistance(i, distance));
            }

            Distances.Sort((x, y) => x.distance.CompareTo(y.distance));

            foreach (FriendsDistance friend in Distances)
            {
                result.Add(friendsLocations[friend.index]);
            }

            return result;
        }
        private class FriendsDistance
        {
            public int index;
            public double distance;
            public FriendsDistance(int index, double distance)
            {
                this.index = index;
                this.distance = distance;
            }
        }
    }

   
}
