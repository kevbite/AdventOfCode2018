namespace AdventOfCode2018.Day16
{
    public class MultiplyRegisterOperation : IOperation
    {
        public string OpCode { get; } = "mulr";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA * instructions.RegisterB;

            instructions.RegisterC = c;
        }
    }
}