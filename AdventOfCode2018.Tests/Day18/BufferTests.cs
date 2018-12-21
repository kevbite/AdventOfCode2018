using AdventOfCode2018.Day18;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day18
{
    public class BufferTests
    {
        [Fact]
        public void ShouldBufferGivenValues()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(1);
            buffer.Add(2);
            buffer.Add(3);
            buffer.Add(4);

            buffer.Should().BeEquivalentTo(new []
            {
                2,3,4
            });
        }

        [Fact]
        public void ShouldAllPositiveCorrelate()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(1);
            buffer.Add(2);
            buffer.Add(3);

            buffer.AllPositivelyCorrelate().Should().BeTrue();
        }

        [Fact]
        public void AllNegativelyCorrelate()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(3);
            buffer.Add(2);
            buffer.Add(1);

            buffer.AllNegativelyCorrelate().Should().BeTrue();
        }

        [Fact]
        public void ShouldNotAllPositiveCorrelate()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(1);
            buffer.Add(3);
            buffer.Add(2);

            buffer.AllPositivelyCorrelate().Should().BeFalse();
        }

        [Fact]
        public void AllNotNegativelyCorrelate()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(2);
            buffer.Add(3);
            buffer.Add(1);

            buffer.AllNegativelyCorrelate().Should().BeFalse();
        }

        [Fact]
        public void ShouldNotAllPositiveCorrelateForNotMaxCapacity()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(1);
            buffer.Add(2);

            buffer.AllPositivelyCorrelate().Should().BeFalse();
        }

        [Fact]
        public void AllNotNegativelyCorrelateForNotMaxCapacity()
        {
            var buffer = new Buffer<int>(3);
            buffer.Add(3);
            buffer.Add(2);

            buffer.AllNegativelyCorrelate().Should().BeFalse();
        }
    }
}
