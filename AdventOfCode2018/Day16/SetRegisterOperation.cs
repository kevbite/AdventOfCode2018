namespace AdventOfCode2018.Day16
{
    public class SetRegisterOperation : IOperation
    {
        public string OpCode { get; } = "setr";

        public void Apply(IInstructions instructions)
        {
            var c = instructions.RegisterA;

            instructions.RegisterC = c;
        }
    }
}