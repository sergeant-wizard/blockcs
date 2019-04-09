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
                Assert.True(blk.Update(grid));
            }
            Assert.False(blk.Update(grid));

            blk.Land(grid);
            Assert.True(grid.IsOccupied(0, 3));
            Assert.True(grid.IsOccupied(0, 4));
            Assert.True(grid.IsOccupied(1, 3));
            Assert.True(grid.IsOccupied(1, 4));
        }
    }
}
