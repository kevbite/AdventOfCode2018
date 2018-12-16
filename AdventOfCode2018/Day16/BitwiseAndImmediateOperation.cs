namespace AdventOfCode2018.Day16
{
    public class BitwiseAndImmediateOperation : IOperation
    {
        public string OpCode { get; } = "bani";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA & instructions.ValueB;

            instructions.RegisterC = c;
        }
    }
}