using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public class OperationsFactory
    {
        private readonly IReadOnlyDictionary<int, string> _opCodeMap;

        public static IEnumerable<IOperation> AllOperations { get; }
            = typeof(IOperation).Assembly.GetTypes()
                .Where(x => x.IsClass && x.GetInterfaces().Any(i => i == typeof(IOperation)))
                .Select(Activator.CreateInstance)
                .Cast<IOperation>()
                .ToArray();

        public OperationsFactory(IReadOnlyDictionary<int, string> opCodeMap)
        {
            _opCodeMap = opCodeMap;
        }
        public IOperation GetOperation(int opCode)
        {
            return AllOperations.Single(x => x.OpCode == _opCodeMap[opCode]);
        }
    }
}