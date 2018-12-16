using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class BitwiseAndRegisterOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new BitwiseAndRegisterOperation();

            var instructions = new MockInstructions() { RegisterA = 0b101, RegisterB = 0b011 };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(0b001);
        }
    }
}