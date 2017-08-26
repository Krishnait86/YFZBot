using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using InputManager;

namespace YFBot {
    public partial class MainForm : Form {
        public Process[] processList { get; set; }

        public Process targetProcess;

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        private int weaponTimer;
        private int Timer;
        private Stopwatch watch;

        private bool fwd = true;

        private bool rgt = true;

        Strategy strategy;

        public MainForm() {
            InitializeComponent();
            LogicListBox.SelectedIndex = 1;
            strategy = new Strategy();
            watch = new Stopwatch();
        }

        private void buttonGetProcesses_Click(object sender, EventArgs e) {

            checkBox.Checked = true;
            processList = Process.GetProcesses();
            foreach (Process instence in processList)
            {

                if (instence.ProcessName.Contains("Crossout") && checkBox.Checked)
                {
                    targetProcess = instence;
                }
            }

            labelInfo.Text = "Game: " + targetProcess.MainWindowTitle;
        }

        private void buttonStart_Click(object sender, EventArgs e) {

            weaponTimer = Int32.Parse(textBox1.Text);
            checkBox.Checked = true;
            processList = Process.GetProcesses();
            foreach (Process instence in processList)
            {

                if (instence.ProcessName.Contains("Crossout") && checkBox.Checked)
                {
                    targetProcess = instence;
                }
            }

            labelInfo.Text = "Game: " + targetProcess.MainWindowTitle;

            SetForegroundWindow(targetProcess.MainWindowHandle);
            timer.Enabled = true;
            checkBox.Checked = true;

            buttonStart.Visible = false;
            buttonStop.Visible = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            checkBox.Checked = false;
            buttonStop.Visible = false;
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            while (checkBox.Checked &&
                    GetForegroundWindow() == targetProcess.MainWindowHandle)
            {
                if ((int)(watch.ElapsedMilliseconds/1000) % weaponTimer == 0)
                {
                    Keyboard.KeyDown(Keys.D1);
                    Keyboard.KeyUp(Keys.D1);
                }

                switch(LogicListBox.SelectedItem)
                {
                    case "attackLogic":
                        fwd = await strategy.attackLogic(fwd);
                        break;
                    case "defendLogic":
                        fwd = await strategy.defendLogic();
                        break;
                }
            }

            timer.Enabled = true;
        }

        
    }
}
