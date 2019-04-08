using NUnit.Framework;

namespace block
{
    [TestFixture()]
    public class BlockTest
    {
        [Test()]
        public void TestCase()
        {
            Block blk = new Block();
            for (int i = 0; i < Grid.MaxRows - 1; i++)
            {
                Assert.True(blk.Update());
            }
            Assert.False(blk.Update());
        }
    }
}
