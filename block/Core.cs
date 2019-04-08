using System;
namespace block
{
    public class Core
    {
        public Core()
        {
        }
        public void StartCycle()
        {
            block = new Block();
        }
        public void Update()
        {
            block.Update();
        }
        private Grid grid;
        private Block block;
    }
}
