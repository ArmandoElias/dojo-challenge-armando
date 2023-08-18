using Challenges;

namespace ChallengeUnitTest
{
    public class TwoSumTest
    {
        [Fact]
        public void AddShouldWork()
        {
            var numberToAdd = 2;
            var wasAdded = TwoSum.Add(numberToAdd);
            Assert.True(wasAdded);
        }

        [Fact]
        public void AddShouldNotWork()
        {
            var numberToAdd = 0;
            var wasAdded = TwoSum.Add(numberToAdd);
            Assert.False(wasAdded);
        }

        [Fact]
        public void FindShouldWork()
        {         
            TwoSum.data = new List<int> { 2, 7, 11, 15 };
            var numberToFind = 9;
            var findResult = TwoSum.Find(numberToFind);
            Assert.NotEmpty(findResult);
        }

        [Fact]
        public void FindShouldNotWork()
        {           
            var numberToFind = 9;
            var findResult = TwoSum.Find(numberToFind);
            Assert.True(findResult.Count == 0);
        }
    }
}
