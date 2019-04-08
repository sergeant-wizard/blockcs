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
        public bool MoveRight()
        {
            if (col == Grid.MaxCols - 1)
            {
                return false;
            }
            else
            {
                col++;
                return true;
            }
        }
        public bool MoveLeft()
        {
            if (col == 0)
            {
                return false;
            }
            else
            {
                col--;
                return true;
            }
        }
        public bool MoveDown()
        {
            if (row == 0)
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
    }
}
