namespace AdventOfCode2018.Day16
{
    public interface IInstructions
    {
        int OpCode { get; }

        int RegisterA { get; }

        int RegisterB { get; }

        int ValueA { get; }

        int ValueB { get; }

        int RegisterC { set; }
    }
}