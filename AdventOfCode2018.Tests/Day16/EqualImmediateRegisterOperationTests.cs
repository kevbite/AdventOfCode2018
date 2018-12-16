using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class EqualImmediateRegisterOperationTests
    {
        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(12, 8, 0)]
        public void ShouldApplyOperation(int valueA, int registerB, int expectedC)
        {
            var operation = new EqualImmediateRegisterOperation();

            var instructions = new MockInstructions() { ValueA = valueA, RegisterB = registerB };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(expectedC);
        }
    }
}