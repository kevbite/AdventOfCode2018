using AdventOfCode2018.Day10;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day10
{
    public class FloatingLightTests
    {
        [Fact]
        public void ShouldChangePosition()
        {
            var floatingLight = new FloatingLight(new Position(3, 9), new Velocity(1, -2));

            floatingLight = floatingLight.Move();
            floatingLight = floatingLight.Move();
            floatingLight = floatingLight.Move();

            floatingLight.Position.Should().BeEquivalentTo(new
            {
                X = 6, Y = 3
            });
        }
    }
}