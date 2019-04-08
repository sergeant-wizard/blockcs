using System;
namespace block
{
    public class Position
    {
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public bool MoveRight(Grid grid)
        {
            if (col == Grid.MaxCols - 1 || grid.IsOccupied(row, col + 1))
            {
                return false;
            }
            else
            {
                col++;
                return true;
            }
        }
        public bool MoveLeft(Grid grid)
        {
            if (col == 0 || grid.IsOccupied(row, col - 1))
            {
                return false;
            }
            else
            {
                col--;
                return true;
            }
        }
        public bool MoveDown(Grid grid)
        {
            if (row == 0 || grid.IsOccupied(row - 1, col))
            {
                return false;
            }
            else
            {
                row--;
                return true;
            }
        }
        private int row;
        private int col;

        public int Row { get => row; }
        public int Col { get => col; }
    }
}
