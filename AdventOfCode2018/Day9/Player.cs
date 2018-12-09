namespace AdventOfCode2018.Day9
{
    public class Player
    {
        public uint Score { get; private set; }

        public void AddScore(int score)
        {
            Score += (uint)score;
        }
    }
}