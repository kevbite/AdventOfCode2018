using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public static class RecurringListItemChecker
    {
        public static bool IsPartiallyRecurring(this List<int> list, int min = 3)
        {
            for (var i = min; i <= list.Count / 2; i++)
            {
                var toCompare = list.TakeLast(i);

                var source = list.SkipLast(i).TakeLast(i);

                if (source.SequenceEqual(toCompare))
                {
                    return true;
                }
            }

            return false;
        }

        public static IEnumerable<int> GetRecurringSequence(this List<int> list)
        {
            for (var i = 1; i <= list.Count / 2; i++)
            {
                var toCompare = list.TakeLast(i);

                var source = list.SkipLast(i).TakeLast(i);

                if (source.SequenceEqual(toCompare))
                {
                    return toCompare;
                }
            }

            return new int[] { };
        }
    }
}