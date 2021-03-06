﻿using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class Sample
    {
        public Sample(int[] before, string instructions, int[] after)
        {
            Before = before;
            Instructions = instructions;
            After = after;
        }

        public int[] Before { get; }

        public string Instructions { get; }

        public int[] After { get; }

        public static Sample ReadNext(TextReader textReader)
        {
            int[] ParseArray(string input)
            {
                var split = input.Split(new[] {'[', ']'},StringSplitOptions.RemoveEmptyEntries);
                var numbers = split.Last().Split(", ");

                return numbers.Select(int.Parse).ToArray();
            }

            var beforeLine = textReader.ReadLine();
            var instructionsLine = textReader.ReadLine();
            var afterLine = textReader.ReadLine();
            textReader.ReadLine();

            if (beforeLine == null)
            {
                return null;
            }

            return new Sample(ParseArray(beforeLine), instructionsLine, ParseArray(afterLine));
        }
    }
}