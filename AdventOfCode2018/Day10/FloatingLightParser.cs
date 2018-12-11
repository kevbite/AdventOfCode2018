using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day10
{
    public class FloatingLightParser
    {
        public IReadOnlyCollection<FloatingLight> Parse(string input)
        {
            return Regex.Matches(input, @"position=< *(-?\d+), *(-?\d+)> velocity=< *(-?\d+),  *(-?\d+)>")
                .Select(x =>
                {
                    var position = new Position(int.Parse((string) x.Groups[1].Value), int.Parse((string) x.Groups[2].Value));
                    var velocity = new Velocity(int.Parse((string) x.Groups[3].Value), int.Parse((string) x.Groups[4].Value));

                    return new FloatingLight(position, velocity);
                })
                .ToImmutableArray();
        }
    }
}