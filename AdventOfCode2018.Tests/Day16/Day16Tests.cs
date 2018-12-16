using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class Day16Tests
    {
        [Fact]
        public void ShouldReturnPossibleOpCodes()
        {
            var day16 = new AdventOfCode2018.Day16.Day16();

            var before = new []{ 3, 2, 1, 1 };
            var after = new []{ 3, 2, 2, 1 };

            var possibleOpCodes = day16.GetPossibleOpCodes(before, "9 2 1 2", after);

            possibleOpCodes.Should().BeEquivalentTo(new[]
            {
                "mulr", "addi", "seti"
            });
        }
    }
}