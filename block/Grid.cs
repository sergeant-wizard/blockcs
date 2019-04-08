using System.Collections.Generic;
namespace block
{
    public class Grid
    {
        public Grid()
        {
            AddRows();
        }
        private void AddRows()
        {
            while (isOccupied.Count < MaxRows)
            {
                isOccupied.Add(NewRow());
            }
        }
        private List<bool> NewRow()
        {
            return new List<bool>(new bool[MaxCols]);
        }
        public void Occupy(Position position)
        {
            isOccupied[position.Row][position.Col] = true;
        }
        public void Vacant(Position position)
        {
            isOccupied[position.Row][position.Col] = false;
        }
        public void Update()
        {
            isOccupied.RemoveAll(row => row.TrueForAll(col => col));
            AddRows();
        }
        public const int MaxRows = 20;
        public const int MaxCols = 10;
        private readonly List<List<bool>> isOccupied = new List<List<bool>>(MaxRows);

        public bool IsOccupied(int row, int col)
        {
            return isOccupied[row][col];
        }
    }
}
