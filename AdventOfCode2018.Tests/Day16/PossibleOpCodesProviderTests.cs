using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class PossibleOpCodesProviderTests
    {
        [Fact]
        public void ShouldReturnPossibleOpCodes()
        {
            var day16 = new AdventOfCode2018.Day16.PossibleOpCodesProvider();

            var before = new []{ 3, 2, 1, 1 };
            var after = new []{ 3, 2, 2, 1 };
            var sample = new Sample(before, "9 2 1 2", after);
            var possibleOpCodes = day16.GetPossibleOpCodes(sample);

            possibleOpCodes.Should().BeEquivalentTo(new[]
            {
                "mulr", "addi", "seti"
            });
        }
    }
}