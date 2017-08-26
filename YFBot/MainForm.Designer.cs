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
            this.buttonGetProcesses = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogicListBox
            // 
            this.LogicListBox.FormattingEnabled = true;
            this.LogicListBox.Items.AddRange(new object[] {
            "attackLogic",
            "defendLogic"});
            this.LogicListBox.Location = new System.Drawing.Point(9, 9);
            this.LogicListBox.Name = "LogicListBox";
            this.LogicListBox.Size = new System.Drawing.Size(149, 21);
            this.LogicListBox.TabIndex = 0;
            // 
            // buttonGetProcesses
            // 
            this.buttonGetProcesses.Location = new System.Drawing.Point(167, 9);
            this.buttonGetProcesses.Name = "buttonGetProcesses";
            this.buttonGetProcesses.Size = new System.Drawing.Size(85, 26);
            this.buttonGetProcesses.TabIndex = 1;
            this.buttonGetProcesses.Text = "Power On";
            this.buttonGetProcesses.UseVisualStyleBackColor = true;
            this.buttonGetProcesses.Visible = false;
            this.buttonGetProcesses.Click += new System.EventHandler(this.buttonGetProcesses_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(167, 64);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 26);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(167, 41);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(87, 17);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "    Ready      ";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(9, 73);
            this.labelInfo.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(84, 13);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Select And Start";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(167, 64);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(85, 26);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 100);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.buttonGetProcesses);
            this.Controls.Add(this.LogicListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YFZBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LogicListBox;
        private System.Windows.Forms.Button buttonGetProcesses;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonStop;
    }
}

