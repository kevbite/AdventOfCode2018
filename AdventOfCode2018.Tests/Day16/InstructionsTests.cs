using AdventOfCode2018.Day16;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day16
{
    public class InstructionsTests
    {
        [Fact]
        public void ShouldBeAbleToGetRegistersZeroAndOne()
        {
            var registers = new []{1, 2, 3, 4};
            var instructions = Instructions.Build("1 0 1 2", registers);

            instructions.Should().BeEquivalentTo(new
            {
                OpCode = 1,
                RegisterA = 1,
                RegisterB = 2
            });
        }

        [Fact]
        public void ShouldBeAbleToGetRegistersTwoAndThree()
        {
            var registers = new[] { 1, 2, 3, 4 };
            var instructions = Instructions.Build("2 2 3 0", registers);

            instructions.Should().BeEquivalentTo(new
            {
                OpCode = 2,
                RegisterA = 3,
                RegisterB = 4
            });
        }

        [Fact]
        public void ShouldBeAbleToGetValuesAAndB()
        {
            var registers = new int[] { };
            var instructions = Instructions.Build("2 2 3 0", registers);

            instructions.Should().BeEquivalentTo(new
            {
                OpCode = 2,
                ValueA = 2,
                ValueB = 3
            });
        }

        [Fact]
        public void ShouldSetRegister()
        {
            var registers = new[] { 1, 2, 3, 4 };
            var instructions = Instructions.Build("3 0 0 0", registers);

            instructions.RegisterC = 0;

            registers.Should().BeEquivalentTo(new[] {0, 2, 3, 4});
        }
    }
}