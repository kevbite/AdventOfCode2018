namespace AdventOfCode2018.Day10
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public static Position operator +(Position p, Velocity v)
        {
            var x = p.X + v.X;
            var y = p.Y + v.Y;

            return new Position(x, y);
        }
    }
}