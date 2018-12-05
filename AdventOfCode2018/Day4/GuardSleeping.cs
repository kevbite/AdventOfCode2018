using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day4
{
    public class GuardSleeping
    {
        public int GuardId { get; set; }

        public List<(int start, int end)> Times { get; set; } = new List<(int start, int end)>();


        public int TotalMinutes() => (int)Times.Sum(x => x.end - x.start);

    }
}