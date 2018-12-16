using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class SetRegisterOperationTests
    {
        [Fact]
        public void ShouldApplyOperation()
        {
            var operation = new SetRegisterOperation();

            var instructions = new MockInstructions() { RegisterA = 12 };
            operation.Apply(instructions);

            instructions.RegisterC.Should().Be(12);
        }
    }
}