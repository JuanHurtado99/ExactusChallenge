using Xunit;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeTest.Subroutines
{
    public class FiveSecondsOfWorkTest
    {
        FiveSecondsOfWork fiveSecondsOfWork = new FiveSecondsOfWork();

        [Fact]
        public void testData1()
        {
            var number = fiveSecondsOfWork.ConvertTimeToSeconds("1h33m");
            Assert.Equal(1116, number);

        }

        [Fact]
        public void testData2()
        {
            var number = fiveSecondsOfWork.ConvertTimeToSeconds("5h23m");
            Assert.Equal(3876, number);

        }

        [Fact]
        public void testingMinutesOnly()
        {
            var number = fiveSecondsOfWork.ConvertTimeToSeconds("45m");
            Assert.Equal(540, number);

        }

        [Fact]
        public void testingHoursOnly()
        {
            var number = fiveSecondsOfWork.ConvertTimeToSeconds("1h");
            Assert.Equal(720, number);

        }
    }
}
