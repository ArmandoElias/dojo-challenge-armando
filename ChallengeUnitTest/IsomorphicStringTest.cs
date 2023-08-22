using Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeUnitTest
{
    public class IsomorphicStringTest
    {

        [Fact]
        public void AreIsomorphicShoulWork()
        {
            var s1 = "egg";
            var s2 = "add";

            var areIsomorphic = IsomorphicStrings.AreIsomorphic(s1, s2);
            Assert.True(areIsomorphic);
        }

        [Fact]
        public void AreIsomorphicShoulNotWork()
        {
            var s1 = "";
            var s2 = "";
            var areIsomorphic = IsomorphicStrings.AreIsomorphic(s1, s2);
            Assert.False(areIsomorphic);
        }
    }
}
