using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using InputManager;
using System.IO;
using System.Threading.Tasks;

namespace YFBot
{
    public partial class MainForm : Form
    {
        AboutBox aboutBox;

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

        private Strategy strategy;
        private string scriptFileName;
        private ScriptWorker.ScriptWorker scriptWorker;
        int cooldown = 0;

        public MainForm()
        {
            InitializeComponent();
            LogicListBox.SelectedIndex = 1;
            strategy = new Strategy();
            watch = new Stopwatch();
            scriptWorker = new ScriptWorker.ScriptWorker();

            active = false;
            fwd = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            switch (buttonAction.Text)
            {
                case "Stop":
                    watch.Stop();
                    active = false;
                    buttonAction.Text = "Start";
                    break;
                case "Start":
                    if (scriptFileName != null)
                        scriptWorker.FileName = scriptFileName;


                    try { weaponTimer = Int32.Parse(maskedTextBox.Text); }
                    catch (FormatException) { weaponTimer = 0; }

                    try
                    {
                        weaponTimer = Int32.Parse(maskedTextBox.Text);
                        progressWeapon.Maximum = weaponTimer - 1;
                    }
                    catch (FormatException)
                    {
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
                    watch.Start();
                    timer.Enabled = true;
                    buttonAction.Text = "Stop";
                    break;
            }
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            while (active && GetForegroundWindow() == targetProcess.MainWindowHandle)
            {
                maskedTextBox.Enabled = false;
                LogicListBox.Enabled = false;

                switch (LogicListBox.SelectedItem)
                {
                    case "сruiseLogic":
                        fwd = await strategy.cruiseLogic();
                        break;
                    case "defendLogic":
                        fwd = await strategy.defendLogic();
                        break;
                    case "customScript":
                        fwd = await scriptWorker.LoadScript();
                        break;
                }
                toolGameFindStatus.Text = targetProcess.MainWindowTitle;
            }
            
            timer.Enabled = true;
            toolGameFindStatus.Text = "Waiting for process...";
            maskedTextBox.Enabled = true;
            LogicListBox.Enabled = true;
        }

        private async void timerWeapon_Tick(object sender, EventArgs e)
        {            
            if (active && weaponTimer > 0) {
                watch.Start();
                cooldown = (int)(watch.ElapsedMilliseconds / 1000) % weaponTimer;
                progressWeapon.Value = cooldown;

                if (weaponTimer > 0 && cooldown == 0)
                {
                    Keyboard.KeyDown(Keys.D1);
                    await Task.Delay(100);
                    Keyboard.KeyUp(Keys.D1);
                }
            }
        }

        private void loadScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open You Script";
            openFileDialog.Filter = "TXT files|*.txt";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                scriptFileName = openFileDialog.FileName;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aboutBox != null)
            {
                if (!aboutBox.Visible)
                {
                    aboutBox.Show();
                }
            }
            else
            {
                aboutBox = new AboutBox();
                aboutBox.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
