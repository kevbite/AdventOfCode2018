namespace AdventOfCode2018.Day16
{
    public class GreaterThanImmediateRegisterOperation : IOperation
    {
        public string OpCode { get; } = "gtir";

        public void Apply(IInstructions instructions)
        {
            var c = 0;
            if (instructions.ValueA > instructions.RegisterB)
            {
                c = 1;
            }

            instructions.RegisterC = c;
        }
    }
}