using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace AdventOfCode2018.Day16
{
    public class OpCodeMapBuilder
    {
        private readonly PossibleOpCodesProvider _possibleOpCodesProvider;

        public OpCodeMapBuilder(PossibleOpCodesProvider possibleOpCodesProvider)
        {
            _possibleOpCodesProvider = possibleOpCodesProvider;
        }

        public IReadOnlyDictionary<int, string> BuildMap(IEnumerable<Sample> puzzles)
        {
            var possible = puzzles.Select(x => new
            {
                OpCode = int.Parse(x.Instructions.Split(' ').First()),
                PossibleOpCodes = _possibleOpCodesProvider.GetPossibleOpCodes(x)
            }).GroupBy(x => x.OpCode)
                .Select(x => new
                {
                    OpCode = x.Key,
                    Possible = x.OrderBy(y => y.PossibleOpCodes.Length).First().PossibleOpCodes
                }).ToList();
            

            var opCodeMap = new Dictionary<int, string>();
            var single = possible.Single(x => x.Possible.Length == 1);
            opCodeMap.Add(single.OpCode, single.Possible.Single());

            while (opCodeMap.Keys.Count != possible.Count)
            {
                var next = possible
                    .First(x => x.Possible.Except(opCodeMap.Values).Count() == 1);

                var source = next.Possible.Except(opCodeMap.Values).Single();
                opCodeMap.Add(next.OpCode, source);
            }

            return opCodeMap;
        }
    }
}
