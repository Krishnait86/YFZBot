namespace YFBot {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.LogicListBox = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolGameFindStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCaptureWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogicListBox
            // 
            this.LogicListBox.FormattingEnabled = true;
            this.LogicListBox.Items.AddRange(new object[] {
            "attackLogic",
            "defendLogic"});
            this.LogicListBox.Location = new System.Drawing.Point(12, 35);
            this.LogicListBox.Name = "LogicListBox";
            this.LogicListBox.Size = new System.Drawing.Size(149, 21);
            this.LogicListBox.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(170, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 26);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(170, 90);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(85, 26);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolGameFindStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 126);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(266, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolGameFindStatus
            // 
            this.toolGameFindStatus.Name = "toolGameFindStatus";
            this.toolGameFindStatus.Size = new System.Drawing.Size(100, 17);
            this.toolGameFindStatus.Text = "Waiting process...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Weapon timer :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(266, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCaptureWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openCaptureWindowToolStripMenuItem
            // 
            this.openCaptureWindowToolStripMenuItem.Name = "openCaptureWindowToolStripMenuItem";
            this.openCaptureWindowToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openCaptureWindowToolStripMenuItem.Text = "Open Capture Window";
            this.openCaptureWindowToolStripMenuItem.Click += new System.EventHandler(this.openCaptureWindowToolStripMenuItem_Click);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Location = new System.Drawing.Point(94, 67);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(29, 20);
            this.timerTextBox.TabIndex = 9;
            this.timerTextBox.Text = "0";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 99);
            this.labelInfo.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(84, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Select And Start";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.LogicListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YFZBot";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LogicListBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolGameFindStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCaptureWindowToolStripMenuItem;
        private System.Windows.Forms.TextBox timerTextBox;
        private System.Windows.Forms.Label labelInfo;
    }
}

