using NUnit.Framework;
using System;
namespace block
{
    [TestFixture()]
    public class GridTest
    {
        [Test()]
        public void TestRemoveRow()
        {
            Grid grid = new Grid();
            for (int col = 0; col < Grid.MaxCols; col++)
            {
                Position position = new Position(0, col);
                grid.Occupy(position);
            }
            grid.Occupy(new Position(1, 0));
            grid.Update();

            Assert.True(grid.IsOccupied(0, 0));
            Assert.False(grid.IsOccupied(0, 1));
        }
        [Test()]
        public void TestIsOccupied()
        {
            Grid grid = new Grid();
            Assert.True(grid.IsOccupied(-1, 1));
            Assert.True(grid.IsOccupied(0, Grid.MaxCols));
            Assert.True(grid.IsOccupied(0, -1));
            Assert.False(grid.IsOccupied(0, 0));
        }
    }
}
