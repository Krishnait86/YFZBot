namespace YFBot.Capture {
    partial class CaptureForm {
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
            this.captureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureBox
            // 
            this.captureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.captureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureBox.Location = new System.Drawing.Point(0, 0);
            this.captureBox.Name = "captureBox";
            this.captureBox.Size = new System.Drawing.Size(523, 327);
            this.captureBox.TabIndex = 0;
            this.captureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 25;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 327);
            this.Controls.Add(this.captureBox);
            this.Name = "CaptureForm";
            this.Text = "CaptureWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CaptureForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox captureBox;
        private System.Windows.Forms.Timer timer;
    }
}