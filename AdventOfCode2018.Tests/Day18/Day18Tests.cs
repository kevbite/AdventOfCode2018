using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class Day18Tests
    {
        [Fact]
        public void ShouldReturnCorrectResourceValueAfter10Minutes()
        {
            var input = @".#.#...|#.
.....#|##|
.|..|...#.
..|#.....#
#.#|||#|#|
...#.||...
.|....|...
||...#|.#|
|.||||..|.
...#.|..|.";

            var day18 = new AdventOfCode2018.Day18.Day18();

            var resourceValue = day18.GetResourceValueAfter(10, input);

            resourceValue.Should().Be(1147);
        }
    }
}