using System.Collections.Immutable;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class ImmutableArrayExtentionsTests
    {
        [Fact]
        public void ShouldGetAdjacent()
        {
            var ints = new[]
            {
                new[] {1, 2, 3, 4, 5}.ToImmutableArray(),
                new[] {11, 22, 33, 44, 55}.ToImmutableArray(),
                new[] {111, 222, 333, 444, 555}.ToImmutableArray(),
                new[] {1111, 2222, 3333, 4444, 5555}.ToImmutableArray(),
                new[] {11111, 22222, 33333, 44444, 55555}.ToImmutableArray(),
            }.ToImmutableArray();

            var enumerable = ints.GetAdjacent(1, 1);

            enumerable.Should().BeEquivalentTo(1, 2, 3, 11, 33, 111, 222, 333);
        }
    }
}