using System.Collections.Generic;
using System.Linq;
namespace block
{
    public class Block
    {
        public Block()
        {
            positions.Add(new Position(Grid.MaxRows - 1, 3));
            positions.Add(new Position(Grid.MaxRows - 1, 4));
            positions.Add(new Position(Grid.MaxRows - 2, 3));
            positions.Add(new Position(Grid.MaxRows - 2, 4));
        }
        public bool Update(Grid grid)
        {
            List<Position> newPositions = positions.Select(
            p => p.MoveDown()).ToList();
            bool violation = newPositions.Any(p => p.IsOccupied(grid));
            if (violation)
            {
                return false;
            }
            else
            {
                positions = newPositions;
                return true;
            }
        }
        public void Land(Grid grid)
        {
            positions.ForEach(grid.Occupy);
        }
        private List<Position> positions = new List<Position>();
        public const int NumBlocks = 4;

        public List<Position> Positions { get => positions; }
    }
}
