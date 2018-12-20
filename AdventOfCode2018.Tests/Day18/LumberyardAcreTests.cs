using System.Linq;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class LumberyardAcreTests{

        [Theory]
        [InlineData(1,1)]
        [InlineData(1,2)]
        [InlineData(2,1)]
        [InlineData(2,2)]
        public void ShouldStayAsLumberyardWhenAdjacentToLumberyardsAndTrees(int adjacentLumberyards, int adjacentTrees)
        {
            var adjacentAcres = Enumerable.Repeat<Acre>(new LumberyardAcre(), adjacentLumberyards)
                .Concat(Enumerable.Repeat(new TreesAcre(), adjacentTrees))
                .ToArray();

            var lumberyardAcre = new LumberyardAcre();

            var transform = lumberyardAcre.Transform(adjacentAcres);

            transform.Should().BeOfType<LumberyardAcre>();
        }

        [Fact]
        public void ShouldTransformToOpenWhenNotAdjacentToLumberyardsAndTrees()
        {
            var lumberyardAcre = new LumberyardAcre();

            var transform = lumberyardAcre.Transform(new Acre[0]);

            transform.Should().BeOfType<OpenGroundAcre>();
        }
    }
}