using System.IO;
using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class PuzzleTests{
        [Fact]
        public void ShouldReturnPuzzle()
        {
            var input = @"Before: [3, 2, 1, 1]
9 2 1 2
After:  [3, 2, 2, 1]
";

            var puzzle = Sample.ReadNext(new StringReader(input));

            puzzle.Should().BeEquivalentTo(
                new
                {
                    Before = new[] {3, 2, 1, 1},
                    Instructions = "9 2 1 2",
                    After = new[] {3, 2, 2, 1}
                });
        }

        [Fact]
        public void ShouldReturnMultiplePuzzles()
        {
            var input = @"Before: [0, 3, 0, 2]
13 0 0 3
After:  [0, 3, 0, 0]

Before: [0, 2, 2, 3]
4 1 3 0
After:  [0, 2, 2, 3]
";

            var textReader = new StringReader(input);

            var puzzle1 = Sample.ReadNext(textReader);
            var puzzle2 = Sample.ReadNext(textReader);

            puzzle1.Should().BeEquivalentTo(
                new
                {
                    Before = new[] { 0, 3, 0, 2 },
                    Instructions = "13 0 0 3",
                    After = new[] { 0, 3, 0, 0 }
                });

            puzzle2.Should().BeEquivalentTo(
                new
                {
                    Before = new[] { 0, 2, 2, 3 },
                    Instructions = "4 1 3 0",
                    After = new[] { 0, 2, 2, 3 }
                });
        }

        [Fact]
        public void ShouldReturnNullOnNoPuzzle()
        {
            Sample.ReadNext(new StringReader(""))
                .Should().BeNull();
        }
    }
}