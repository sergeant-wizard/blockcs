using NUnit.Framework;
using System;
namespace block
{
    [TestFixture()]
    public class PositionTest
    {
        [Test()]
        public void TestTop()
        {
            Position position = new Position(0, 0);
            Grid grid = new Grid();
            Assert.True(position.MoveLeft().IsOccupied(grid));
            Assert.False(position.MoveRight().IsOccupied(grid));
            Assert.True(position.MoveDown().IsOccupied(grid));
        }
        [Test()]
        public void TestBottom()
        {
            Position position = new Position(Grid.MaxRows - 1, Grid.MaxCols - 1);
            Grid grid = new Grid();
            Assert.True(position.MoveRight().IsOccupied(grid));
            Assert.False(position.MoveLeft().IsOccupied(grid));
            Assert.False(position.MoveDown().IsOccupied(grid));
        }
    }
}
