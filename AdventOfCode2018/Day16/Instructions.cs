using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class Instructions : IInstructions
    {
        private readonly int[] _registers;
        private readonly int _a;
        private readonly int _b;
        private readonly int _c;

        public Instructions(int[] registers, int opCode, int a, int b, int c)
        {
            _registers = registers;
            _a = a;
            _b = b;
            _c = c;
            OpCode = opCode;
        }

        public int OpCode { get; }

        public int RegisterA => GetRegistersValue(_a);

        public int RegisterB => GetRegistersValue(_b);

        public int ValueA => _a;

        public int ValueB => _b;

        public int RegisterC
        {
            set => SetRegistersValue(_c, value);
        }

        private int GetRegistersValue(int index)
        {
            return _registers[index];
        }

        private void SetRegistersValue(int index, int value)
        {
            _registers[index] = value;
        }

        public static Instructions Build(string instructions, int[] registers)
        {
            var split = instructions.Split(' ')
                .Select(int.Parse)
                .ToArray();

            var opCode = split[0];
            var a = split[1];
            var b = split[2];
            var c = split[3];

            return new Instructions(registers, opCode, a, b, c);
        }
    }
}
