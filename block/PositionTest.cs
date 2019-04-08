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
            Assert.False(position.MoveLeft(grid));
            Assert.True(position.MoveRight(grid));
            Assert.False(position.MoveDown(grid));
        }
        [Test()]
        public void TestBottom()
        {
            Position position = new Position(Grid.MaxRows, Grid.MaxCols);
            Grid grid = new Grid();
            Assert.True(position.MoveLeft(grid));
            Assert.False(position.MoveRight(grid));
            Assert.True(position.MoveDown(grid));
        }
    }
}
