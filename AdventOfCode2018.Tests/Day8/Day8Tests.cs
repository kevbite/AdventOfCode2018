using AdventOfCode2018.Day8;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day8
{
    public class Day8Tests
    {
        [Fact]
        public void ShouldReturnCorrectMetadataSumPart1()
        {
            var tree = new Tree(new Node(new[] {1, 2, 3}, new[] {new Node(new[] {1, 2, 3}, new Node[0])}));

            var result = new AdventOfCode2018.Day8.Day8().Part1(tree);

            result.Should().Be(12);
        }

        [Fact]
        public void ShouldReturnCorrectMetadataSumPart2()
        {
            var input = "2 3 0 3 10 11 12 1 1 0 1 99 2 1 1 2";

            var tree = Tree.Parse(input);
            
            var result = new AdventOfCode2018.Day8.Day8().Part2(tree);

            result.Should().Be(66);
        }
    }
}