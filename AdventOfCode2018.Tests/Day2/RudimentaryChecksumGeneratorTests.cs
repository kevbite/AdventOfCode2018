using AdventOfCode2018.Day2;
using Xunit;

namespace AdventOfCode2018.Tests.Day2
{
    public class RudimentaryChecksumGeneratorTests
    {
        [Fact]
        public void ShouldGenerateChecksum()
        {
            var rudimentaryChecksumGenerator = new RudimentaryChecksumGenerator();
            var checksum = rudimentaryChecksumGenerator.Generate(@"abcdef
bababc
abbcde
abcccd
aabcdd
abcdee
ababab
");

            Assert.Equal(12, checksum);
        }
    }
}