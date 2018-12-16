using System.Collections.Generic;
using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class ProgramRunnerTests
    {
        [Fact]
        public void ShouldBeAbleToRunSimpleProgram()
        {
            var opMap = new Dictionary<int, string>()
            {
                {0, "seti" },
                {1, "addi" },
                {2, "addr" }
            };
            
            var programRunner = new ProgramRunner(new OperationsFactory(opMap));

            var registers = programRunner.Run(@"0 1 0 0
1 0 1 1
2 0 1 2");

            registers.Should().BeEquivalentTo(new[] {1, 2, 3, 0});
        }
    }
}
