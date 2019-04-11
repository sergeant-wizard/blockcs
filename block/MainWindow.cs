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
        if (evnt.Key == Gdk.Key.Down)
        {
            _core.OnDown();
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
