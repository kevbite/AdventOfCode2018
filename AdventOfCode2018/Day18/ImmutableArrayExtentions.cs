using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace AdventOfCode2018.Day18
{
    public static class ImmutableArrayExtentions
    {
        public static IEnumerable<T> GetAdjacent<T>(this ImmutableArray<ImmutableArray<T>> array, int xCentre, int yCentre)
        {
            var minY = Math.Max(yCentre - 1, 0);
            var maxY = Math.Min(yCentre + 1, array.Length - 1);
            for (var y = minY; y <= maxY; y++)
            {
                var minX = Math.Max(xCentre - 1, 0);
                var maxX = Math.Min(xCentre + 1, array[y].Length - 1);
                for (var x = minX; x <= maxX; x++)
                {
                    if (y != yCentre || x != xCentre)
                    {
                        yield return array[y][x];
                    }
                }
            }
        }
    }
}