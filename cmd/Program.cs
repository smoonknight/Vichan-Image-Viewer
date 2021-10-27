using System;

namespace cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenCapture sc = new ScreenCapture();
            Image img = sc.CaptureScreen();
            this.imageDisplay.Image = img;
            sc.CaptureWindowToFile(this.Handle, "C:\\temp2.gif", ImageFormat.Gif);
            System.Diagnostics.Process.Start("Vichan Image Viewer.exe", "C:\\temp2.gif");
        }
    }
}
