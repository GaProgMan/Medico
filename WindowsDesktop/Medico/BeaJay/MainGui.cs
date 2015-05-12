using System;

namespace BeaJay
{
    public partial class MainGui : Gtk.Window
    {
        public MainGui()
            : base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}

