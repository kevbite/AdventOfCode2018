using AdventOfCode2018.Day11;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day11
{
    public class FuelCellTests
    {
        private readonly FuelCell _fuelCell;
        
        public FuelCellTests()
        {
            _fuelCell = new FuelCell(8, 3, 5);
        }

        [Fact]
        public void ShouldReturnCorrectRackId()
        {
            _fuelCell.RackId.Should().Be(13);
        }

        [Fact]
        public void ShouldReturnCorrectPowerLevel()
        {
            var fuelCell = new FuelCell(8, 3, 5);

            fuelCell.GetPowerLevel().Should().Be(4);
        }
    }
}
