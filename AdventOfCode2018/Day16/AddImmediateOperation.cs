namespace AdventOfCode2018.Day16
{
    public class AddImmediateOperation : IOperation
    {
        public string OpCode { get; } = "addi";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA + instructions.ValueB;

            instructions.RegisterC = c;
        }
    }
}