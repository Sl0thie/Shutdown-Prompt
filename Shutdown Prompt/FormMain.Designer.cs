namespace Shutdown_Prompt
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            ContinueButton = new Button();
            ShutdownButton = new Button();
            TimeDisplay = new Label();
            MainTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(455, 80);
            label1.TabIndex = 0;
            label1.Text = "This system has be automated to shutdown. If you wish to continue using this system you may, without any adverse affects. Please click 'Continue Using System' below to do so. ";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(12, 151);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(205, 36);
            ContinueButton.TabIndex = 1;
            ContinueButton.Text = "Continue Using System";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // ShutdownButton
            // 
            ShutdownButton.Location = new Point(265, 151);
            ShutdownButton.Name = "ShutdownButton";
            ShutdownButton.Size = new Size(205, 36);
            ShutdownButton.TabIndex = 2;
            ShutdownButton.Text = "Shutdown Now";
            ShutdownButton.UseVisualStyleBackColor = true;
            ShutdownButton.Click += ShutdownButton_Click;
            // 
            // TimeDisplay
            // 
            TimeDisplay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimeDisplay.Location = new Point(12, 89);
            TimeDisplay.Name = "TimeDisplay";
            TimeDisplay.Size = new Size(458, 30);
            TimeDisplay.TabIndex = 3;
            TimeDisplay.Text = "Shut down in 0:00:00";
            TimeDisplay.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Interval = 1000;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 196);
            Controls.Add(TimeDisplay);
            Controls.Add(ShutdownButton);
            Controls.Add(ContinueButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Shutdown";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button ContinueButton;
        private Button ShutdownButton;
        private Label TimeDisplay;
        private System.Windows.Forms.Timer MainTimer;
    }
}
