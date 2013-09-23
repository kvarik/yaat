using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace libYaAT
{
    class Button
    {
        private IntPtr handler;
        private IntPtr parenthandler;
        private string text;

        public IntPtr Handler
        {
            get
            {
                return handler;
            }
        }

        public IntPtr ParentWindowHandler
        {
            get
            {
                return parenthandler;
            }
        }

        //user32.dll imports
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        public Button(IntPtr parentHandle, string text)
        {
            handler = FindWindowEx(parentHandle, IntPtr.Zero, "BUTTON", text);
        }


    }
}
