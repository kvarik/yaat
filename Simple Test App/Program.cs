using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using libYaAT;

namespace Simple_Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Window SimpleApp = new Window();
            SimpleApp.Title = "Simple Application";
            SimpleApp.Rename("OLOLO");
        }
    }
}
