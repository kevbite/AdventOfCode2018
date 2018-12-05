using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day5
{
    public class Polymer
    {
        public int React(string units)
        {
            var lastReduce = InnerReact(units);

            while (lastReduce != InnerReact(lastReduce))
            {
                lastReduce = InnerReact(lastReduce);
            }
            
            return lastReduce.Length;
        }

        private static string InnerReact(string units)
        {
            var stringBuilder = new StringBuilder();
            for (int i = 0; i < units.Length; i++)
            {
                var first = units[i];
                var second = i + 1 < units.Length ? units[i + 1] : '\0';

                if (first != second && char.ToLowerInvariant(first) == char.ToLowerInvariant(second))
                {
                    stringBuilder.Append(units.Substring(i + 2));
                    break;
                }

                stringBuilder.Append(first);
            }

            return stringBuilder.ToString();
        }

        public int FindShortest(string input)
        {
            return Enumerable.Range('a', 26)
                .Select(x =>
                    input.Replace(((char) x).ToString(), "", StringComparison.InvariantCultureIgnoreCase)
                )
                .Select(React)
                .OrderBy(x => x)
                .First();
        }
    }
}
