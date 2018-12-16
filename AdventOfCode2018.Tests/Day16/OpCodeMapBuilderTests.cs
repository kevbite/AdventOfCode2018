using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2018.Day16;
using FluentAssertions;
using Moq;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class OpCodeMapBuilderTests
    {
        [Fact]
        public void ShouldProvideMap()
        {
            var samples = new List<Sample>()
            {
                new Sample(new []{1}, "0 0 0 0", new []{2}),
                new Sample(new []{3}, "1 0 0 0", new []{4}),
                new Sample(new []{5}, "2 0 0 0", new []{6}),
            };
            var possibleOpCodesProvider = new Mock<PossibleOpCodesProvider>();
            possibleOpCodesProvider.Setup(x => x.GetPossibleOpCodes(samples[0]))
                .Returns(new[] {"a"});
            possibleOpCodesProvider.Setup(x => x.GetPossibleOpCodes(samples[1]))
                .Returns(new[] { "a", "b" });
            possibleOpCodesProvider.Setup(x => x.GetPossibleOpCodes(samples[2]))
                .Returns(new[] { "a", "c", "b" });

            var builder = new OpCodeMapBuilder(possibleOpCodesProvider.Object);

            var map = builder.BuildMap(samples);

            map.Should().BeEquivalentTo(new Dictionary<int, string>()
            {
                {0, "a"},
                {1, "b"},
                {2, "c"},
            });
        }
    }
}
