using System.Collections.Generic;
using AdventOfCode2018.Day12;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day12
{
    public class Day12Tests
    {
        [Fact]
        public void ShouldReturnCorrectSumForRepeatableMutations()
        {
            var rules = new Dictionary<string, string>()
            {
                {".#...", "#"}
            };

            var plants = ".#....#...";

            var heatedCave = new HeatedCave(plants, rules);

            var expectedSum = heatedCave.Mutate()
                .Mutate()
                .Mutate()
                .SumPotIndexes();

            var day12 = new AdventOfCode2018.Day12.Day12(heatedCave);

            day12.GetPotSumFor(3)
                .Should().Be(expectedSum);
        }
    }
}
