using Challenges;

namespace ChallengeUnitTest
{
    public class LongestValidParenthesesTest
    {
        [Fact]
        public void GetCorrectlength()
        {
            var arrange = ")()())";

            var act = LongestValidParentheses.FindLength(arrange);

            Assert.NotEqual(0, act);
        }

        [Fact]
        public void GetIncorrectLenght()
        {
            var arrange = "))))";

            var act = LongestValidParentheses.FindLength(arrange);

            Assert.Equal(0, act);

        }
    }
}