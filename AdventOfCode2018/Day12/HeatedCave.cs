using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day12
{
    public class HeatedCave
    {
        private readonly int _offset;
        public IReadOnlyDictionary<string, string> Rules { get; }
        public string Plants { get; }

        public HeatedCave(string plants, IReadOnlyDictionary<string, string> rules)
        {
            var padding = new string('.', 1000);
            Plants = padding + plants + padding;
            Rules = rules;
            _offset = -padding.Length;
        }

        public HeatedCave(int offset, string plants, IReadOnlyDictionary<string, string> rules)
        {
            Plants = plants;
            _offset = offset;
            Rules = rules;
        }

        public HeatedCave Mutate()
        {
            var output = new string('.', Plants.Length);
            
            for (var i = 0; i < Plants.Length - 5; i++)
            {
                var key = new string(Plants.Skip(i).Take(5).ToArray());

                if (Rules.ContainsKey(key))
                {
                    output = output.Substring(0, i + 2) + Rules[key] +
                             output.Substring(i + 3);
                }
            }

            return new HeatedCave(_offset, output, Rules);
        }

        public override string ToString()
        {
            return Plants.Trim('.');
        }

        public int SumPotIndexes()
        {
            var sum = 0;
            for (int i = 0; i < Plants.Length; i++)
            {
                if (Plants[i] == '#')
                {
                    sum += i + _offset;
                }
            }

            return sum;
        }

        public static HeatedCave Parse(string input)
        {
            var lines = input.Split(Environment.NewLine);

            var plants = lines[0].Split(' ').Last();

            var rules = lines.Skip(2)
                .Select(x => x.Split(" => "))
                .ToDictionary(x => x[0], x => x[1]);

            return new HeatedCave(plants, rules);
        }
    }
}