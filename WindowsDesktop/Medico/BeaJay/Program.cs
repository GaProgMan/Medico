using System;
using Gtk;

namespace BeaJay
{
    // todo: Create GTK window code for MainWindow.cs
    public class Gui
    {
        public static void Main(string[] args)
        {
        }

        public void ShowGui()
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();
        }
    }
}
