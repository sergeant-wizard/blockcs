using System.Collections.Generic;
using System.Linq;
namespace block
{
    public class Block
    {
        public Block()
        {
            positions.Add(new Position(Grid.MaxRows - 1, 4));
            positions.Add(new Position(Grid.MaxRows - 1, 5));
            positions.Add(new Position(Grid.MaxRows - 2, 4));
            positions.Add(new Position(Grid.MaxRows - 2, 5));
        }
        public bool OnDown(Grid grid)
        {
            return Update(grid, p => p.MoveDown());
        }
        public bool OnLeft(Grid grid)
        {
            return Update(grid, p => p.MoveLeft());
        }
        public bool OnRight(Grid grid)
        {
            return Update(grid, p => p.MoveRight());
        }
        private bool Update(Grid grid, System.Func<Position, Position> operation)
        {
            List<Position> newPositions = positions.Select(
                p => operation(p)
            ).ToList();
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
