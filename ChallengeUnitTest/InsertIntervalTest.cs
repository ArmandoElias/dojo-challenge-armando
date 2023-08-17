using Challenges;

namespace ChallengeUnitTest
{
    public class InsertIntervalTest
    {
        [Fact]
        public void InsertNewIntervalShouldWork()
        {

            var inputData = new List<Interval>()
            {
                ///[1,2],[3,5],[6,7],[8,10],[12,16]
                /////[1,3],[6,9],[12,16] Given to merge [2,5]
                new Interval() { Start = 1, End =2},
                new Interval() { Start = 3, End = 5},
                new Interval() { Start = 6, End = 7},
                new Interval() { Start = 8, End = 10},
                new Interval() { Start = 12, End = 16},
                new Interval() { Start = 4, End = 9, isNew = true},

            };

            var newIntervals = InsertInterval.InsertNewInterval(inputData);

            Assert.NotEmpty(newIntervals);
        }
    }
}
