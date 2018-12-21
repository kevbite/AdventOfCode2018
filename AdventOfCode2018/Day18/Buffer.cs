using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day18
{
    public class Buffer<T> : Queue<T>
    {
        private int MaxCapacity { get; }

        public Buffer(int capacity)
        {
            MaxCapacity = capacity;
        }

        public void Add(T newElement)
        {
            if (HasMaxCapacity())
            {
                Dequeue();
            }

            Enqueue(newElement);
        }

        private bool HasMaxCapacity()
        {
            return Count == MaxCapacity;
        }

        public bool AllPositivelyCorrelate()
        {
            if (!HasMaxCapacity())
            {
                return false;
            }

            return this.OrderBy(x => x).SequenceEqual(this);
        }

        public bool AllNegativelyCorrelate()
        {
            if (!HasMaxCapacity())
            {
                return false;
            }

            return this.OrderByDescending(x => x).SequenceEqual(this);
        }
    }
}