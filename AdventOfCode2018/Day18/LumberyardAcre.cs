using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class LumberyardAcre : Acre
    {
        public override Acre Transform(IReadOnlyCollection<Acre> adjacentAcres)
        {
            if (adjacentAcres.OfType<LumberyardAcre>().Any()
                && adjacentAcres.OfType<TreesAcre>().Any())
            {
                return new LumberyardAcre();
            }

            return new OpenGroundAcre();
        }

        public override string ToString()
        {
            return "#";
        }
    }
}