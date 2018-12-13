using System.Linq;

namespace AdventOfCode2018.Day13
{
    public class Day13
    {
        public (int x, int y) GetFirstCrashLocation(string input)
        {
            var map = Map.Parse(input);
            var i = 0;
            while (map.CrashedCart == null)
            {
                map = map.Tick();
                i++;
            }

            var crashed = map.CrashedCart;

            return (crashed.X, crashed.Y);
        }
    }
}
