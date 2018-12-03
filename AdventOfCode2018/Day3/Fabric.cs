using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day3
{
    public class Fabric
    {
        public int ProcessClaims(string input)
        {
            var array = GetClaimGrid(input);

            var sum = array.Sum(x => x.Count(y => y.Count > 1));
            return sum;
        }

        public string FindNoneOverlappingClaimId(string input)
        {
            var array = GetClaimGrid(input);

            var moreThanOne = array.SelectMany(x => x.Where(y => y.Count > 1).SelectMany(y => y))
                .Distinct();

            return array.SelectMany(x => x.Where(y => y.Count == 1).SelectMany(y => y))
                .Distinct()
                .Except(moreThanOne)
                .ToList()
                .Distinct()
                .Single();
        }

        private List<string>[][] GetClaimGrid(string input)
        {
            var parsed = ParseInput(input);

            var maxWidth = parsed.Max(x => x.point.X + x.size.Width);
            var maxHeight = parsed.Max(x => x.point.Y + x.size.Height);

            var array = Enumerable.Range(0, maxWidth)
                .Select(x => Enumerable.Repeat(new Func<List<string>>(() => new List<string>()), maxHeight)
                    .Select(y => y()).ToArray())
                .ToArray();

            foreach (var tuple in parsed)
            {
                for (int x = 0; x < tuple.size.Width; x++)
                {
                    for (int y = 0; y < tuple.size.Height; y++)
                    {
                        array[x + tuple.point.X][y + tuple.point.Y]
                            .Add(tuple.id);
                    }
                }
            }

            return array;
        }

        private IEnumerable<(string id, Point point, Size size)> ParseInput(string input)
        {
            return input.Split(Environment.NewLine)
                .Select(x =>
                {
                    var match = Regex.Match(x, @"#(\d+) @ (\d+,\d+): (\d+x\d+)");

                    var id = match.Groups[1].Value;
                    var point = 
                        new Point()
                        {
                            X = int.Parse(match.Groups[2].Value.Split(",").First()),
                            Y = int.Parse(match.Groups[2].Value.Split(",").Last()),
                        };

                    var size = new Size()
                    {
                        Width = int.Parse(match.Groups[3].Value.Split("x").First()),
                        Height = int.Parse(match.Groups[3].Value.Split("x").Last())
                    };
                    return (id, point, size);
                }).ToList();
        }
    }
}
