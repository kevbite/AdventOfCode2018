using System.Linq;

namespace AdventOfCode2018.Day13
{
    public class Day13
    {
        public (int x, int y) GetFirstCrashLocation(string input)
        {
            var map = Map.Parse(input);

            while (!map.GetCrashedCarts().Any())
            {
                map = map.Tick();
            }

            var crashed = map.GetCrashedCarts();

            return crashed.Select(x => (x.X, x.Y)).First();
        }
    }
}
