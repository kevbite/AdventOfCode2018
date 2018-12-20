using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class LumberCollectionArea
    {
        public ImmutableArray<ImmutableArray<Acre>> Acres { get; }

        private LumberCollectionArea(ImmutableArray<ImmutableArray<Acre>> acres)
        {
            Acres = acres;
        }

        public static LumberCollectionArea Parse(string s)
        {
            var array = s.Split(Environment.NewLine)
                .Select(x => x.ToCharArray().Select(c => AcreFactoryMap[c]()).ToImmutableArray())
                .ToImmutableArray();

            return new LumberCollectionArea(array);
        }

        public LumberCollectionArea Tick()
        {
            var transformArea = Acres.Select((acres, y) =>
                    acres.Select((acre, x) => acre.Transform(Acres.GetAdjacent(x, y).ToImmutableArray())).ToImmutableArray())
                .ToImmutableArray();

            return new LumberCollectionArea(transformArea);
        }



        private static readonly IReadOnlyDictionary<char, Func<Acre>>
            AcreFactoryMap = new Dictionary<char, Func<Acre>>
            {
                {'.', () => new OpenGroundAcre()},
                {'|', () => new TreesAcre()},
                {'#', () => new LumberyardAcre()}
            };

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Acres.Select(x => string.Concat(x)));
        }
    }
}