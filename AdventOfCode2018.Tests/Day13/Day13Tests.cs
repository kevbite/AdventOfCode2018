using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day13
{
    public class Day13Tests
    {
        [Fact]
        public void ShouldFindCrash1()
        {
            var input = @"|
v
|
|
|
^
|";
            var firstCrashLocation = new AdventOfCode2018.Day13.Day13().GetFirstCrashLocation(input);

            firstCrashLocation.Should().Be((0, 3));
        }

        [Fact]
        public void ShouldFindCrash2()
        {
            var input = @"/->-\        
|   |  /----\
| /-+--+-\  |
| | |  | v  |
\-+-/  \-+--/
  \------/   
";
            var firstCrashLocation = new AdventOfCode2018.Day13.Day13().GetFirstCrashLocation(input);

            firstCrashLocation.Should().Be((7, 3));
        }
    }
}






