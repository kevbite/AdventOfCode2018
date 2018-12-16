using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class AddImmediateOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new AddImmediateOperation();

            var instructions = new MockInstructions() { RegisterA = 2, ValueB = 3 };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(5);
        }
    }
}