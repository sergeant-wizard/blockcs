using NUnit.Framework;

namespace block
{
    [TestFixture()]
    public class BlockTest
    {
        [Test()]
        public void TestUpdate()
        {
            Block blk = new Block();
            Grid grid = new Grid();
            for (int i = 0; i < Grid.MaxRows - 2; i++)
            {
                Assert.True(blk.OnDown(grid));
            }
            Assert.False(blk.OnDown(grid));

            blk.Land(grid);
            Assert.True(grid.IsOccupied(0, 4));
            Assert.True(grid.IsOccupied(0, 5));
            Assert.True(grid.IsOccupied(1, 4));
            Assert.True(grid.IsOccupied(1, 5));
        }
    }
}
