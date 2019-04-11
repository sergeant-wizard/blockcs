using System.Collections.Generic;
namespace block
{
    public class GTKRenderer: IRenderer
    {
        public GTKRenderer(Gtk.Table table)
        {
            this._table = table;
            foreach (Position position in Positions())
            {
                Gtk.Button button = new Gtk.Button();
                _buttonMap.Add(position, button);
                table.Attach(
                    button,
                    (uint)(position.Col),
                    (uint)(position.Col + 1),
                    (uint)(Grid.MaxRows - position.Row - 1),
                    (uint)(Grid.MaxRows - position.Row)
                );
                ChangeColor(position, "red");
            }
        }
        private void ChangeColor(Position position, string color)
        {
            Gdk.Color _color = new Gdk.Color();
            Gdk.Color.Parse(color, ref _color);
            _buttonMap[position].ModifyBg(Gtk.StateType.Normal, _color);
            _buttonMap[position].Show();
        }
        public void RenderOccupied(Grid grid)
        {
            foreach (Position position in Positions())
            {
                if (position.IsOccupied(grid))
                {
                    ChangeColor(position, "gray");
                }
                else
                {
                    ChangeColor(position, "white");
                }
            }
        }
        public void RenderFalling(Block block)
        {
            foreach (Position position in block.Positions)
            {
                ChangeColor(position, "red");
            }
        }
        private static IEnumerable<Position> Positions()
        {
            for (int row = 0; row < Grid.MaxRows; row++)
            {
                for (int col = 0; col < Grid.MaxCols; col++)
                {
                    yield return new Position(row, col);
                }
            }
        }
        private Gtk.Table _table;
        private Dictionary<Position, Gtk.Button> _buttonMap = new Dictionary<Position, Gtk.Button>();
    }
}
