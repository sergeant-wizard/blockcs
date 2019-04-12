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
        [Test()]
        public void TestRotation()
        {
            //  0123
            // 3##X#
            // 2#C##
            // 1####
            // 0####
            Position position = new Position(3, 2);
            Grid grid = new Grid();
            Assert.AreEqual(position.RotateLeft(new Position(3, 2)), position);
            Assert.AreEqual(position.RotateRight(new Position(3, 2)), position);
            Assert.AreEqual(position.RotateLeft(new Position(2, 1)), new Position(3, 0));
            Assert.AreEqual(position.RotateRight(new Position(2, 1)), new Position(1, 2));
        }
    }
}
