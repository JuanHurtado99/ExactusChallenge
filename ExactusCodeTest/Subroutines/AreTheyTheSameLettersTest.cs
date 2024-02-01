using Xunit;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeTest.Subroutines
{
    public class AreTheyTheSameLettersTest
    {
        AreTheyTheSameLetters areTheyTheSameLetters = new();
        
        [Fact]
        public void CheckSameString()
        {
            var string1 = "test";
            var string2 = "test";
            Assert.Equal(100, areTheyTheSameLetters.calculateSimilarity(string1,string2));

        }
        [Fact]
        public void CheckSameLenghtDifferentString() 
        {
            var string1 = "hola";
            var string2 = "test";
            Assert.Equal(0, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }
        [Fact]
        public void CheckDiffLenghtStrings()
        {
            var string1 = "hola";
            var string2 = "holaa";
            Assert.Equal(80, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }
        [Fact]
        public void testData1()
        {
            
            var string1 = "The red dog runs fast.";
            var string2 = "The blue dog ran fast";
            Assert.Equal(68, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }

        [Fact]
        public void testData2()
        {

            var string1 = "The grass is always greener";
            var string2 = "the gass is always greener";
            Assert.Equal(93, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }

        [Fact]
        public void testData3()
        {

            var string1 = "There has to be a reason for this.";
            var string2 = "There has to be a reason for this.";
            Assert.Equal(100, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }

        [Fact]
        public void testData4()
        {

            var string1 = "cat";
            var string2 = "cap";
            Assert.Equal(67, areTheyTheSameLetters.calculateSimilarity(string1, string2));
        }
    }
}
