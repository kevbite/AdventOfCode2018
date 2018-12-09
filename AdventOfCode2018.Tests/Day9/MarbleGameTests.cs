using System;
using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2018.Day9;
using FluentAssertions.Execution;
using Xunit;

namespace AdventOfCode2018.Tests.Day9
{
    public class MarbleGameTests
    {
        [Fact]
        public void ShouldReturnCorrectOrderWhenPlaying6Turns()
        {
            var turns = Enumerable.Range(1, 6)
                .ToArray();

            var marbleGame = new MarbleGame();

            foreach (var turn in turns)
            {
                marbleGame.Play(new Player(), turn);
            }

            marbleGame.GetBoard().Should()
                .Be("0 4 2 5 1 (6) 3");
        }

        [Fact]
        public void ShouldReturnCorrectOrderWhenPlaying23Turns()
        {
            var turns = Enumerable.Range(1, 23).ToArray();

            var marbleGame = new MarbleGame();

            foreach (var turn in turns)
            {
                marbleGame.Play(new Player(), turn);
            }

            marbleGame.GetBoard().Should()
                .Be("0 16 8 17 4 18 (19) 2 20 10 21 5 22 11 1 12 6 13 3 14 7 15");
        }


        [Fact]
        public void ShouldReturnCorrectOrderWhenPlaying25Turns()
        {
            var turns = Enumerable.Range(1, 25).ToArray();

            var marbleGame = new MarbleGame();

            foreach (var turn in turns)
            {
                marbleGame.Play(new Player(), turn);
            }

            marbleGame.GetBoard().Should()
                .Be("0 16 8 17 4 18 19 2 24 20 (25) 10 21 5 22 11 1 12 6 13 3 14 7 15");
        }

        [Fact]
        public void ShouldReturnCorrectScoresForPlayersWhenPlaying()
        {
            var turns = new Queue<int>(Enumerable.Range(1, 26));
            var players = new Queue<Player>(Enumerable.Repeat(
                new Func<Player>(() => new Player()), 9).Select(x => x()));

            var marbleGame = new MarbleGame();

            while (turns.TryDequeue(out var turn))
            {
                var player = players.Dequeue();
                marbleGame.Play(player, turn);
                players.Enqueue(player);
            }

            using (new AssertionScope())
            {
                players.Count(x => x.Score == 32)
                    .Should().Be(1);

                players.Count(x => x.Score == 0)
                    .Should().Be(8);
            }
        }
    }
}
