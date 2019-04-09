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
            bool isUpdated = block.Update(grid);
            if (isUpdated)
            {
                block.Land(grid);
            }
        }
        private Grid grid = new Grid();
        private Block block;
    }
}
