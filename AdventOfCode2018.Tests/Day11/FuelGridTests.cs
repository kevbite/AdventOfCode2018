using AdventOfCode2018.Day11;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day11
{
    public class FuelGridTests
    {
        [Fact]
        public void ShouldReturnCorrectPositionForGridSerialNumber18()
        {
            var position = new FuelGrid(18).FindBiggestFuelCellsPosition(3,3);

            position.Should().Be((33, 45, 3));
        }

        [Fact]
        public void ShouldReturnCorrectPositionForGridSerialNumber42()
        {
            var position = new FuelGrid(42).FindBiggestFuelCellsPosition(3,3);

            position.Should().Be((21, 61, 3));
        }


        [Fact]
        public void ShouldReturnCorrectPositionForGridSerialNumber42WithAllRegions()
        {
            var position = new FuelGrid(42).FindBiggestFuelCellsPosition(1, 300);

            position.Should().Be((232, 251, 12));
        }
    }
}
