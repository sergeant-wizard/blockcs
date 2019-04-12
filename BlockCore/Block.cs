using System;
using System.Collections.Generic;
using System.Linq;
namespace block
{
    public class Block
    {
        public Block()
        {
            _blockType = BlockType.O;
            positions = new List<Position>(_initialPositions[_blockType]);
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
        public bool OnRotateRight(Grid grid)
        {
            return Rotate(grid, p => p.RotateRight(positions[0]));
        }
        public bool OnRotateLeft(Grid grid)
        {
            return Rotate(grid, p => p.RotateLeft(positions[0]));
        }
        private bool Rotate(Grid grid, Func<Position, Position> operation)
        {
            if (_blockType == BlockType.O)
            {
                return true;
            }
            else
            {
                return Update(grid, operation);
            }
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
        private enum BlockType {
            O, T, L, J, Z, S, I
        };
        BlockType _blockType;
        // TODO: rotation center is always at index 0
        private static Dictionary<BlockType, Position[]> _initialPositions = new Dictionary<BlockType, Position[]>()
        {
            { BlockType.O, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 2, 4),
                    new Position(Grid.MaxRows - 2, 5)
                }
            },
            { BlockType.T, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 1, 3),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 2, 4)
                }
            },
            { BlockType.L, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 1, 3),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 2, 3)
                }
            },
            { BlockType.J, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 1, 3),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 2, 5)
                }
            },
            { BlockType.Z, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 2, 5),
                    new Position(Grid.MaxRows - 2, 6)
                }
            },
            { BlockType.S, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 6),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 2, 4),
                    new Position(Grid.MaxRows - 2, 5)
                }
            },
            { BlockType.I, new Position[]
                {
                    new Position(Grid.MaxRows - 1, 4),
                    new Position(Grid.MaxRows - 1, 3),
                    new Position(Grid.MaxRows - 1, 5),
                    new Position(Grid.MaxRows - 1, 6)
                }
            },
        };
    }
}
