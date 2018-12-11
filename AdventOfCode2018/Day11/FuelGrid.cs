using System.Linq;

namespace AdventOfCode2018.Day11
{
    public class FuelGrid
    {
        private readonly SummedAreaTable _summedAreaTable;

        public FuelGrid(int gridSerialNumber)
        {
            var grid = Enumerable.Range(1, 300)
                .Select(
                    x => Enumerable.Range(1, 300).Select(y => new FuelCell(gridSerialNumber, x, y).GetPowerLevel())
                        .ToArray()).ToArray();

            _summedAreaTable = new SummedAreaTable(grid);
        }

        public (int x, int y, int regionSize) FindBiggestFuelCellsPosition(int minRegionSize, int maxRegionSize)
        {
            var maxPowerLevel = Enumerable.Range(minRegionSize, maxRegionSize - minRegionSize + 1)
                .Select(x => FindBiggestFuelCellsPosition(x))
                .OrderByDescending(x => x.powerLevel)
                .First();

            return (maxPowerLevel.x, maxPowerLevel.y, maxPowerLevel.regionSize);
        }

        private (int x, int y, int regionSize, int powerLevel) FindBiggestFuelCellsPosition(int regionSize)
        {
            var bigCell = new {PowerLevel = 0, RegionSize = 0, X = 0, Y = 0};

            var regionSizeOffset = regionSize - 1;

            for (var x = 0; x < 300 - regionSizeOffset; x++)
            {
                for (var y = 0; y < 300 - regionSizeOffset; y++)
                {
                    var regionPowerLevel =
                        _summedAreaTable.GetRectangleSum(x, y, x + regionSizeOffset, y + regionSizeOffset);

                    if (regionPowerLevel > bigCell.PowerLevel)
                    {
                        bigCell = new
                        {
                            PowerLevel = regionPowerLevel,
                            RegionSize = regionSize,
                            X = x + 1,
                            Y = y + 1
                        };
                    }
                }
            }

            return (bigCell.X, bigCell.Y, bigCell.RegionSize, bigCell.PowerLevel);
        }
    }
}