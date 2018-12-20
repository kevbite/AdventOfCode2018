using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class TreesAcre : Acre
    {
        public override Acre Transform(IReadOnlyCollection<Acre> adjacentAcres)
        {
            if (adjacentAcres.OfType<LumberyardAcre>()
                    .Count() >= 3)
            {
                return new LumberyardAcre();
            }

            return base.Transform(adjacentAcres);
        }

        public override string ToString()
        {
            return "|";
        }
    }
}