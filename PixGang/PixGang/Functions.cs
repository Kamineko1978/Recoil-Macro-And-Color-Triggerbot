using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PixGang
{
    class Functions
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern long SetCursorPos(int x, int y);

        const int MOUSEEVENTF_MOVE = 0x0001;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;

        public static Color grabPixelData(Point position)
        {

            var bitmap = new Bitmap(1, 1);
            var graphics = Graphics.FromImage(bitmap);
            using (graphics)
            {
                graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                return bitmap.GetPixel(0, 0);
            }
        }

        public static void MouseMove(int x, int y)
        {
            mouse_event(MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
        }

        public static void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, UIntPtr.Zero);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, UIntPtr.Zero);
        }
    }
}
