using LightBulbInstance.Properties;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LightBulbInstance
{
    public partial class Form1 : Form
    {
        public const int HTCAPTION = 0x2;

        public const int WM_NCLBUTTONDOWN = 0xA1;

        private int _currentValue = 0;

        public Form1(string place, int port)
        {
            if (string.IsNullOrEmpty(place)) throw new ArgumentException(nameof(place));
            InitializeComponent();
            this.lblCurrentValue.Text = place + " : " + port;
        }

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void cmdDestroy_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void cmdDown_Click(object sender, EventArgs e)
        {
            if (_currentValue > 0)
            {
                _currentValue--;
            }
            Program.InstanceValue = _currentValue;
            UpdateBulbImage();
        }

        private void cmdUp_Click(object sender, EventArgs e)
        {
            if (_currentValue < 10)
            {
                _currentValue++;
            }
            Program.InstanceValue = _currentValue;
            UpdateBulbImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(100, 100);
            this.TransparencyKey = Color.FromArgb(0, 255, 0); //Contrast Color
            this.moveFormPanel.BackColor = Color.FromArgb(25, Color.Black);
            UpdateBulbImage();
        }

        private void moveFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void UpdateBulbImage()
        {
            var rm = Resources.ResourceManager;
            var currentBulb = (Bitmap)rm.GetObject($"b{_currentValue}");
            this.BackgroundImage = currentBulb;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            _currentValue = Convert.ToInt32(Program.InstanceValue * 10);
            UpdateBulbImage();
        }
    }
}