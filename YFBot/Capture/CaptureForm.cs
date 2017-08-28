using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;

using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace YFBot.Capture {
    public partial class CaptureForm : Form {
        public Process targetProcess { get; set; }
        private Tesseract _ocr;



        public CaptureForm() {
            InitializeComponent();

            //// делаем рабочую областьо окна прозрачной
            //AllowTransparency = true;
            //BackColor = Color.Green;
            //TransparencyKey = BackColor;
        }


        // при нажатии на кнопку закрыть окно, просто скрываем его
        private void CaptureForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            Hide();
        }

        private void timer_Tick(object sender, EventArgs e) {
            if (targetProcess != null) {
                Bitmap bmp;

                Image<Bgr, byte> _imgInput = new Image<Bgr, byte>(CaptureApplication(targetProcess));

                Image<Gray, byte> _imgCanny = new Image<Gray, byte>(_imgInput.Width, _imgInput.Height, new Gray(0));
                _imgCanny = _imgInput.Canny(/*Double.Parse(textBox1.Text)*/ 150,
                                            /*Double.Parse(textBox2.Text)*/ 150);
                bmp = _imgCanny.Bitmap;

              
                // Решение проблемы с утечкой GDI
                if (captureBox.Image != null)
                    captureBox.Image.Dispose();
                captureBox.Image = new Bitmap(bmp, new Size((int)(bmp.Width * .9), (int)(bmp.Height * .9)));

                Height = captureBox.Image.Height + 36;
                Width = captureBox.Image.Width + 14;

                _imgInput.Dispose();
                bmp.Dispose();
            }
        }



        public Bitmap CaptureApplication(Process proc) {
            User32.Rect rect = new User32.Rect();
            User32.GetWindowRect(proc.MainWindowHandle, ref rect);

            int width = rect.right - rect.left;
            int height = rect.bottom - rect.top;

            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

            // Решение проблемы с утечкой GDI
            graphics.Dispose();
            return bmp;
        }

        private class User32 {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }   
    }
}
