using AdventOfCode2018.Day7;
using Xunit;

namespace AdventOfCode2018.Tests.Day7
{
    public class WorkersTests
    {
        [Fact]
        public void ShouldReturnCorrectSeconds()
        {
            Step.BaseSeconds = 0;
            var workers = new Workers(2);

            var seconds = workers.Complete(Instructions.Text);

            Assert.Equal(15, seconds);
        }
    }
}
