﻿using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day9
{
    public class Day9Tests
    {
        [Theory]
        [InlineData(10, 1618, 8317)]
        [InlineData(13, 7999, 146373)]
        [InlineData(17, 1104, 2764)]
        [InlineData(21, 6111, 54718)]
        [InlineData(30, 5807, 37305)]
        public void ShouldReturnHighestScore(int players, int turns, int expectedScore)
        {
            var day9 = new AdventOfCode2018.Day9.Day9();

            var score = day9.FindHighestScore(players, turns);

            score.Should().Be(expectedScore);
        }
    }
}