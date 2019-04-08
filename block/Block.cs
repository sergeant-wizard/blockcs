﻿using System.Collections.Generic;
namespace block
{
    public class Block
    {
        public Block()
        {
            positions.Add(new Position(Grid.MaxRows, 3));
            positions.Add(new Position(Grid.MaxRows, 4));
            positions.Add(new Position(Grid.MaxRows - 1, 3));
            positions.Add(new Position(Grid.MaxRows - 1, 4));
        }
        public bool Update(Grid grid)
        {
            return positions.TrueForAll(p => p.MoveDown(grid));
        }
        public void Land(Grid grid)
        {
            positions.ForEach(grid.Occupy);
        }
        private List<Position> positions = new List<Position>();
        public const int NumBlocks = 4;
    }
}
