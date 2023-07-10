using System;
using System.IO;
using System.Net;

namespace NjOtter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.Title = "NjOtter CLI Enviornment";
            Console.WindowHeight = 800;
            Console.WindowWidth = 1000;
            string doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folpath = doc + "/NjOtter Saves";
            DirectoryInfo di = new DirectoryInfo(folpath);
            if (di.Exists == false)
            {
                di.Create();
            }
            Main main = new Main();
            main.Start();
        }
    }
}
