using Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeUnitTest
{
    public class WordLadderTest
    {
        [Fact]
        public void GetShortertLengthShouldWork()
        {
            var diccionary = new List<string>() { "hot", "dot", "dog", "lot", "log" };
            var start = "hit";
            var end = "cog";
            var words = WordLadder.GetShortertLength(start, end, diccionary);

            Assert.NotEmpty(words);
        }
        [Fact]
        public void GetShortertLengthShouldNotWork()
        {
            var diccionary = new List<string>();
            var start = "hit";
            var end = "cog";
            var words = WordLadder.GetShortertLength(start, end, diccionary);

            Assert.Empty(words);
        }
    }
}
