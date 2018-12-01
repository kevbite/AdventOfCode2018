using Xunit;

namespace AdventOfCode2018.Tests
{
    public class ChronalCalibrationTests
    {
        [Theory]
        [InlineData(@"+1
-2
+3
+1", 3)]
        [InlineData(@"+1
+1
+1", 3)]
        [InlineData(@"+1
+1
-2", 0)]
        [InlineData(@"-1
-2
-3", -6)]
        public void ShouldCalculateCorrectOutputForPart1(string input, int expectedResult)
        {
            var chronalCalibration = new ChronalCalibration();

            var result = chronalCalibration.CalculatePart1(input);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(@"+1
-2
+3
+1", 2)]
        public void ShouldCalculateCorrectOutputForPart2(string input, int expectedResult)
        {
            var chronalCalibration = new ChronalCalibration();

            var result = chronalCalibration.CalculatePart2(input);

            Assert.Equal(expectedResult, result);
        }
    }
}
