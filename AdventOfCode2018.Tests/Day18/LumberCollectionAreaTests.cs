using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class LumberCollectionAreaTests
    {
        [Fact]
        public void ShouldParseLumberCollectionArea()
        {
            LumberCollectionArea area = LumberCollectionArea.Parse(@".#.
|.|
#|#");

            area.Acres[0][0].Should().BeOfType<OpenGroundAcre>();
            area.Acres[0][1].Should().BeOfType<LumberyardAcre>();
            area.Acres[0][2].Should().BeOfType<OpenGroundAcre>();

            area.Acres[1][0].Should().BeOfType<TreesAcre>();
            area.Acres[1][1].Should().BeOfType<OpenGroundAcre>();
            area.Acres[1][2].Should().BeOfType<TreesAcre>();

            area.Acres[2][0].Should().BeOfType<LumberyardAcre>();
            area.Acres[2][1].Should().BeOfType<TreesAcre>();
            area.Acres[2][2].Should().BeOfType<LumberyardAcre>();

        }

        [Fact]
        public void OpenAcreBecomesTreesWhenThreeOrMoreAdjacentAcresContainedTrees()
        {
            LumberCollectionArea area = LumberCollectionArea.Parse(@"|||
...
...");

            var actual = area.Tick();

            actual.Acres[0][0].Should().BeOfType<TreesAcre>();
            actual.Acres[0][1].Should().BeOfType<TreesAcre>();
            actual.Acres[0][2].Should().BeOfType<TreesAcre>();

            actual.Acres[1][0].Should().BeOfType<OpenGroundAcre>();
            actual.Acres[1][1].Should().BeOfType<TreesAcre>();
            actual.Acres[1][2].Should().BeOfType<OpenGroundAcre>();

            actual.Acres[2][0].Should().BeOfType<OpenGroundAcre>();
            actual.Acres[2][1].Should().BeOfType<OpenGroundAcre>();
            actual.Acres[2][2].Should().BeOfType<OpenGroundAcre>();
        }

        [Fact]
        public void TreesWillBecomeLumberyardWhenThreeOrMoreAdjacentAcresWereLumberyards()
        {
            LumberCollectionArea area = LumberCollectionArea.Parse(@"###
|||
|||");

            var actual = area.Tick();

            actual.Acres[0][0].Should().BeOfType<LumberyardAcre>();
            actual.Acres[0][1].Should().BeOfType<LumberyardAcre>();
            actual.Acres[0][2].Should().BeOfType<LumberyardAcre>();

            actual.Acres[1][0].Should().BeOfType<TreesAcre>();
            actual.Acres[1][1].Should().BeOfType<LumberyardAcre>();
            actual.Acres[1][2].Should().BeOfType<TreesAcre>();

            actual.Acres[2][0].Should().BeOfType<TreesAcre>();
            actual.Acres[2][1].Should().BeOfType<TreesAcre>();
            actual.Acres[2][2].Should().BeOfType<TreesAcre>();
        }

        [Fact]
        public void
            LumberyardWillRemainALumberyardWhenAdjacentToAtLeastOneOtherLumberyardAndAtLeastOneAcreContainingTrees()
        {
            LumberCollectionArea area = LumberCollectionArea.Parse(@".|.
###
###");

            var actual = area.Tick();

            actual.Acres[1][0].Should().BeOfType<LumberyardAcre>();
            actual.Acres[1][1].Should().BeOfType<LumberyardAcre>();
            actual.Acres[1][2].Should().BeOfType<LumberyardAcre>();


            actual.Acres[2][0].Should().BeOfType<OpenGroundAcre>();
            actual.Acres[2][1].Should().BeOfType<OpenGroundAcre>();
            actual.Acres[2][2].Should().BeOfType<OpenGroundAcre>();

        }
    }
}