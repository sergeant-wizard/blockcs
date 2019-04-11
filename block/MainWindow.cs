using System;
using Gdk;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        _renderer = new block.GTKRenderer(this.table1);
        _core = new block.Core(_renderer);
        _core.StartCycle();
        _core.Render();
    }

    protected override bool OnKeyPressEvent(EventKey evnt)
    {
        switch (evnt.Key)
        {
            case Gdk.Key.Down:
                _core.OnDown();
                break;
            case Gdk.Key.Left:
                _core.OnLeft();
                break;
            case Gdk.Key.Right:
                _core.OnRight();
                break;
            // nice left hand positions for dvorak
            case Gdk.Key.j:
                _core.OnRotateRight();
                break;
            case Gdk.Key.q:
                _core.OnRotateLeft();
                break;
        }

        return base.OnKeyPressEvent(evnt);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
    block.GTKRenderer _renderer;
    block.Core _core;
}
