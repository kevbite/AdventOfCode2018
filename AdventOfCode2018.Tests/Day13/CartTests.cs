using AdventOfCode2018.Day13;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace AdventOfCode2018.Tests.Day13
{
    public class CartTests
    {
        [Theory]
        [InlineData(CartDirection.Right, 2)]
        [InlineData(CartDirection.Left, 0)]
        public void ShouldMoveHorizontally(CartDirection direction, int expectedX)
        {
            var input = "---";

            var cart = new Cart(1, 0, direction);
            var movedCart = cart.Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(expectedX);
                movedCart.Y.Should().Be(0);
            }
        }

        [Theory]
        [InlineData(CartDirection.Down, 2)]
        [InlineData(CartDirection.Up, 0)]
        public void ShouldMoveVertically(CartDirection direction, int expectedY)
        {
            var input = @"|
|
|";

            var cart = new Cart(0, 1, direction);
            var movedCart = cart.Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(expectedY);
            }
        }


        [Fact]
        public void ShouldMoveAroundTopRightCornerFromRight()
        {
            var input = @"-\
 |";

            var cart = new Cart(0, 0, CartDirection.Right);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(1);
                movedCart.Y.Should().Be(1);
                movedCart.Direction.Should().Be(CartDirection.Down);
            }
        }

        [Fact]
        public void ShouldMoveAroundTopRightCornerFromUp()
        {
            var input = @"-\
 |";

            var cart = new Cart(1, 1, CartDirection.Up);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Left);
            }
        }

        [Fact]
        public void ShouldMoveAroundTopLeftCornerFromLeft()
        {
            var input = @"/-
| ";

            var cart = new Cart(1, 0, CartDirection.Left);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(1);
                movedCart.Direction.Should().Be(CartDirection.Down);
            }
        }

        [Fact]
        public void ShouldMoveAroundTopLeftCornerFromUp()
        {
            var input = @"/-
| ";

            var cart = new Cart(0, 1, CartDirection.Up);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(1);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Right);
            }
        }

        [Fact]
        public void ShouldMoveAroundBottomLeftCornerFromDown()
        {
            var input = @"|
\-";

            var cart = new Cart(0, 0, CartDirection.Down);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(1);
                movedCart.Y.Should().Be(1);
                movedCart.Direction.Should().Be(CartDirection.Right);
            }
        }


        [Fact]
        public void ShouldMoveAroundBottomLeftCornerFromLeft()
        {
            var input = @"|
\-";

            var cart = new Cart(1, 1, CartDirection.Left);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Up);
            }
        }

        [Fact]
        public void ShouldMoveAroundBottomRightCornerFromDown()
        {
            var input = @" |
-/";

            var cart = new Cart(1, 0, CartDirection.Down);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(1);
                movedCart.Direction.Should().Be(CartDirection.Left);
            }
        }

        [Fact]
        public void ShouldMoveAroundBottomRightCornerFromRight()
        {
            var input = @" |
-/";

            var cart = new Cart(0, 1, CartDirection.Right);
            var movedCart = cart.Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(1);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Up);
            }
        }

        [Fact]
        public void ShouldMoveCorrectOnIntersectionsFromRight()
        {
            var input = @"  +-
  + 
 ++ 
 +  
-+  ";

            var cart = new Cart(0, 4, CartDirection.Right);
            var movedCart = cart.Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(3);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Right);
            }
        }

        [Fact]
        public void ShouldMoveCorrectOnIntersectionsFromLeft()
        {
            var input = @"  +-
  + 
 ++ 
 +  
-+  ";

            var cart = new Cart(3, 0, CartDirection.Left);
            var movedCart = cart.Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(4);
                movedCart.Direction.Should().Be(CartDirection.Left);
            }
        }

        [Fact]
        public void ShouldMoveCorrectOnIntersectionsFromDown()
        {
            var input = @"|    
+++  
  +++
    |";

            var cart = new Cart(0, 0, CartDirection.Down);
            var movedCart = cart.Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(4);
                movedCart.Y.Should().Be(3);
                movedCart.Direction.Should().Be(CartDirection.Down);
            }
        }


        [Fact]
        public void ShouldMoveCorrectOnIntersectionsFromUp()
        {
            var input = @"|    
+++  
  +++
    |";

            var cart = new Cart(4, 3, CartDirection.Up);
            var movedCart = cart.Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input)
                .Move(input);

            using (new AssertionScope())
            {
                movedCart.X.Should().Be(0);
                movedCart.Y.Should().Be(0);
                movedCart.Direction.Should().Be(CartDirection.Up);
            }
        }
    }
}