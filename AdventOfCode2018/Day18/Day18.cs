using System.Collections.Generic;
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
            
            return GetResourceValue(lumberCollectionArea);

        }

        public int GetResourceValueAfterWithPrediction(int minutes, string input)
        {
            var lumberCollectionArea = LumberCollectionArea.Parse(input);

            var pastSums = new List<int>();

            for (var i = 0; i < minutes; i++)
            {
                lumberCollectionArea = lumberCollectionArea.Tick();
                var sum = GetResourceValue(lumberCollectionArea);

                pastSums.Add(sum);

                if (pastSums.IsPartiallyRecurring())
                {
                    return pastSums.Predict(minutes - 1);
                }
            }

            return GetResourceValue(lumberCollectionArea);
        }

        private static int GetResourceValue(LumberCollectionArea lumberCollectionArea)
        {
            var allAcres = lumberCollectionArea.Acres.SelectMany(x => x).ToArray();
            var sum = allAcres.OfType<TreesAcre>().Count() * allAcres.OfType<LumberyardAcre>().Count();
            return sum;
        }
    }
}