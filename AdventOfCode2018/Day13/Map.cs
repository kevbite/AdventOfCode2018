using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day13
{
    public class Map
    {
        public Map(string tracks, IReadOnlyCollection<Cart> carts)
        {
            Tracks = tracks;
            Carts = carts;
        }

        public static Map Parse(string input)
        {
            var sb = new StringBuilder(input.Length);

            var lines = input.Split(Environment.NewLine);
            var carts = new List<Cart>();
            
            for (var y = 0; y < lines.Length; y++)
            {
                for (var x = 0; x < lines[y].Length; x++)
                {
                    switch (lines[y][x])
                    {
                        case '>':
                            carts.Add(new Cart(x, y, CartDirection.Right));
                            sb.Append('-');
                            break;
                        case '<':
                            carts.Add(new Cart(x, y, CartDirection.Left));
                            sb.Append('-');
                            break;

                        case 'v':
                            carts.Add(new Cart(x, y, CartDirection.Down));
                            sb.Append('|');
                            break;
                        case '^':
                            carts.Add(new Cart(x, y, CartDirection.Up));
                            sb.Append('|');
                            break;
                        default:
                            sb.Append(lines[y][x]);
                            break;
                    }
                }
                sb.AppendLine();
            }


            string tracks = sb.ToString().TrimEnd(Environment.NewLine.ToCharArray());
            return new Map(tracks, carts);
        }

        public string Tracks { get; }

        public IReadOnlyCollection<Cart> Carts { get; }

        public IReadOnlyCollection<Cart> GetCrashedCarts()
        {
            return Carts.GroupBy(cart => (cart.X, cart.Y))
                .Where(x => x.Count() > 1)
                .SelectMany(x => x)
                .ToImmutableArray();
        }

        public Map Tick()
        {
            var movedCarts = Carts.Select(x => x.Move(Tracks))
                .ToImmutableArray();

            return new Map(Tracks, movedCarts);
        }
    }
}
