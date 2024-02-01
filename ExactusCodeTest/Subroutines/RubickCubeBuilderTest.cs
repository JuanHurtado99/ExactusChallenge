using Xunit;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeTest.Subroutines
{
    public class RubickCubeBuilderTest
    {
        RubickCubeBuilder rubickCubeBuilder = new RubickCubeBuilder();

        [Fact]
        public void generateCube3perRow()
        {
            var number = rubickCubeBuilder.StickerCalculator(3);
            Assert.Equal(54,number);

        }

        [Fact]
        public void generateCube5perRow()
        {
            var number = rubickCubeBuilder.StickerCalculator(5);
            Assert.Equal(150, number);

        }
    }
}
