using AdventOfCode2018.Day10;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day10
{
    public class SkyTests
    {
        [Fact]
        public void ShouldReturnTheSkyInStringForm()
        {
            var sky = new Sky(new[]
            {
                new FloatingLight(new Position(-3, -3), new Velocity(0, 0)),
                new FloatingLight(new Position(3, -3), new Velocity(0, 0)),
                new FloatingLight(new Position(3, 3), new Velocity(0, 0)),
                new FloatingLight(new Position(-3, 3), new Velocity(0, 0)),
                new FloatingLight(new Position(0, 0), new Velocity(0, 0)),
                new FloatingLight(new Position(1, -3), new Velocity(0, 0)),
            });

            sky.ToString().Should().Be(
                @"#...#.#
.......
.......
...#...
.......
.......
#.....#");
        }
    }
}