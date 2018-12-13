using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdventOfCode2018.Day13
{
    public class Map
    {
        public Map(string tracks, IReadOnlyCollection<Cart> carts)
        : this(tracks, carts, null)
        {

        }

        public Map(string tracks, IReadOnlyCollection<Cart> carts, Cart crashedCart)
        {
            CrashedCart = crashedCart;
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

        public Cart CrashedCart { get; }

        public Map Tick()
        {
            Cart crashed = null;
            var movedCarts = new List<Cart>();
            var usedCarts = new List<Cart>();

            var cartsInOrder = Carts.GroupBy(x => x.Y)
                .OrderBy(x => x.Key)
                .SelectMany(grouping => grouping.OrderBy(cart => cart.X))
                .ToArray();

            for (var i = 0; i < cartsInOrder.Length; i++)
            {
                var cart = cartsInOrder[i];
                usedCarts.Add(cart);
                var movedCart = cart.Move(Tracks);

                if (Carts.Except(usedCarts).Concat(movedCarts).Any(x => x.X == movedCart.X && x.Y == movedCart.Y))
                {
                    crashed = movedCart;

                    movedCarts.AddRange(cartsInOrder.Skip(i + 1));
                    break;
                }

                movedCarts.Add(movedCart);
            }

            return new Map(Tracks, movedCarts, crashed);
        }
    }
}
