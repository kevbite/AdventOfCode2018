namespace AdventOfCode2018.Day16
{
    public class AddRegisterOperation : IOperation
    {
        public string OpCode { get; } = "addr";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA + instructions.RegisterB;

            instructions.RegisterC = c;
        }
    }
}