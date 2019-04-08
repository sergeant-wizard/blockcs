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
            Position grid = new Position(0, 0);
            Assert.False(grid.MoveLeft());
            Assert.True(grid.MoveRight());
            Assert.False(grid.MoveDown());
        }
        [Test()]
        public void TestBottom()
        {
            Position grid = new Position(Grid.MaxRows, Grid.MaxCols);
            Assert.True(grid.MoveLeft());
            Assert.False(grid.MoveRight());
            Assert.True(grid.MoveDown());
        }
    }
}
