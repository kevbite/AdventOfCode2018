using System.Collections.Generic;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class PredictListItem
    {
        [Fact]
        public void ShouldWork1()
        {
            var ints = new List<int> {
                11,11,12,13,14,15,
                1, 2, 3, 4, 5,
                1, 2, 3, 4, 5};

            ints.Predict(17)
                .Should().Be(2);
        }

        [Fact]
        public void ShouldWork2()
        {
            var ints = new List<int> {
                11,11,12,13,14,15,
                1, 2, 3, 4, 5,
                1, 2, 3, 4, 5};

            ints.Predict(24)
                .Should().Be(4);
        }

        [Fact]
        public void ShouldWork3()
        {
            var ints = new List<int> {
                1,2,
                1,2,3,4,
                1,2,3,4};

            ints.Predict(20)
                .Should().Be(3);
        }

        [Fact]
        public void ShouldWork4()
        {
            var ints = new List<int> {
                1,2,3,4,
                1,2,3,4,
                1,2,3,4,
                1,2,3,4,
                1,2,3,4
            };

            ints.Predict(34)
                .Should().Be(3);
        }

        [Fact]
        public void ShouldWork5()
        {
            var ints = new List<int> {
                1,2,3,
                1,2,3
            };

            ints.Predict(8)
                .Should().Be(3);
        }

        [Fact]
        public void ShouldWork6()
        {
            var ints = new List<int> {
                1,2,3,
                1,2,3
            };

            ints.Predict(6)
                .Should().Be(1);
        }

        [Fact]
        public void ShouldWork7()
        {           
            var ints = new List<int> {
                1,2,3,
                1,2,3
            };

            ints.Predict(9)
                .Should().Be(1);
        }
    }
}