namespace AdventOfCode2018.Day16
{
    public class BitwiseAndRegisterOperation : IOperation
    {
        public string OpCode { get; } = "banr";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA & instructions.RegisterB;

            instructions.RegisterC = c;
        }
    }
}