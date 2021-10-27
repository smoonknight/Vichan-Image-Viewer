
namespace Vichan_Image_Viewer
{
    partial class ImageView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpacityTrackbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeTrackbar = new System.Windows.Forms.TrackBar();
            this.PinCheckbox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ViewPicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrackbar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackbar)).BeginInit();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpacityTrackbar
            // 
            this.OpacityTrackbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpacityTrackbar.LargeChange = 1;
            this.OpacityTrackbar.Location = new System.Drawing.Point(0, 19);
            this.OpacityTrackbar.Maximum = 100;
            this.OpacityTrackbar.Minimum = 10;
            this.OpacityTrackbar.Name = "OpacityTrackbar";
            this.OpacityTrackbar.Size = new System.Drawing.Size(800, 45);
            this.OpacityTrackbar.TabIndex = 2;
            this.OpacityTrackbar.Value = 100;
            this.OpacityTrackbar.ValueChanged += new System.EventHandler(this.OpacityTrackbar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SizeTrackbar);
            this.panel1.Controls.Add(this.PinCheckbox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 19);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // SizeTrackbar
            // 
            this.SizeTrackbar.Location = new System.Drawing.Point(0, 0);
            this.SizeTrackbar.Maximum = 100;
            this.SizeTrackbar.Minimum = 50;
            this.SizeTrackbar.Name = "SizeTrackbar";
            this.SizeTrackbar.Size = new System.Drawing.Size(122, 45);
            this.SizeTrackbar.TabIndex = 4;
            this.SizeTrackbar.Value = 100;
            this.SizeTrackbar.ValueChanged += new System.EventHandler(this.SizeTrackbar_ValueChanged);
            // 
            // PinCheckbox
            // 
            this.PinCheckbox.AutoSize = true;
            this.PinCheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PinCheckbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PinCheckbox.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PinCheckbox.Location = new System.Drawing.Point(723, 0);
            this.PinCheckbox.Name = "PinCheckbox";
            this.PinCheckbox.Size = new System.Drawing.Size(47, 19);
            this.PinCheckbox.TabIndex = 3;
            this.PinCheckbox.Text = "Pin";
            this.PinCheckbox.UseVisualStyleBackColor = false;
            this.PinCheckbox.CheckedChanged += new System.EventHandler(this.PinCheckbox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(770, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 19);
            this.panel2.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ExitButton.Location = new System.Drawing.Point(780, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 19);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.AutoScroll = true;
            this.ContainerPanel.Controls.Add(this.ViewPicturebox);
            this.ContainerPanel.Location = new System.Drawing.Point(0, 65);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(800, 385);
            this.ContainerPanel.TabIndex = 4;
            // 
            // ViewPicturebox
            // 
            this.ViewPicturebox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ViewPicturebox.Location = new System.Drawing.Point(0, 0);
            this.ViewPicturebox.Name = "ViewPicturebox";
            this.ViewPicturebox.Size = new System.Drawing.Size(800, 386);
            this.ViewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ViewPicturebox.TabIndex = 5;
            this.ViewPicturebox.TabStop = false;
            this.ViewPicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.OpacityTrackbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImageView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageView";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.OpacityTrackbar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeTrackbar)).EndInit();
            this.ContainerPanel.ResumeLayout(false);
            this.ContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar OpacityTrackbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox PinCheckbox;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.PictureBox ViewPicturebox;
        private System.Windows.Forms.TrackBar SizeTrackbar;
        private System.Windows.Forms.Panel panel2;
    }
}