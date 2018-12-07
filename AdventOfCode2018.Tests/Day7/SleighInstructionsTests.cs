using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2018.Day7;
using Xunit;

namespace AdventOfCode2018.Tests.Day7
{
    public static class Instructions
    {
        public const string Text = @"Step C must be finished before step A can begin.
Step C must be finished before step F can begin.
Step A must be finished before step B can begin.
Step A must be finished before step D can begin.
Step B must be finished before step E can begin.
Step D must be finished before step E can begin.
Step F must be finished before step E can begin.";

    }

    public class SleighInstructionsTests
    {
        [Fact]
        public void ReturnsCorrectOrder()
        {
            var sleighInstructions = new SleighInstructions();
            var input = Instructions.Text;

            var output = sleighInstructions.FindOrder(input);

            Assert.Equal("CABDFE", output);
        }

        [Fact]
        public void ReturnsCorrectOrder2()
        {
            var sleighInstructions = new SleighInstructions();
            var input = @"Step C must be finished before step A can begin.
Step C must be finished before step B can begin.
Step A must be finished before step X can begin.
Step A must be finished before step D can begin.
Step X must be finished before step E can begin.
Step D must be finished before step E can begin.
Step B must be finished before step E can begin.";

            var output = sleighInstructions.FindOrder(input);

            Assert.Equal("CABDXE", output);
        }
    }
}
