using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class PossibleOpCodesProvider
    {
        public virtual string[] GetPossibleOpCodes(Sample sample)
        {
            var possibleOpCodes = new List<string>();
            
            foreach (var operation in OperationsFactory.AllOperations)
            {
                var currentRegister = sample.Before.ToArray();
                var currentInstructions = Instructions.Build(sample.Instructions, currentRegister);
                operation.Apply(currentInstructions);

                if (currentRegister.SequenceEqual(sample.After))
                {
                    possibleOpCodes.Add(operation.OpCode);
                }
            }

            return possibleOpCodes.ToArray();
        }
    }
}
