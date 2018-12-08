using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2018.Day8;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day8
{
    public class TreeTests
    {
        [Fact]
        public void ShouldParseTree()
        {
            var input = "2 3 0 3 10 11 12 1 1 0 1 99 2 1 1 2";

            var tree = Tree.Parse(input);

            var nodeA = new
            {
                Metadata = new[] { 1, 1, 2 },
                Nodes = new object []
                {
                    new
                    {
                        Metadata = new []{ 10, 11, 12 },
                        Nodes = new object []{},
                    },
                    new
                    {
                        Metadata = new []{ 2 },
                        Nodes = new []
                        {
                            new
                            {
                                Metadata = new []{ 99 },
                                Nodes = new object [0]
                            }
                        },
                    },
                }
            };

            tree.Should().BeEquivalentTo(new
            {
                Node = nodeA
            });

        }
    }
}
