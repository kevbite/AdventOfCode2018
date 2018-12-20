using System.Linq;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class TreesAcreTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        public void ShouldTransformToLumberyardAcre(int adjacentLumberyards)
        {
            var lumberyardAcres = Enumerable.Repeat(new LumberyardAcre(), adjacentLumberyards)
                .ToArray();
            var treesAcre = new TreesAcre();
            var transform = treesAcre.Transform(lumberyardAcres);

            transform.Should().BeOfType<LumberyardAcre>();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        public void ShouldNotTransform(int adjacentLumberyards)
        {

            var lumberyardAcres = Enumerable.Repeat(new LumberyardAcre(), adjacentLumberyards)
                .ToArray();
            var treesAcre = new TreesAcre();
            var transform = treesAcre.Transform(lumberyardAcres);

            transform.Should().BeOfType<TreesAcre>();
        }
    }
}