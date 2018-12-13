using System;
using System.Collections.Generic;

namespace AdventOfCode2018.Day13
{
    public class Cart
    {
        private readonly long _intersectionMoves;

        public Cart(int x, int y, CartDirection direction)
            : this(x, y, direction, 0)
        {

        }

        public Cart(int x, int y, CartDirection direction, long intersectionMoves)
        {
            _intersectionMoves = intersectionMoves;
            X = x;
            Y = y;
            Direction = direction;
        }

        public int X { get; }

        public int Y { get; }

        public CartDirection Direction { get; }

        public Cart Move(string track)
        {
            var x = X;
            var y = Y;
            var direction = Direction;
            var intersectionMoves = _intersectionMoves;

            var position = track.Split(Environment.NewLine)[Y][X];
             if (position == '\\')
            {
                if (Direction == CartDirection.Right)
                {
                    direction = CartDirection.Down;
                }
                else if (Direction == CartDirection.Up)
                {
                    direction = CartDirection.Left;
                }
                else if (Direction == CartDirection.Down)
                {
                    direction = CartDirection.Right;
                }
                else if (Direction == CartDirection.Left)
                {
                    direction = CartDirection.Up;
                }
            }
            else if (position == '/')
            {
                if (Direction == CartDirection.Left)
                {
                    direction = CartDirection.Down;
                }else if (Direction == CartDirection.Up)
                {
                    direction = CartDirection.Right;
                }else if (Direction == CartDirection.Down)
                {
                    direction = CartDirection.Left;
                }
                else if (Direction == CartDirection.Right)
                {
                    direction = CartDirection.Up;
                }
            }else if (position == '+')
            {
                var move = (IntersectionMove) (intersectionMoves % 3 + 1);
                direction = IntersectionMoveCartDirectionMap[(move, Direction)];
                intersectionMoves++;
            }

            switch (direction)
            {
                case CartDirection.Up:
                    y--;
                    break;
                case CartDirection.Down:
                    y++;
                    break;
                case CartDirection.Left:
                    x--;
                    break;
                case CartDirection.Right:
                    x++;
                    break;
            }

            return new Cart(x, y, direction, intersectionMoves);

        }

        private static readonly IReadOnlyDictionary<(IntersectionMove, CartDirection), CartDirection>
            IntersectionMoveCartDirectionMap = new Dictionary<(IntersectionMove, CartDirection), CartDirection>()
            {
                {(IntersectionMove.Left, CartDirection.Right), CartDirection.Up},
                {(IntersectionMove.Left, CartDirection.Up), CartDirection.Left},
                {(IntersectionMove.Left, CartDirection.Left), CartDirection.Down},
                {(IntersectionMove.Left, CartDirection.Down), CartDirection.Right},
                {(IntersectionMove.Right, CartDirection.Right), CartDirection.Down},
                {(IntersectionMove.Right, CartDirection.Down), CartDirection.Left},
                {(IntersectionMove.Right, CartDirection.Left), CartDirection.Up},
                {(IntersectionMove.Right, CartDirection.Up), CartDirection.Right},
                {(IntersectionMove.Straight, CartDirection.Right), CartDirection.Right},
                {(IntersectionMove.Straight, CartDirection.Down), CartDirection.Down},
                {(IntersectionMove.Straight, CartDirection.Left), CartDirection.Left},
                {(IntersectionMove.Straight, CartDirection.Up), CartDirection.Up},
            };
    }
}