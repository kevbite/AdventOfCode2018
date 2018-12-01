using System;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode2018
{
    public class ChronalCalibration
    {
        public int CalculatePart1(string input)
        {
            var split = input.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            var number = split.Select(int.Parse).ToArray();

            return number.Sum();
        }

        public int CalculatePart2(string input)
        {
            var set = new HashSet<int>();
            var values = GetValues(input);

            var sum = 0;
            foreach (var value in values)
            {
                sum += value;

                if (set.Contains(sum))
                {
                    return sum;
                }

                set.Add(sum);
            }

            throw new NotImplementedException();
        }

        private IEnumerable<int> GetValues(string input)
        {
            var split = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            while (true)
                foreach (var item in split)
                    yield return item;
        }
    }
}
