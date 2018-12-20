using System.Collections.Generic;

namespace AdventOfCode2018.Day18
{
    public abstract class Acre
    {
        public virtual Acre Transform(IReadOnlyCollection<Acre> adjacentAcres)
        {
            return this;
        }
    }
}
