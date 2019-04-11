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
            bool isUpdated = block.OnDown(grid);
            if (!isUpdated)
            {
                block.Land(grid);
                grid.Update();
                StartCycle();
            }
            Render();
        }
        public void OnLeft()
        {
            block.OnLeft(grid);
            Render();
        }
        public void OnRight()
        {
            block.OnRight(grid);
            Render();
        }
        public void OnRotateRight()
        {
            block.OnRotateRight(grid);
            Render();
        }
        public void OnRotateLeft()
        {
            block.OnRotateLeft(grid);
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
