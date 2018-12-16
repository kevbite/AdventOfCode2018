namespace AdventOfCode2018.Day16
{
    public class BitwiseOrImmediateOperation : IOperation
    {
        public string OpCode { get; } = "bori";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA | instructions.ValueB;

            instructions.RegisterC = c;
        }
    }
}