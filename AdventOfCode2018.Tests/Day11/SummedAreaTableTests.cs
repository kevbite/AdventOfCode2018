using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2018.Day11;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day11
{
    public class SummedAreaTableTests
    {
        [Fact]
        public void ShouldReturnCorrectSums()
        {
            var summedAreaTable = new SummedAreaTable(new []
            {
                new []{31,12,13,24,30,1},
                new []{2,26,17,23,8,35},
                new []{4,9,21,15,28,34},
                new []{33,10,22,16,27,3},
                new []{5,29,20,14,11,31},
                new []{36,25,18,19,7,6}
            });

            summedAreaTable.GetRectangleSum(2, 3, 4, 4)
                .Should().Be(111);
        }
    }
}
