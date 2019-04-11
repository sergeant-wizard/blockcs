using System;
namespace block
{
    public class Core
    {
        public Core(IRenderer renderer)
        {
            this._renderer = renderer;
        }
        public void StartCycle()
        {
            block = new Block();
        }
        public void Render()
        {
            _renderer.RenderOccupied(grid);
            _renderer.RenderFalling(block);
        }
        public void OnDown()
        {
            bool isUpdated = block.Update(grid);
            if (!isUpdated)
            {
                block.Land(grid);
                grid.Update();
                StartCycle();
            }
            Render();
        }
        public void Update()
        {
            OnDown();
        }
        private Grid grid = new Grid();
        private Block block;
        private IRenderer _renderer;
    }
}
