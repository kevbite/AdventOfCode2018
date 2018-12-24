using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public static class PredictListItemTests
    {

        public static int Predict(this List<int> list, int index)
        {
            var recurring = list.GetRecurringSequence()
                .ToArray();
            var itemsLeft = index + 1 - list.Count;
            var remainder = (itemsLeft % recurring.Length) - 1;

            if (remainder == -1)
            {
                return recurring.Last();
            }

            return recurring[remainder];
        }
    }
}