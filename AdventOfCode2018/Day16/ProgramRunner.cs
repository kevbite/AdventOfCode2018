using System;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class ProgramRunner
    {
        private readonly OperationsFactory _operationsFactory;

        public ProgramRunner(OperationsFactory operationsFactory)
        {
            _operationsFactory = operationsFactory;
        }

        public int[] Run(string program)
        {
            var registers = new []{0,0,0,0};
            var instructions = program.Split(Environment.NewLine)
                .Select(line => Instructions.Build(line, registers))
                .ToArray();

            foreach (var instruction in instructions)
            {
                var operation = _operationsFactory.GetOperation(instruction.OpCode);

                operation.Apply(instruction);
            }

            return registers;
        }
    }
}