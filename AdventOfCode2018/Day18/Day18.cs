using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class Day18
    {
        public int GetResourceValueAfter(int minutes, string input)
        {
            var lumberCollectionArea = LumberCollectionArea.Parse(input);

            for (var i = 0; i < minutes; i++)
            {
                lumberCollectionArea = lumberCollectionArea.Tick();
            }

            var allAcres = lumberCollectionArea.Acres.SelectMany(x => x);

            var resourceValue = allAcres.OfType<TreesAcre>().Count() * allAcres.OfType<LumberyardAcre>().Count();

            return resourceValue;
        }
    }
}