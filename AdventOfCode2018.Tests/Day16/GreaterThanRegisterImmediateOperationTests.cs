using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class GreaterThanRegisterImmediateOperationTests
    {
        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, 0)]
        public void ShouldApplyOperation(int registerA, int valueB, int expectedC)
        {
            var operation = new GreaterThanRegisterImmediateOperation();

            var instructions = new MockInstructions() { RegisterA = registerA, ValueB = valueB };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(expectedC);
        }
    }
}