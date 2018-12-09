using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day9
{
    public class Day9
    {
        public long FindHighestScore(int playerCount, int turnCount)
        {
            var turns = new Queue<int>(Enumerable.Range(1, turnCount));
            var players = new Queue<Player>(Enumerable.Repeat(
                new Func<Player>(() => new Player()), playerCount).Select(x => x()));

            var marbleGame = new MarbleGame();

            while (turns.TryDequeue(out var turn))
            {
                var player = players.Dequeue();
                marbleGame.Play(player, turn);
                players.Enqueue(player);
            }

            return players.Max(x => x.Score);
        }
    }
}