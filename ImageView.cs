using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vichan_Image_Viewer
{
    public partial class ImageView : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        protected Point clickPosition;
        protected Point scrollPosition;
        protected int SizeX;
        protected int SizeY;

        public ImageView(string directory)
        {
            InitializeComponent();
            Image img = Image.FromFile(directory);
            ViewPicturebox.Image = img;
            ViewPicturebox.MouseMove += (sender, e) => pictureBox_MouseMove(sender, e, this.ViewPicturebox.Image);
            Width = (int)Math.Floor(Screen.PrimaryScreen.Bounds.Width * 0.5);
            Height = (int)Math.Floor((float)Width * 9 / 16)+100;

            SizeX = Width;
            SizeY = Height;

            ContainerPanel.Size = new Size(Width + 20, Height - 45);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.clickPosition.X = e.X;
            this.clickPosition.Y = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e, Image img)
        {
            if (e.Button == MouseButtons.Left)
            {
                scrollPosition.X = scrollPosition.X < img.Width ? scrollPosition.X + clickPosition.X - e.X : img.Width - 50;
                scrollPosition.Y = scrollPosition.Y < img.Height ? scrollPosition.Y + clickPosition.Y - e.Y : img.Height - 50;
                scrollPosition.X = scrollPosition.X < 0 ? 0 : scrollPosition.X;
                scrollPosition.Y = scrollPosition.Y < 0 ? 0 : scrollPosition.Y;


                this.ContainerPanel.AutoScrollPosition = scrollPosition;
            }
        }


        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void OpacityTrackbar_ValueChanged(object sender, EventArgs e)
        {
            Opacity = (float)OpacityTrackbar.Value/(float)100;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PinCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = PinCheckbox.Checked ? true : false;
        }

        private void SizeTrackbar_ValueChanged(object sender, EventArgs e)
        {
            Width = (int)Math.Floor((float)SizeX * SizeTrackbar.Value / 100);
            Height = (int)Math.Floor((float)SizeY * SizeTrackbar.Value / 100);
            ContainerPanel.Size = new Size(Width + 20, Height - 45);
        }
    }
}
