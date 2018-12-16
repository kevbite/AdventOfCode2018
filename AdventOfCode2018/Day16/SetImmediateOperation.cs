namespace AdventOfCode2018.Day16
{
    public class SetImmediateOperation : IOperation
    {
        public string OpCode { get; } = "seti";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.ValueA;

            instructions.RegisterC = c;
        }
    }
}