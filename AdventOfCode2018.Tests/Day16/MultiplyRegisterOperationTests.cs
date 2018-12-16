using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class MultiplyRegisterOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new MultiplyRegisterOperation();

            var instructions = new MockInstructions(){RegisterA = 2, RegisterB = 2};
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(4);
        }
    }
}