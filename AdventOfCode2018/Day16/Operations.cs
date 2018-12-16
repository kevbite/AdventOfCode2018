using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day16
{
    public static class Operations
    {
        public static IEnumerable<IOperation> AllOperations { get; }
            = typeof(IOperation).Assembly.GetTypes()
                .Where(x => x.IsClass && x.GetInterfaces().Any(i => i == typeof(IOperation)))
                .Select(Activator.CreateInstance)
                .Cast<IOperation>()
                .ToArray();
    }
}