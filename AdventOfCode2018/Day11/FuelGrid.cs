using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day11
{
    public class FuelGrid
    {
        private readonly Dictionary<int, Dictionary<int, int>> _grid;

        public FuelGrid(int gridSerialNumber)
        {
            _grid = Enumerable.Range(1, 300)
                .ToDictionary(x => x,
                    x => Enumerable.Range(1, 300).ToDictionary(y => y, y => new FuelCell(gridSerialNumber, x, y).GetPowerLevel()));
        }

        public (int x, int y, int regionSize) FindBiggestFuelCellsPosition(int minRegionSize, int maxRegionSize)
        {
            var maxPowerLevel = ParallelEnumerable.Range(minRegionSize, maxRegionSize - minRegionSize + 1)
                .Select(x => FindBiggestFuelCellsPosition(x))
                .OrderByDescending(x => x.powerLevel)
                .First();

            return (maxPowerLevel.x, maxPowerLevel.y, maxPowerLevel.regionSize);
        }

        private (int x, int y, int regionSize, int powerLevel) FindBiggestFuelCellsPosition(int regionSize)
        {
            var bigCell = new {PowerLevel = 0, RegionSize = 0, X = 0, Y = 0};

            for (var x = 1; x <= 300 - regionSize - 1; x++)
            {
                for (var y = 1; y <= 300 - regionSize - 1; y++)
                {
                    var regionPowerLevel = GetRegionPowerLevel(x, y, regionSize);

                    if (regionPowerLevel > bigCell.PowerLevel)
                    {
                        bigCell = new
                        {
                            PowerLevel = regionPowerLevel,
                            RegionSize = regionSize,
                            X = x,
                            Y = y
                        };
                    }
                }
            }

            return (bigCell.X, bigCell.Y, bigCell.RegionSize, bigCell.PowerLevel);
        }

        public int GetRegionPowerLevel(int xStart, int yStart, int regionSize)
        {
            var sum = 0;

            for (var x = 0; x < regionSize; x++)
            {
                for (var y = 0; y < regionSize; y++)
                {
                    var actualX = x + xStart;
                    var actualY = y + yStart;

                    sum += _grid[actualX][actualY];
                }
            }

            return sum;
        }
    }
}