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
            Assert.AreEqual(blk.Update(), 1);
        }
    }
}
