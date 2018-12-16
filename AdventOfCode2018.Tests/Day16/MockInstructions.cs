using AdventOfCode2018.Day16;

namespace AdventOfCode2018.Tests.Day16
{
    public class MockInstructions : IInstructions
    {
        public int OpCode { get; set; }

        public int RegisterA { get; set; }

        public int RegisterB { get; set; }

        public int ValueA { get; set; }

        public int ValueB { get; set; }

        public int RegisterC { get; set; }

    }
}