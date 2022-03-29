using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace POS
{
    static class TheControl
    {
        static bool isMax = false, isFull = false;
        static Point old_loc, default_loc;
        static Size old_size, default_size;

        public static void SetInitials(Window win)
        {
            old_size = new Size(win.Width, win.Height);
            old_loc = new Point(win.Top, win.Left);
            default_size = new Size(win.Width, win.Height);
            default_loc = new Point(win.Top, win.Left);
        }

        public static void FullScreen(Window win)
        {
            if (win.WindowState == WindowState.Normal)
                win.WindowState = WindowState.Maximized;
            else
                win.WindowState = WindowState.Normal;
        }

    }
}
