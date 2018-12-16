namespace AdventOfCode2018.Day16
{
    public class GreaterThanRegisterImmediateOperation : IOperation
    {
        public string OpCode { get; } = "gtri";

        public void Apply(IInstructions instructions)
        {
            var c = 0;
            if (instructions.RegisterA > instructions.ValueB)
            {
                c = 1;
            }

            instructions.RegisterC = c;
        }
    }
}