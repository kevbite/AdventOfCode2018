using AdventOfCode2018.Day3;
using Xunit;

namespace AdventOfCode2018.Tests.Day3
{
    public class FabricTests
    {
        [Fact]
        public void ShouldReturnOverlappingClaims()
        {
            var input = @"#1 @ 1,3: 4x4
#2 @ 3,1: 4x4
#3 @ 5,5: 2x2";

            var fabric = new Fabric();
            var overlapping = fabric.ProcessClaims(input);

            Assert.Equal(4, overlapping);
        }

        [Fact]
        public void ShouldFindNoneOverlappingClaimId()
        {
            var input = @"#1 @ 1,3: 4x4
#2 @ 3,1: 4x4
#3 @ 5,5: 2x2";

            var fabric = new Fabric();
            var overlapping = fabric.FindNoneOverlappingClaimId(input);

            Assert.Equal("3", overlapping);
        }
    }
}
