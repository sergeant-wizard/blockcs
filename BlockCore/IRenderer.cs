using System;
namespace block
{
    public interface IRenderer
    {
        void RenderOccupied(Grid grid);
        void RenderFalling(Block block);
    }
}
