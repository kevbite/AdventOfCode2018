using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2018.Day12;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day12
{
    public class HeatedCaveTests
    {
        private static readonly IReadOnlyDictionary<string, string> _rules = new Dictionary<string, string>()
        {
            {"...##", "#"},
            {"..#..", "#"},
            {".#...", "#"},
            {".#.#.", "#"},
            {".#.##", "#"},
            {".##..", "#"},
            {".####", "#"},
            {"#.#.#", "#"},
            {"#.###", "#"},
            {"##.#.", "#"},
            {"##.##", "#"},
            {"###..", "#"},
            {"###.#", "#"},
            {"####.", "#"},
        };

        private static readonly string _initialPlantsState = "#..#.#..##......###...###";

        [Fact]
        public void ShouldParseHeatedCave()
        {
            var input = @"initial state: #..#.#..##......###...###

...## => #
..#.. => #
.#... => #
.#.#. => #
.#.## => #
.##.. => #
.#### => #
#.#.# => #
#.### => #
##.#. => #
##.## => #
###.. => #
###.# => #
####. => #";

            var heatedCave = HeatedCave.Parse(input);

            heatedCave.ToString().Should().Be(_initialPlantsState);
            heatedCave.Rules.Should().BeEquivalentTo(_rules);

        }

        [Fact]
        public void ShouldReturnCorrectMutateState()
        {
            
            var heatedCave = new HeatedCave(_initialPlantsState, _rules);

            heatedCave.Mutate()
                .ToString().Should().Be("#...#....#.....#..#..#..#");
        }

        [Fact]
        public void ShouldReturnCorrectMutateStateAfter20Generations()
        {
            var heatedCave = new HeatedCave(_initialPlantsState, _rules);

            for (int i = 0; i < 20; i++)
            {
                heatedCave = heatedCave.Mutate();
            }

            heatedCave.ToString().Should().Be("#....##....#####...#######....#.#..##");

            heatedCave.SumPotIndexes()
                .Should().Be(325);
        }
    }
}
