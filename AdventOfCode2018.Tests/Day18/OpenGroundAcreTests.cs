using System.Linq;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class OpenGroundAcreTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        public void ShouldTransformToTree(int adjacentTrees)
        {
            var treesAcres = Enumerable.Repeat(new TreesAcre(), adjacentTrees)
                .ToArray();
            var openGroundAcre = new OpenGroundAcre();
            var transform = openGroundAcre.Transform(treesAcres);

            transform.Should().BeOfType<TreesAcre>();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(1)]
        public void ShouldNotTransform(int adjacentTrees)
        {

            var treesAcres = Enumerable.Repeat(new TreesAcre(), adjacentTrees)
                .ToArray();
            var openGroundAcre = new OpenGroundAcre();
            var transform = openGroundAcre.Transform(treesAcres);

            transform.Should().BeOfType<OpenGroundAcre>();
        }
    }
}