using NUnit.Framework;
using System;
namespace block
{
    class Hoge
    {
        int _x = 0;
        public Hoge()
        {
            Console.Write("created");
        }
        ~Hoge()
        {
            Console.Write("destroyed");
        }
        public ref int Get()
        {
            return ref _x;
        }
    }
    [TestFixture()]
    public class GridTest
    {
        [Test()]
        public void TestCase()
        {
            ref int foo()
            {
                Hoge hoge = new Hoge();
                return ref hoge.Get();
            }
            Console.Write("before foo");
            foo();
            Console.Write("after foo");
            foo();
        }
    }
}
