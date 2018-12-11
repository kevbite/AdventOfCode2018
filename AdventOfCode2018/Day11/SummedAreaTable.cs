namespace AdventOfCode2018.Day11
{
    public class SummedAreaTable
    {
        private readonly int[,] _summedAreaTable;

        public SummedAreaTable(int[][] grid)
        {
            _summedAreaTable = new int[grid.Length, grid[0].Length];

            for (var x = 0; x < grid.Length; x++)
            {
                for (var y = 0; y < grid[0].Length; y++)
                {
                    _summedAreaTable[x, y]
                        = grid[x][y]
                          + GetSummedAreaTableValue(x, y -1)
                          + GetSummedAreaTableValue(x - 1, y)
                          - GetSummedAreaTableValue(x - 1, y - 1);

                }
            }
        }
        private int GetSummedAreaTableValue(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return 0;
            }

            return _summedAreaTable[x, y];
        }

        public int GetRectangleSum(int x1, int y1, int x2, int y2)
        {
            var d = GetSummedAreaTableValue(x2, y2);
            var a = GetSummedAreaTableValue(x1 - 1, y1 - 1);
            var b = GetSummedAreaTableValue(x2, y1 -1);
            var c = GetSummedAreaTableValue(x1 - 1, y2);

            return d + a - b - c;
        }
    }
}