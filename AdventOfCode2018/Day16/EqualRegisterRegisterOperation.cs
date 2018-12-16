namespace AdventOfCode2018.Day16
{
    public class EqualRegisterRegisterOperation : IOperation
    {
        public string OpCode { get; } = "eqrr";

        public void Apply(IInstructions instructions)
        {
            var c = 0;
            if (instructions.RegisterA == instructions.RegisterB)
            {
                c = 1;
            }

            instructions.RegisterC = c;
        }
    }
}