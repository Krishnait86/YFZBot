using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using InputManager;
using YFBot.Capture;

namespace YFBot {
    public partial class MainForm : Form {
        public Process[] processList { get; set; }
        public Process targetProcess;

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        private int weaponTimer;
        private Stopwatch watch;

        private bool fwd;
        private bool active;

        Strategy strategy;

        private CaptureForm captureForm;

        public MainForm() {
            InitializeComponent();
            LogicListBox.SelectedIndex = 1;
            strategy = new Strategy();
            watch = new Stopwatch();
            captureForm = new CaptureForm();

            active = false;

            fwd = true;
        }

        private void buttonStart_Click(object sender, EventArgs e) {

            weaponTimer = Int32.Parse(timerTextBox.Text);
            
            processList = Process.GetProcesses();
            foreach (Process instence in processList)
            {

                if (instence.ProcessName.Contains("Crossout"))
                {
                    targetProcess = instence;                    
                    SetForegroundWindow(targetProcess.MainWindowHandle);
                    active = true;
                }
            }
            
            timer.Enabled = true;

            buttonStart.Visible = false;
            buttonStop.Visible = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = true;
            active = false;
            buttonStop.Visible = false;
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            while (active && GetForegroundWindow() == targetProcess.MainWindowHandle)
            {
                timerTextBox.Enabled = false;


                //if ( weaponTimer > 0 && (int)(watch.ElapsedMilliseconds/1000) % weaponTimer == 0)
                //{
                //    Keyboard.KeyDown(Keys.D1);
                //    Keyboard.KeyUp(Keys.D1);
                //}

                // switch(LogicListBox.SelectedItem)
                // {
                //     case "attackLogic":
                //         fwd = await strategy.attackLogic(fwd);
                //         break;
                //     case "defendLogic":
                //         fwd = await strategy.defendLogic();
                //         break;
                // }
                // toolGameFindStatus.Text = targetProcess.MainWindowTitle;

                await Task.Delay(100);
            }

            timer.Enabled = true;
            toolGameFindStatus.Text = "Waiting process...";
            timerTextBox.Enabled = true;
        }

        private void openCaptureWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!captureForm.Visible) {
                captureForm.Show();
                captureForm.targetProcess = targetProcess;
            }            
        }
    }
}
