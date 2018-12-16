using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class MultiplyImmediateOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new MultiplyImmediateOperation();

            var instructions = new MockInstructions(){RegisterA = 2, ValueB = 6};
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(12);
        }
    }
}