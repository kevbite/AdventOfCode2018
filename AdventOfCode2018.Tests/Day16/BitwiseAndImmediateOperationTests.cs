using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class BitwiseAndImmediateOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new BitwiseAndImmediateOperation();

            var instructions = new MockInstructions() { RegisterA = 0b1101, ValueB = 0b1011 };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(0b1001);
        }
    }
}