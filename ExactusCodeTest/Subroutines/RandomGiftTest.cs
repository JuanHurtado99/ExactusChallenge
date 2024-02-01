using Xunit;
using ExactusCodeChallenge.Subroutines;

namespace ExactusCodeTest.Subroutines
{
    public class RandomGiftTest
    {
        RandomGift randomGift = new RandomGift();
        [Fact]
        public void GenerateRandomNumber()
        {
            var number = randomGift.generateGift();
            Assert.IsType<int>(number);

        }

        [Fact]
        public void GenerateMultipleRandomNumbersAndCheckList()
        {
            List<int> numbers = new List<int>();
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());


            Assert.Equal<List<int>>(numbers, randomGift.getGifts());

        }

        [Fact]
        public void CheckareGiftsUnique()
        {
            List<int> numbers = new List<int>();
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());
            numbers.Add(randomGift.generateGift());

            var unique = numbers.Distinct().Count() == numbers.Count();
            Assert.Equal<bool>(unique, randomGift.areGiftsUnique());

        }

    }
}