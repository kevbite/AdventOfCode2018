using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day10
{
    public class Sky
    {
        private readonly IReadOnlyCollection<FloatingLight> _floatingLights;
        private readonly int _minX;
        private readonly int _maxX;
        private readonly int _minY;
        private readonly int _maxY;

        public int Width => _maxX - _minX;

        public int Height => _maxY - _minY;

        private Sky(IReadOnlyCollection<FloatingLight> floatingLights, int minX, int maxX, int minY, int maxY)
        {
            _floatingLights = floatingLights;
            _minX = minX;
            _maxX = maxX;
            _minY = minY;
            _maxY = maxY;
        }

        public Sky(IReadOnlyCollection<FloatingLight> floatingLights)
            : this(floatingLights, floatingLights.Min(x => x.Position.X),
                floatingLights.Max(x => x.Position.X),
                floatingLights.Min(x => x.Position.Y),
                floatingLights.Max(x => x.Position.Y))
        {

        }

        public override string ToString()
        {
            var maxX = _maxX - _minX;
            var maxY = _maxY - _minY;
            
            var sb = new StringBuilder();

            var valueTuples = _floatingLights.Select(x => (x.Position.X, x.Position.Y))
                .ToHashSet();

            for (var y = 0; y <= maxY; y++)
            {
                for (var x = 0; x <= maxX; x++)
                {
                    if (valueTuples.Contains((x + _minX, y +_minY)))
                    {
                        sb.Append('#');
                    }
                    else
                    {
                        sb.Append('.');
                    }
                }

                if (y != maxY)
                {
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        public Sky Watch()
        {
            var floatingLights = _floatingLights
                .Select(x => x.Move())
                .ToImmutableArray();

            return new Sky(floatingLights);
        }
    }
}