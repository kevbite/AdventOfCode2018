using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class Day16
    {
        public string[] GetPossibleOpCodes(int[] before, string instructions, int[] after)
        {
            var possibleOpCodes = new List<string>();
            
            foreach (var operation in Operations.AllOperations)
            {
                var currentRegister = before.ToArray();
                var currentInstructions = Instructions.Build(instructions, currentRegister);
                operation.Apply(currentInstructions);

                if (currentRegister.SequenceEqual(after))
                {
                    possibleOpCodes.Add(operation.OpCode);
                }
            }

            return possibleOpCodes.ToArray();
        }
    }
}
