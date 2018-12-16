using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class SetImmediateOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new SetImmediateOperation();

            var instructions = new MockInstructions() { ValueA = 45};
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(45);
        }
    }
}