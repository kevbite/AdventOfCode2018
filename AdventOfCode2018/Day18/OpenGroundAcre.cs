using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class OpenGroundAcre : Acre
    {
        public override Acre Transform(IReadOnlyCollection<Acre> adjacentAcres)
        {
            if (adjacentAcres.OfType<TreesAcre>()
                    .Count() >= 3)
            {
                return new TreesAcre();
            }

            return base.Transform(adjacentAcres);
        }

        public override string ToString()
        {
            return ".";
        }
    }
}