namespace AdventOfCode2018.Day16
{
    public class BitwiseOrRegisterOperation : IOperation
    {
        public string OpCode { get; } = "borr";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA | instructions.RegisterB;

            instructions.RegisterC = c;
        }
    }
}