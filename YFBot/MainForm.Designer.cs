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
            this.buttonAction = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolGameFindStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.progressWeapon = new System.Windows.Forms.ProgressBar();
            this.timerWeapon = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
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
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(167, 64);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(85, 26);
            this.buttonAction.TabIndex = 3;
            this.buttonAction.Text = "Start";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolGameFindStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 98);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(259, 22);
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
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Weapon period:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.AllowPromptAsInput = false;
            this.maskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox.Location = new System.Drawing.Point(91, 41);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.PromptChar = '0';
            this.maskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox.Size = new System.Drawing.Size(29, 20);
            this.maskedTextBox.TabIndex = 9;
            this.maskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // progressWeapon
            // 
            this.progressWeapon.Location = new System.Drawing.Point(9, 64);
            this.progressWeapon.Name = "progressWeapon";
            this.progressWeapon.Size = new System.Drawing.Size(111, 14);
            this.progressWeapon.TabIndex = 11;
            // 
            // timerWeapon
            // 
            this.timerWeapon.Enabled = true;
            this.timerWeapon.Tick += new System.EventHandler(this.timerWeapon_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 120);
            this.Controls.Add(this.progressWeapon);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.LogicListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(520, 820);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "YFZBot";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LogicListBox;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolGameFindStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.ProgressBar progressWeapon;
        private System.Windows.Forms.Timer timerWeapon;
    }
}

