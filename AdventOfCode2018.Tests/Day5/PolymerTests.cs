using AdventOfCode2018.Day5;
using Xunit;

namespace AdventOfCode2018.Tests.Day5
{
    public class PolymerTests
    {
        [Fact]
        public void ShouldEvaluateCorrectResult()
        {
            var polymer = new Polymer();

            var input = "dabAcCaCBAcCcaDA";

            var result = polymer.React(input);

            Assert.Equal(10, result);
        }

        [Fact]
        public void ShouldReturnShortestPolymer()
        {
            var polymer = new Polymer();

            var input = "dabAcCaCBAcCcaDA";

            var findShortest = polymer.FindShortest(input);

            Assert.Equal(4, findShortest);
        }
    }
}
