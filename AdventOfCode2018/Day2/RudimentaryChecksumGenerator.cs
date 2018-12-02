using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day2
{
    public class RudimentaryChecksumGenerator
    {
        public int Generate(string input)
        {
            var ids = input.Split(Environment.NewLine)
                .Select(x => x.GroupBy(y => y))
                .Select(x => new {Two = x.Any(y => y.Count() == 2), Three = x.Any(y => y.Count() == 3)});

            var twos = ids.Count(x => x.Two);
            var threes = ids.Count(x => x.Three);

            return twos * threes;
        }
    }
}
