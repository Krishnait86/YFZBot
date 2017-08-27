using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using InputManager;

namespace YFBot
{
    public partial class MainForm : Form
    {
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

        public MainForm()
        {
            InitializeComponent();
            LogicListBox.SelectedIndex = 1;
            strategy = new Strategy();
            watch = new Stopwatch();

            active = false;
            fwd = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            switch (buttonAction.Text)
            {
                case "Stop":
                    active = false;
                    buttonAction.Text = "Start";
                    break;
                case "Start":
                    try {
                        weaponTimer = Int32.Parse(maskedTextBox.Text);
                        progressWeapon.Maximum = weaponTimer - 1;
                    }
                    catch (FormatException) {
                        weaponTimer = 0;
                        progressWeapon.Maximum = weaponTimer + 1;
                    }
                    

                    processList = Process.GetProcesses();
                    foreach (Process instence in processList)
                    {
                        if (instence.ProcessName.Contains("Crossout"))
                        {
                            targetProcess = instence;
                            toolGameFindStatus.Text = "Looking for: " + targetProcess.MainWindowTitle;
                            SetForegroundWindow(targetProcess.MainWindowHandle);
                            active = true;
                        }
                    }
                    timer.Enabled = true;
                    buttonAction.Text = "Stop";
                    break;
            }
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            watch.Start();
            timer.Enabled = false;

            while (active && GetForegroundWindow() == targetProcess.MainWindowHandle)
            {
                maskedTextBox.Enabled = false;
                LogicListBox.Enabled = false;

                switch (LogicListBox.SelectedItem)
                {
                    case "attackLogic":
                        fwd = await strategy.attackLogic(fwd);
                        break;
                    case "defendLogic":
                        fwd = await strategy.defendLogic();
                        break;
                }
                toolGameFindStatus.Text = targetProcess.MainWindowTitle;
            }

            watch.Stop();
            timer.Enabled = true;
            toolGameFindStatus.Text = "Waiting for process...";
            maskedTextBox.Enabled = true;
            LogicListBox.Enabled = true;
        }

        private void timerWeapon_Tick(object sender, EventArgs e)
        {
            if (active && weaponTimer > 0)
            {
                int cooldown = (int)(watch.ElapsedMilliseconds / 1000) % weaponTimer;

                progressWeapon.Value = cooldown;
                if (weaponTimer > 0 && cooldown == 0)
                {
                    Keyboard.KeyDown(Keys.D1);
                    Keyboard.KeyUp(Keys.D1);
                }
            }
        }
    }
}