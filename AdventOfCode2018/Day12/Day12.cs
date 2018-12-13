using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2018.Day12
{
    public class Day12
    {
        private readonly HeatedCave _heatedCave;

        public Day12(HeatedCave heatedCave)
        {
            _heatedCave = heatedCave;
        }

        public long GetPotSumFor(long generations)
        {
            var stringBuilder = new StringBuilder();
            var heatedCave = _heatedCave;
            var set = new HashSet<string>();

            for (long i = 0; i < generations; i++)
            {
                heatedCave = heatedCave.Mutate();

                var item = heatedCave.ToString();
                stringBuilder.AppendLine(item);

                if (!set.Add(item))
                {
                    var sum1 = heatedCave.SumPotIndexes();
                    heatedCave = heatedCave.Mutate();
                    i++;
                    var sum2 = heatedCave.SumPotIndexes();

                    var diff = sum2 - sum1;

                    return sum2 + diff * (generations - i - 1);
                }
            }

            return heatedCave.SumPotIndexes();
        }
    }
}