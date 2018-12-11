using AdventOfCode2018.Day10;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day10
{
    public class FloatingLightParserTests
    {
        [Fact]
        public void ShouldParseString()
        {
            var input = @"position=< 9,  1> velocity=< 0,  2>
position=< 7,  0> velocity=<-1,  0>
position=< 6, 10> velocity=<-2, -1>
position=< 2, -4> velocity=< 2,  2>";

            var parsed = new FloatingLightParser().Parse(input);

            parsed.Should().BeEquivalentTo(new[]
            {
                new FloatingLight(new Position(9, 1), new Velocity(0, 2)),
                new FloatingLight(new Position(7, 0), new Velocity(-1, 0)),
                new FloatingLight(new Position(6, 10), new Velocity(-2, -1)),
                new FloatingLight(new Position(2, -4), new Velocity(2, 2)),
            });
        }
    }
}