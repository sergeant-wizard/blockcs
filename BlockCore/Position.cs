using System;
namespace block
{
    public struct Position
    {
        public Position(Position other)
        {
            _row = other._row;
            _col = other._col;
        }
        public Position(int row, int col)
        {
            this._row = row;
            this._col = col;
        }
        public Position MoveRight()
        {
            return new Position(_row, _col + 1);
        }
        public Position MoveLeft()
        {
            return new Position(_row, _col - 1);
        }
        public Position MoveDown()
        {
            return new Position(_row - 1, _col);
        }
        public Position RotateRight(Position center)
        {
            int diffX = _row - center.Row;
            int diffY = _col - center.Col;
            return new Position(center.Row - diffY, center.Col + diffX);
        }
        public Position RotateLeft(Position center)
        {
            int diffX = _row - center.Row;
            int diffY = _col - center.Col;
            return new Position(center.Row + diffY, center.Col - diffX);
        }
        public bool IsOccupied(Grid grid)
        {
            return grid.IsOccupied(_row, _col);
        }
        private int _row;
        private int _col;

        public int Row { get => _row; }
        public int Col { get => _col; }
    }
}
