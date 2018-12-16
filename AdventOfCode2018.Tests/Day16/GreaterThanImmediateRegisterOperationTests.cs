using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class GreaterThanImmediateRegisterOperationTests
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 0)]
        public void ShouldApplyOperation(int valueA, int registerB, int expectedC)
        {
            var operation = new GreaterThanImmediateRegisterOperation();

            var instructions = new MockInstructions() { ValueA = valueA, RegisterB = registerB };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(expectedC);
        }
    }
}