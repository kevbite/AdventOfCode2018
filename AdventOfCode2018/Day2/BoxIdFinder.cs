using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day2
{
    public class BoxIdFinder
    {
        public string GetMostCommonLetters(string input)
        {
            var mostCommon = new List<string>();
            var orderedIds = input.Split(Environment.NewLine)
                .OrderBy(x => x).ToArray();

            for (var i = 0; i < orderedIds.Length -1; i++)
            {
                var firstId = orderedIds[i];
                var secondId = orderedIds[i+1];

                    var letters = "";
                for (var j = 0; j < firstId.Length; j++)
                {
                    if (firstId[j] == secondId[j])
                    {
                        letters += firstId[j];
                    }
                }
                mostCommon.Add(letters);
            }

            return mostCommon.OrderByDescending(x => x.Length)
                .First();
        }
    }
}
