using System.Collections.Generic;
using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class RecurringListItemCheckerTests
    {
        [Fact]
        public void ShouldReturnTrue1()
        {
            var list = new List<int>
            {
                -5,
                -4,
                -2,
                2,
                4,
                3,
                1,
                2,
                3,
                4,
                1,
                2,
                3,
                4
            };


            var isPartiallyRecurring = list.IsPartiallyRecurring();

            isPartiallyRecurring.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnTrue2()
        {
            var list = new List<int>
            {
                1,2,3,
                1,2,3
            };


            var isPartiallyRecurring = list.IsPartiallyRecurring();

            isPartiallyRecurring.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalse1()
        {
            var list = new List<int>
            {
                1,2,3,
                4,5,6
            };


            var isPartiallyRecurring = list.IsPartiallyRecurring();

            isPartiallyRecurring.Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalse2()
        {
            var list = new List<int>
            {
                1,2,3
            };


            var isPartiallyRecurring = list.IsPartiallyRecurring();

            isPartiallyRecurring.Should().BeFalse();
        }
    }
}