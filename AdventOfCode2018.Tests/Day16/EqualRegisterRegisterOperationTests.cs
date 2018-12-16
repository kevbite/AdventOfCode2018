using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class EqualRegisterRegisterOperationTests
    {
        [Theory]
        [InlineData(10, 10, 1)]
        [InlineData(12, 8, 0)]
        public void ShouldApplyOperation(int registerA, int registerB, int expectedC)
        {
            var operation = new EqualRegisterRegisterOperation();

            var instructions = new MockInstructions() { RegisterA = registerA, RegisterB = registerB };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(expectedC);
        }
    }
}