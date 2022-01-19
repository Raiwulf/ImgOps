using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImgFinder
{
    class winH
    {
        public string wiName;
        public winH(string _wiName) {
            this.wiName = _wiName;
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public IntPtr wHandle()
        {
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName(this.wiName);
            if (p.Length > 0)
            {
                SetForegroundWindow(p[0].MainWindowHandle);
                return p[0].MainWindowHandle;
            }
            return IntPtr.Zero;
        }
    }
}
