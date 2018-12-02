using AdventOfCode2018.Day2;
using Xunit;

namespace AdventOfCode2018.Tests.Day2
{
    public class BoxIdFinderTests
    {
        [Fact]
        public void ShouldReturnCommonLetters()
        {
            var boxIdFinder = new BoxIdFinder();
            var mostCommonLetters = boxIdFinder.GetMostCommonLetters(@"abcde
fghij
klmno
pqrst
fguij
axcye
wvxyz");

            Assert.Equal("fgij", mostCommonLetters);
        }
    }
}
