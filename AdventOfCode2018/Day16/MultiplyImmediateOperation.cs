namespace AdventOfCode2018.Day16
{
    public class MultiplyImmediateOperation : IOperation
    {
        public string OpCode { get; } = "muli";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA * instructions.ValueB;

            instructions.RegisterC = c;
        }
    }
}