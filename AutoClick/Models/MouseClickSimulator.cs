using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick.Models
{
    public class MouseClickSimulator
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Định nghĩa các cờ cho sự kiện chuột
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void SimulateLeftClick(int x, int y)
        {
            // Di chuyển con trỏ chuột đến vị trí mong muốn trước khi nhấp chuột
            Cursor.Position = new Point(x, y);

            // Simulate left mouse button down
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);

            // Simulate left mouse button up
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
