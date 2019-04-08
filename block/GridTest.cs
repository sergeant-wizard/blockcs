using NUnit.Framework;
using System;
namespace block
{
    [TestFixture()]
    public class GridTest
    {
        [Test()]
        public void TestCase()
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
    }
}
