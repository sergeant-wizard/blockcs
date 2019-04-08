using NUnit.Framework;

namespace block
{
    [TestFixture()]
    public class BlockTest
    {
        public class Hoge
        {
            public Hoge()
            {
            }
            public Hoge(Hoge other)
            {
                System.Console.Write("copied");
            }
        }
        public void SomeMethod(Hoge hoge)
        {
            // System.Console.Write("something");
        }

        [Test()]
        public void TestCase()
        {
            var hoge1 = new Hoge();
            var hoge2 = new Hoge();
            System.Collections.Generic.List<Hoge> hoge = new System.Collections.Generic.List<Hoge>(new Hoge[] { hoge1, hoge2 });
            hoge.Remove(hoge1);
            hoge.Remove(hoge2);
            System.Console.Write(hoge.Count);
            SomeMethod(new Hoge());
            Block blk = new Block();
            Grid grid = new Grid();
            for (int i = 0; i < Grid.MaxRows - 1; i++)
            {
                Assert.True(blk.Update(grid));
            }
            Assert.False(blk.Update(grid));
        }
    }
}
