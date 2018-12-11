namespace AdventOfCode2018.Day10
{
    public class FloatingLight
    {
        public Position Position { get; }

        public Velocity Velocity { get; }

        public FloatingLight(Position position, Velocity velocity)
        {
            Position = position;
            Velocity = velocity;
        }

        public FloatingLight Move()
        {
            var position = Position + Velocity;

            return new FloatingLight(position, Velocity);
        }
    }
}
