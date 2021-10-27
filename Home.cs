using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace Vichan_Image_Viewer
{
    public partial class Vichan : Form
    {
        public Vichan(string init = null)
        {
            InitializeComponent();
            ShowRecently(ReadRecently());
            if(init != null)
            {
                FormImageView(init);
            }
        }
        

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            string path = OpenBrowserDialogForImage();
            if(path != null)
            {
                FormImageView(path);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HoverRecently(object sender, EventArgs e, Panel container)
        {
            container.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void LeaveRecently(object sender, EventArgs e, Panel container)
        {
            container.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void ClickRecently(object sender, EventArgs e, String path)
        {
            if (File.Exists(path))
            {
                FormImageView(path);
            }
        }
        
        private string OpenBrowserDialogForImage()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image File Formats |*.png;*.jpg;*.tiff;*.jpeg;*.bmp;*.tif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    WriteRecently(ofd.FileName);
                    return ofd.FileName;
                }
            }
            return null;
        }
        private void WriteRecently(string input)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var SubFolderPath = Path.Combine(path, "SMoonKnight\\Vichan");

            Directory.CreateDirectory(SubFolderPath);

            if (File.Exists(input))
            {
                using (var sw = new StreamWriter(SubFolderPath + "\\recent", true))
                {
                    sw.WriteLine(input);
                }
                
            }
        }

        private string[] ReadRecently()
        {
            string[] RecentPaths;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var SubFolderPath = Path.Combine(path, "SMoonKnight\\Vichan");

            Directory.CreateDirectory(SubFolderPath);

            using (var sr = new StreamReader(SubFolderPath + "\\recent", true))
            {
                RecentPaths = sr.ReadToEnd().Split(new char[] { '\n','\r' }, StringSplitOptions.RemoveEmptyEntries);
                RecentPaths = RecentPaths.Distinct().ToArray();
            }

            return RecentPaths;
        }

        private void FormImageView(string path)
        {
            Form fr = new ImageView(path);
            fr.Show();
        }

        private void ShowRecently(string[] Paths)
        {
            var PathsRev = Paths.Reverse();
            foreach(string path in PathsRev)
            {
                Panel container = new Panel();
                container.Size = new Size(RecentFlowLayout.Width, 50);
                container.MouseHover += (sender, e) => HoverRecently(sender, e, container);
                container.MouseLeave += (sender, e) => LeaveRecently(sender, e, container);
                container.MouseClick += (sender, e) => ClickRecently(sender, e, path);
                RecentFlowLayout.Controls.Add(container);

                Panel LeftSide = new Panel();
                LeftSide.Size = new Size(200, 0);
                LeftSide.BackColor = Color.Transparent;
                LeftSide.Dock = DockStyle.Left;
                LeftSide.MouseHover += (sender, e) => HoverRecently(sender, e, container);
                LeftSide.MouseLeave += (sender, e) => LeaveRecently(sender, e, container);
                LeftSide.MouseClick += (sender, e) => ClickRecently(sender, e, path);

                container.Controls.Add(LeftSide);

                Panel RightSide = new Panel();
                RightSide.Size = new Size(200, 0);
                RightSide.BackColor = Color.Transparent;
                RightSide.Dock = DockStyle.Right;
                RightSide.MouseHover += (sender, e) => HoverRecently(sender, e, container);
                RightSide.MouseLeave += (sender, e) => LeaveRecently(sender, e, container);
                RightSide.MouseClick += (sender, e) => ClickRecently(sender, e, path);
                container.Controls.Add(RightSide);

                Label name = new Label();
                name.Text = Path.GetFileName(path);
                name.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
                name.ForeColor = Color.FromArgb(223, 230, 233);
                name.Dock = DockStyle.Top;
                name.MouseHover += (sender, e) => HoverRecently(sender, e, container);
                name.MouseLeave += (sender, e) => LeaveRecently(sender, e, container);
                name.MouseClick += (sender, e) => ClickRecently(sender, e, path);
                LeftSide.Controls.Add(name);

                Label directory = new Label();
                directory.Text = Path.GetDirectoryName(path);
                directory.Font = new Font("Century Gothic", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
                directory.ForeColor = Color.FromArgb(223, 230, 233);
                directory.Dock = DockStyle.Bottom;
                directory.MouseHover += (sender, e) => HoverRecently(sender, e, container);
                directory.MouseLeave += (sender, e) => LeaveRecently(sender, e, container);
                directory.MouseClick += (sender, e) => ClickRecently(sender, e, path);
                LeftSide.Controls.Add(directory);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(214, 48, 49);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(61, 61, 61);
        }
        private async void CaptureMyScreen()
        {
            this.WindowState = FormWindowState.Minimized;
            await Task.Delay(500);
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                bitmap.Save("C://screenshot.jpg", ImageFormat.Jpeg);
            }
            await Task.Delay(500);
            this.WindowState = FormWindowState.Normal;

            FormImageView("C://screenshot.jpg");
        }

        private void TakeScreenshotButton_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
        }
    }
}
