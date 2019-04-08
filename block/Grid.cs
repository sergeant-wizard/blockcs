using System;
namespace block
{
    public class Grid
    {
        public Grid()
        {
        }
        public void Occupy(int row, int col)
        {
            isOccupied[row, col] = true;
        }
        public void Vacant(int row, int col)
        {
            isOccupied[row, col] = false;
        }
        public const int MaxRows = 20;
        public const int MaxCols = 10;
        private readonly bool[,] isOccupied = new bool[MaxRows, MaxCols];
    }
}
