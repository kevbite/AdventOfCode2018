using System;
using System.Xml.Serialization;

namespace AdventOfCode2018.Day11
{
    public class FuelCell
    {
        public int GridSerialNumber { get; }

        public int X { get; }

        public int Y { get; }

        public int RackId => X + 10;

        public FuelCell(int gridSerialNumber, int x, int y)
        {
            GridSerialNumber = gridSerialNumber;
            X = x;
            Y = y;
        }

        public int GetPowerLevel()
        {
            var powerLevel = RackId * Y;
            powerLevel = powerLevel + GridSerialNumber;
            powerLevel = powerLevel * RackId;

            powerLevel = GetHundredsDigit(powerLevel);

            return powerLevel - 5;
        }

        private static int GetHundredsDigit(int powerLevel)
        {
            return powerLevel / 100 % 10;
        }
    }
}
