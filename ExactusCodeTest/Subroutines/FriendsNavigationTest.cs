using Xunit;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeTest.Subroutines
{
    public class FriendsNavigationTest
    {
        FriendsNavigation navigation = new();

        [Fact]
        public void TestData1()
        {
            int[] userLocation = [10,15];
            List<int[]> friendsLocations = new List<int[]>();
            friendsLocations.Add([10,20]);
            friendsLocations.Add([20,20]);
            friendsLocations.Add([10,10]);
            friendsLocations.Add([100,10]);

            var result = navigation.sortFriendsLocation(userLocation, friendsLocations);
            var expectedResult = new List<int[]>();
            
            expectedResult.Add([10, 20]);
            expectedResult.Add([10, 10]);
            expectedResult.Add([20, 20]);
            expectedResult.Add([100, 10]);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestData2()
        {
            int[] userLocation = [1000, 1050];
            
            List<int[]> friendsLocations = new List<int[]>();
            friendsLocations.Add([1, 1]);
            friendsLocations.Add([100, 220]);
            friendsLocations.Add([1000, 100]);
            friendsLocations.Add([-1000, 1050]);

            var result = navigation.sortFriendsLocation(userLocation, friendsLocations);
            var expectedResult = new List<int[]>();

            expectedResult.Add([1000, 100]);
            expectedResult.Add([100, 220]);
            expectedResult.Add([1, 1]);
            expectedResult.Add([-1000, 1050]);

            Assert.Equal(expectedResult, result);
        }
    }
}
