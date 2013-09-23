using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace libYaAT
{
    public class Window
    {
        private static IntPtr hWnd;

        private static string title;
        public string Title 
        {
            get 
            {
                return title;
            }
            set
            {
                hWnd = FindWindow(null, value);
                title = value;
            }
        }

        public static IntPtr Handler
        {
            get
            {
                return hWnd;
            }
            
        }

        // user32.dll imports
        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        static extern bool SetWindowText(IntPtr hWnd, string text);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);
            
        public Window()
        {
            
        }

        public Window(string title)
        {
            this.Title = title;
        }

        public bool Rename(string text)
        {
            title = text;
            return SetWindowText(hWnd, text);
        }

        

    }
}
    