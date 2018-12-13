using System.Collections.Immutable;
using System.Linq;
using AdventOfCode2018.Day13;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2018.Tests.Day13
{
    public class MapTests
    {
        [Fact]
        public void ShouldRenderTracks()
        {
            var input = @"/----\
|    |
|    |
\----/";

            var foo = Map.Parse(input);

            foo.Tracks.Should().Be(input);
        }

        [Fact]
        public void ShouldRenderTracksWithACartHorizontallyOnTheTrack()
        {
            var input = "->->--<-<-";

            var foo = Map.Parse(input);

            foo.Tracks.Should().Be("----------");
        }


        [Fact]
        public void ShouldRenderTracksWithACartsVerticallyOnTheTrack()
        {
            var input = @"|
v
|
^
|";

            var foo = Map.Parse(input);

            foo.Tracks.Should().Be(@"|
|
|
|
|");
        }

        [Fact]
        public void ShouldContainCartsHorizontallyInCorrectPosition()
        {
            var input = "->->--<-<-";

            var foo = Map.Parse(input);

            foo.Carts.Should().BeEquivalentTo(new[]
            {
                new Cart(1, 0, CartDirection.Right),
                new Cart(3, 0, CartDirection.Right),
                new Cart(6, 0, CartDirection.Left),
                new Cart(8, 0, CartDirection.Left),
            });
        }

        [Fact]
        public void ShouldContainCartsVerticallyInCorrectPosition()
        {
            var input = @"|
v
|
^
|";

            var foo = Map.Parse(input);

            foo.Carts.Should().BeEquivalentTo(new[]
            {
                new Cart(0, 1, CartDirection.Down),
                new Cart(0, 3, CartDirection.Up)
            });
        }

        [Fact]
        public void ShouldReturnCrashedCarts()
        {
            var expectedCrashed = new[]
            {
                new Cart(1, 2, CartDirection.Down),
                new Cart(1, 2, CartDirection.Up)
            };
            var carts = new []
            {
                new Cart(2,2, CartDirection.Up),
                new Cart(3,3, CartDirection.Left),
                new Cart(4,5, CartDirection.Right),
            }.Concat(expectedCrashed).ToImmutableArray();

            var map = new Map("", carts);

            var crashedCarts = map.GetCrashedCarts();

            crashedCarts.Should().BeEquivalentTo(expectedCrashed);
        }

        [Fact]
        public void ShouldMoveCarts()
        {
            var carts = new[]
            {
                new Cart(0, 0, CartDirection.Right),
                new Cart(1, 0, CartDirection.Right)
            };
            var map = new Map("--", carts);

            map = map.Tick();

            map.Carts.Should().BeEquivalentTo(new[]
            {
                new Cart(1, 0, CartDirection.Right),
                new Cart(2, 0, CartDirection.Right)
            });
        }
    }
}