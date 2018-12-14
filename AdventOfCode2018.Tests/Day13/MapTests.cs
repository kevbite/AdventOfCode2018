using System;
using System.Collections.Immutable;
using System.Linq;
using AdventOfCode2018.Day13;
using FluentAssertions;
using FluentAssertions.Execution;
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
        public void ShouldReturnCrashedCarts1()
        {
            // --><--
            // 
            var crashed = new Cart(2, 0, CartDirection.Right);
            var crashedWith = new Cart(3, 0, CartDirection.Left);
            var expectedCrashed = new[]
            {
                crashed,
                crashedWith
            };
            var map = new Map(string.Join(Environment.NewLine, Enumerable.Repeat(new string(' ', 10), 10)), expectedCrashed);
            map = map.Tick();

            map.Carts.Should().BeEmpty();

            map.CrashedCart.Should().BeEquivalentTo(new Cart(3, 0, CartDirection.Right));

        }

        [Fact]
        public void ShouldReturnCrashedCarts2()
        {
            // v
            // |
            // ^
            // 
            var crashedWith = new Cart(0, 0, CartDirection.Down);
            var crashed = new Cart(0, 2, CartDirection.Up);
            var expectedCrashed = new[]
            {
                crashedWith,
                crashed
            };
            var map = new Map(string.Join(Environment.NewLine, Enumerable.Repeat(new string(' ', 10), 10)), expectedCrashed);
            map = map.Tick();


            map.CrashedCart.Should().BeEquivalentTo(new Cart(0, 1, CartDirection.Up));
            map.Carts.Should().BeEmpty();

        }

        [Fact]
        public void ShouldReturnCrashedCarts3()
        {
            //v>-<
            //|
            //^
            var track = @"|---
|   
|   ";
            
            var downCart = new Cart(0, 0, CartDirection.Down);
            var upCart = new Cart(0, 2, CartDirection.Up);
            var rightCart = new Cart(1, 0,CartDirection.Right);
            var leftCart = new Cart(3, 0, CartDirection.Left);
            var expectedCrashed = new[]
            {
                upCart, leftCart, rightCart, downCart
            };
            var map = new Map(string.Join(Environment.NewLine, Enumerable.Repeat(new string(' ', 10), 10)), expectedCrashed);
            map = map.Tick();

            using (new AssertionScope())
            {
                map.CrashedCart.Should().BeEquivalentTo(leftCart.Move(track));
                map.Carts.Should().BeEmpty();
            }
        }

        [Fact]
        public void ShouldMoveCarts()
        {
            var carts = new[]
            {
                new Cart(0, 0, CartDirection.Right),
                new Cart(2, 0, CartDirection.Right)
            };
            var map = new Map("----", carts);

            map = map.Tick();

            map.Carts.Should().BeEquivalentTo(new[]
            {
                new Cart(1, 0, CartDirection.Right),
                new Cart(3, 0, CartDirection.Right)
            });
        }
    }
}