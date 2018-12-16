using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class GreaterThanRegisterRegisterOperationTests
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 0)]
        public void ShouldApplyOperation(int registerA, int registerB, int expectedC)
        {
            var operation = new GreaterThanRegisterRegisterOperation();

            var instructions = new MockInstructions() { RegisterA = registerA, RegisterB = registerB };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(expectedC);
        }
    }
}