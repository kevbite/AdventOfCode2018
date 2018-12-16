namespace AdventOfCode2018.Day16
{
    public interface IOperation
    {
        string OpCode { get; }

        void Apply(IInstructions instructions);
    }
}